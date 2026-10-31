' ============================================================
' frmMain.vb — contenitore MDI minimo per Effemeridi.
' A differenza di BTS1/FOC6 (dove FrmEffemeridi è un dialogo
' modale richiamato dal menu "Ephemeris"), qui è la finestra
' di lavoro principale, sempre aperta, non modale.
' ============================================================

Partial Public Class FrmMain
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    ' Mai istanziato: Effemeridi non ha un vero pannello antenna, vedi
    ' FrmRicezione.vb. Resta Nothing, letto da frmSatelliti.vb che gestisce
    ' già questo caso.
    Public frmRicezioneInstance As FrmRicezione

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm = Me
        g_Server = LeggiFileIni("Server", "directory")
        g_Database = System.IO.Path.Combine(Application.StartupPath, "Orbite.db")

        Dim conn As New System.Data.SQLite.SQLiteConnection("Data Source=" & g_Database & ";Version=3;")
        conn.Open()
        dbOrbite = New DAODatabase(conn)

        Antenna = LeggiFileIni("Default", "Antenna")
        s_Satellite = LeggiFileIni("Default", "Satellite")

        ' Aggiorna i TLE (righe spuntate "Aggiorna" nella tabella URL) già
        ' all'avvio, stesso punto usato da BTS1/FOC6 (frmMain.vb).
        FrmNorad.AggNorad()
    End Sub

    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' MdiParent va impostato dopo che l'handle della finestra (e quindi
        ' l'area MDI) è stato creato — farlo in Load è troppo presto e
        ' genera "il form specificato come MdiParent non è un MdiContainer".
        MostraEffemeridi(2)   ' Satellite, stesso default del vecchio VB6
    End Sub

    Private Sub MostraEffemeridi(tipo As Integer)
        i_Ephemeris = tipo
        FrmEffemeridi.MdiParent = Me
        FrmEffemeridi.WindowState = FormWindowState.Maximized
        FrmEffemeridi.Show()
        FrmEffemeridi.Focus()
    End Sub

    ' Menu "Satelliti" — stessa struttura del VB6 reale (Moon/Planet/
    ' Satellite/Sun), più Cassiopea A come voce aggiuntiva (nel VB6
    ' originale non è raggiungibile da qui, ma frmEffemeridi la supporta).
    Private Sub MnuMoon_Click(sender As Object, e As EventArgs) Handles MnuMoon.Click
        MostraEffemeridi(1)
    End Sub

    Private Sub MnuPlanet_Click(sender As Object, e As EventArgs) Handles MnuPlanet.Click
        MostraEffemeridi(4)
    End Sub

    Private Sub MnuSatellite_Click(sender As Object, e As EventArgs) Handles MnuSatellite.Click
        MostraEffemeridi(2)
    End Sub

    Private Sub MnuSun_Click(sender As Object, e As EventArgs) Handles MnuSun.Click
        MostraEffemeridi(3)
    End Sub

    Private Sub MnuCassiopea_Click(sender As Object, e As EventArgs) Handles MnuCassiopea.Click
        MostraEffemeridi(0)
    End Sub

    Private Sub MnuNorad_Click(sender As Object, e As EventArgs) Handles MnuNorad.Click
        FrmNorad.ShowDialog(Me)
    End Sub

    Private Sub MnuAntenna_Click(sender As Object, e As EventArgs) Handles MnuAntenna.Click
        FrmAntenne.Show()
    End Sub

    Private Sub MnuOrbitCartesian_Click(sender As Object, e As EventArgs) Handles MnuOrbitCartesian.Click
        FrmVisualizzazione.Show()
    End Sub

    Private Sub MnuOrbitPolar_Click(sender As Object, e As EventArgs) Handles MnuOrbitPolar.Click
        g_GrafPol = True
        FrmPolare.Show()
    End Sub

    Private Sub MnuUrl_Click(sender As Object, e As EventArgs) Handles MnuUrl.Click
        FrmUrl.Show()
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
        Application.Exit()
    End Sub

    Public Property MessaggioStatus As String
        Get
            Return stpMessaggio.Text
        End Get
        Set(value As String)
            stpMessaggio.Text = value
        End Set
    End Property

End Class
