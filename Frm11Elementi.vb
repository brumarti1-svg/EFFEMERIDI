Imports System.Windows.Forms
Imports System.Data.SQLite

' ============================================================
' Frm11Elementi.vb — 11 Elements parameter editor
' Migrato da frm11Parametri.frm (VB6/DAO) → SQLite
' ============================================================

Partial Public Class Frm11Elementi
    Inherits System.Windows.Forms.Form

    Private X As Double
    Private hFile As Double
    Private Tempo As Date, Tempo1 As Date, inizio As Integer
    Private d_partenza As Date
    Private i As Double, ii As String
    Private interval As Integer, Fine As Integer
    Private delta As Double, tsince As Double
    Private Time As Double

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Frm11Elementi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inizialize()
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
        SalvaParametri()
    End Sub

    Private Sub MnuUpdate_Click(sender As Object, e As EventArgs) Handles MnuUpdate.Click
        AggiornaParametri()
    End Sub

    ' -------------------------------------------------------
    ' Salva o aggiorna il record nel DB SQLite
    ' -------------------------------------------------------
    Private Sub SalvaParametri()
        Try
            TxtSatellite.Text = s_Satellite
            Dim conn As SQLiteConnection = CType(dbOrbite, DAODatabase).Connection

            Dim exists As Boolean = False
            Using CmdCheck As New SQLiteCommand(
                "SELECT COUNT(*) FROM Sat11Par WHERE Name=@n", conn)
                CmdCheck.Parameters.AddWithValue("@n", TxtSatellite.Text)
                exists = CInt(CmdCheck.ExecuteScalar()) > 0
            End Using

            Dim sql As String
            If exists Then
                sql = "UPDATE Sat11Par SET year=@yr,mounth=@mo,day=@dy,hour=@hr," &
                      "minute=@mi,second=@se,L0=@l0,L1=@l1,L2=@l2," &
                      "LONC=@lc,LONC1=@lc1,LONS=@ls,LONS1=@ls1," &
                      "LATC=@lac,LATC1=@lac1,LATS=@las,LATS1=@las1 " &
                      "WHERE Name=@n"
            Else
                sql = "INSERT INTO Sat11Par (Name,year,mounth,day,hour,minute,second," &
                      "L0,L1,L2,LONC,LONC1,LONS,LONS1,LATC,LATC1,LATS,LATS1) " &
                      "VALUES (@n,@yr,@mo,@dy,@hr,@mi,@se,@l0,@l1,@l2," &
                      "@lc,@lc1,@ls,@ls1,@lac,@lac1,@las,@las1)"
            End If

            Using Cmd As New SQLiteCommand(sql, conn)
                Cmd.Parameters.AddWithValue("@n",    TxtSatellite.Text)
                Cmd.Parameters.AddWithValue("@yr",   TxtYear.Text)
                Cmd.Parameters.AddWithValue("@mo",   TxtMounth.Text)
                Cmd.Parameters.AddWithValue("@dy",   TxtDay.Text)
                Cmd.Parameters.AddWithValue("@hr",   TxtHour.Text)
                Cmd.Parameters.AddWithValue("@mi",   TxtMinute.Text)
                Cmd.Parameters.AddWithValue("@se",   TxtSecond.Text)
                Cmd.Parameters.AddWithValue("@l0",   If(IsNumeric(TxtLM0.Text),   CDbl(TxtLM0.Text),   0))
                Cmd.Parameters.AddWithValue("@l1",   If(IsNumeric(TxtLM1.Text),   CDbl(TxtLM1.Text),   0))
                Cmd.Parameters.AddWithValue("@l2",   If(IsNumeric(TxtLM2.Text),   CDbl(TxtLM2.Text),   0))
                Cmd.Parameters.AddWithValue("@lc",   If(IsNumeric(TxtLONC.Text),  CDbl(TxtLONC.Text),  0))
                Cmd.Parameters.AddWithValue("@lc1",  If(IsNumeric(TxtLONC1.Text), CDbl(TxtLONC1.Text), 0))
                Cmd.Parameters.AddWithValue("@ls",   If(IsNumeric(TxtLONS.Text),  CDbl(TxtLONS.Text),  0))
                Cmd.Parameters.AddWithValue("@ls1",  If(IsNumeric(TxtLONS1.Text), CDbl(TxtLONS1.Text), 0))
                Cmd.Parameters.AddWithValue("@lac",  If(IsNumeric(TxtLATC.Text),  CDbl(TxtLATC.Text),  0))
                Cmd.Parameters.AddWithValue("@lac1", If(IsNumeric(TxtLATC1.Text), CDbl(TxtLATC1.Text), 0))
                Cmd.Parameters.AddWithValue("@las",  If(IsNumeric(TxtLATS.Text),  CDbl(TxtLATS.Text),  0))
                Cmd.Parameters.AddWithValue("@las1", If(IsNumeric(TxtLATS1.Text), CDbl(TxtLATS1.Text), 0))
                Cmd.ExecuteNonQuery()
            End Using

            ' "s_Satellite = Satellite" era un confronto tra due variabili
            ' ridondanti (unificate in s_Satellite): sempre vero, quindi
            ' rimosso.
            b_Calcola = InitPar11()
            Me.Close()

        Catch ex As Exception
            WriteError(0, "Frm11Elementi.SalvaParametri: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------
    ' Aggiorna i parametri orbitali e reinizializza
    ' -------------------------------------------------------
    Private Sub AggiornaParametri()
        Dim ok As Boolean = Aggiorna(AggAlgo, s_Satellite)
        Dim main As FrmMain = TryCast(Me.MdiParent, FrmMain)
        If ok Then
            If main IsNot Nothing Then
                main.MessaggioStatus = "Parameter OK"
                main.TmrMsg.Enabled = True
            End If
            Inizialize()
        Else
            If main IsNot Nothing Then
                main.MessaggioStatus = "Parameter NOK"
                main.TmrMsg.Enabled = True
            End If
        End If
    End Sub

    ' -------------------------------------------------------
    ' Carica i campi dal DB per il satellite corrente
    ' -------------------------------------------------------
    Private Sub Inizialize()
        Try
            TxtSatellite.Text = s_Satellite
            Dim conn As SQLiteConnection = CType(dbOrbite, DAODatabase).Connection

            Using Cmd As New SQLiteCommand(
                "SELECT * FROM Sat11Par WHERE Name=@n", conn)
                Cmd.Parameters.AddWithValue("@n", s_Satellite)
                Using dr = Cmd.ExecuteReader()
                        If dr.Read() Then
                            TxtYear.Text   = CStr(dr("year"))
                            TxtMounth.Text = CStr(dr("mounth"))
                            TxtDay.Text    = CStr(dr("day"))
                            TxtHour.Text   = CStr(dr("hour"))
                            TxtMinute.Text = CStr(dr("minute"))
                            TxtSecond.Text = CStr(dr("second"))
                            TxtLM0.Text    = CStr(dr("L0"))
                            TxtLM1.Text    = CStr(dr("L1"))
                            TxtLM2.Text    = CStr(dr("L2"))
                            TxtLONC.Text   = CStr(dr("LONC"))
                            TxtLONC1.Text  = CStr(dr("LONC1"))
                            TxtLONS.Text   = CStr(dr("LONS"))
                            TxtLONS1.Text  = CStr(dr("LONS1"))
                            TxtLATC.Text   = CStr(dr("LATC"))
                            TxtLATC1.Text  = CStr(dr("LATC1"))
                            TxtLATS.Text   = CStr(dr("LATS"))
                            TxtLATS1.Text  = CStr(dr("LATS1"))

                            Dim dPart As Date = CDate(dr("day") & "/" & dr("mounth") & "/" & dr("year") & " " &
                                                      dr("hour") & ":" & dr("minute") & ":" & dr("second"))
                            Dim dExp As Date = dPart.AddDays(g_Validi - 1)
                            Dim main As FrmMain = TryCast(Me.MdiParent, FrmMain)
                            If main IsNot Nothing Then
                                If dExp.Date = Now.AddHours(-i_Offset / 24).Date Then
                                    main.MessaggioStatus = "File data not valid 24 hour"
                                    main.TmrMsg.Enabled = True
                                ElseIf dExp < Now Then
                                    main.MessaggioStatus = "File data not valid over 24 hours"
                                    main.TmrMsg.Enabled = True
                                End If
                            End If
                        Else
                            For Each tb As TextBox In {TxtYear, TxtMounth, TxtDay,
                                                        TxtLM0, TxtLM1, TxtLM2,
                                                        TxtLONC, TxtLONC1, TxtLONS, TxtLONS1,
                                                        TxtLATC, TxtLATC1, TxtLATS, TxtLATS1}
                                tb.Text = ""
                            Next
                            TxtHour.Text   = "00"
                            TxtMinute.Text = "00"
                            TxtSecond.Text = "00"
                        End If
                    End Using
                End Using

        Catch ex As Exception
            WriteError(0, "Frm11Elementi.Inizialize: " & ex.Message)
        End Try
    End Sub

End Class
