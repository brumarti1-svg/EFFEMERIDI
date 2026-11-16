Imports System.Runtime.CompilerServices
Imports System.Data.SQLite

' ============================================================
' AppState.vb — variabili globali, copiate da BTS1\AppState.vb.
' Molte (b_Ricezione, ComPort, Canali, parametri antenna...) non
' servono davvero a Effemeridi (nessun vero pannello antenna), ma
' restano referenziate da vari dialoghi condivisi (frmSatelliti,
' FrmTabSat, ecc.) — tenerle è più semplice e sicuro che rischiare
' di romperli togliendole una per una.
' ============================================================

Public Module AppState
    Public MainForm As FrmMain

    ' Variabili di stato generali
    Public b_Calcola As Boolean
    Public b_Parametri As Boolean
    Public b_Ricezione(5) As Boolean
    Public b_Sat As Boolean
    Public b_Checked As Boolean
    Public b_StatusPC1 As Boolean
    Public b_int(5) As Boolean
    Public b_down As Boolean
    Public b_ClosePre As Boolean
    Public b_ClosePreset As Boolean

    ' Configurazione
    Public g_Server As String = ""
    Public g_Database As String = ""
    Public g_Log As String = ""
    Public g_DirBackUp As String = ""
    Public g_IPDC As String = ""
    Public g_Irig As Boolean
    Public g_3Riga As String = ""

    ' Parametri antenna
    Public AzOffset1 As Double
    Public ElOffset1 As Double
    Public AzOffset As Double
    Public ElOffset As Double
    Public AzCalc As Double
    Public ElCalc As Double
    Public LATSTA11 As Double
    Public LONSTA11 As Double
    Public i_Off As Integer
    Public i_Status As Integer
    Public i_StatusDiff As Integer
    Public i_ProgTrack As Integer
    Public i_Cont As Integer
    Public i_InterFre As Integer
    Public i_XT As Integer
    Public i_YT As Integer
    Public i_Log As Integer
    Public i_FreqNew As Integer
    Public i_AsseXGrafico As Integer

    ' Timing
    Public OraAgg As Date
    Public OraACU As Date
    Public MilSec As Long
    Public MilSecF As Long
    Public MilSecL As Long
    Public Const MilOra As Long = 3600000
    Public d_DataInizioProg As String
    Public PTK As Double
    Public DeltaTime As Double
    Public TimeZoneOff As Double
    Public i_Offset As Integer

    ' Frequenze
    Public g_FreqNew As Boolean
    Public g_NewFrequency As Boolean
    Public g_NewLna As Boolean
    Public g_ChangePhase As String = "N"

    ' Rete
    Public nSock As Integer
    Public intSockCnt As Integer
    Public LanPortRx As Integer

    ' Segnali
    Public s_Lev1 As String
    Public NumProMax As Long

    ' Costanti operative
    Public Const NumCom As Integer = 4
    Public Const CNL_1_IN As Integer = 1
    Public Const CNL_2_IN As Integer = 2
    Public Const CNL_3_IN As Integer = 3
    Public Const CNL_4_IN As Integer = 4

    ' Costanti Socket
    Public Const sckConnected As Integer = 7
    Public Const sckConnecting As Integer = 6
    Public Const sckListening As Integer = 8
    Public Const sckError As Integer = 11

    ' Costanti Windows
    Public Const vbUnchecked As Integer = 0
    Public Const vbChecked As Integer = 1

    ' Database
    Public dbOrbite As Object
    Public NoPhasing As Boolean
    Public b_Stars As Boolean
    Public Algoritmo As Integer
    Public grado As Integer
    Friend Canali(0 To 8) As Canale_rec
    Public g_AzTable As Double
    Public g_ElTable As Double

    ' Serial ports — mai usate qui, ma referenziate dal codice condiviso
    Public ComPort(NumCom) As System.IO.Ports.SerialPort

    ' Costanti mancanti (compat DAO + stati porta)
    Public Const dbOpenDynaset As Integer = 2
    Public Const dbOpenSnapshot As Integer = 4
    Public Const PCR_STANDBY As Integer = 2
    Public Const PCR_WAIT As Integer = 0
    Public Const PCS_OK As Integer = 1
    Public Const PCS_FAIL As Integer = 3
    Public Const PCS_NOT_OP As Integer = 6
    Public Const PCS_NORMAL As Integer = 1
    Public ReadOnly PCS_STOP_COL As System.Drawing.Color = System.Drawing.Color.Yellow   ' VB6: vbYellow (non collegato)

    Public AzComandato As Double
    Public ElComandato As Double
    Public BeaconLevel As Double
    Public g_Phase As Double
    Public g_FreqDC As Double

    ' Alias costanti colore VB6
    Public ReadOnly vbRed As System.Drawing.Color = System.Drawing.Color.Red
    Public ReadOnly vbGreen As System.Drawing.Color = System.Drawing.Color.Lime   ' vbGreen = RGB(0,255,0)
    Public ReadOnly vbYellow As System.Drawing.Color = System.Drawing.Color.Yellow
    Public ReadOnly vbBlue As System.Drawing.Color = System.Drawing.Color.Blue

    Public Const rx_Header As Integer = 1234567890
    Public Const rx_Postamble As Integer = -1234567890

    ' Restituisce l'orario corrente corretto per il fuso orario (UTC se Ora=G)
    Public Function NowUTC() As DateTime
        Return DateTime.UtcNow
    End Function

    Public Sub DbExecute(sql As String)
        Try
            Dim conn As SQLiteConnection = CType(dbOrbite, DAODatabase).Connection
            Using Cmd As New SQLiteCommand(sql, conn)
                Cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            WriteError(0, "DbExecute: " & ex.Message & " SQL=" & sql)
        End Try
    End Sub

End Module
