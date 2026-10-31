' ============================================================
' FrmRicezione.vb — stub minimo.
' Effemeridi non ha un vero pannello di controllo antenna: questo
' tipo esiste solo perché il codice condiviso (frmSatelliti,
' Managment.vb...) referenzia "frmRicezione"/MainForm.frmRicezioneInstance
' fra i controlli di un pannello antenna reale. Qui resta sempre
' Nothing (mai istanziato/mostrato): i rami che lo userebbero
' davvero (invio comandi ACU, timeout, ecc.) non vengono mai presi
' in Effemeridi, quindi questi campi non servono a funzionare,
' solo a far compilare il codice condiviso senza duplicarlo.
' ============================================================

Public Class FrmRicezione
    Inherits System.Windows.Forms.Form

    Friend WithEvents LblSatellite As System.Windows.Forms.ComboBox = New System.Windows.Forms.ComboBox()
    Friend LblAzimuth As New System.Windows.Forms.Label()
    Friend LblElevazione As New System.Windows.Forms.Label()
    Friend LblAzimuthC As New System.Windows.Forms.Label()
    Friend LblElevazioneC As New System.Windows.Forms.Label()
    Friend LblAzError As New System.Windows.Forms.Label()
    Friend LblElError As New System.Windows.Forms.Label()
    Friend LblCommand As New System.Windows.Forms.Label()
    Friend WithEvents CmdOffset As New System.Windows.Forms.Button()
    Friend TmrTimeoutMSG(NumCom) As System.Windows.Forms.Timer

End Class
