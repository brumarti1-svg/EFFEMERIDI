' ============================================================
' StubsAntenna.vb — funzioni di invio/log richieste dal codice
' condiviso (Managment.vb) ma mai realmente eseguite in Effemeridi
' (nessun canale è mai "Socket=S"/connesso: Effemeridi non ha un
' vero canale ACU). Esistono solo per far compilare il codice
' condiviso senza duplicarne la logica reale (che vive nei
' Gestione.vb di BTS1/FOC6, non applicabile qui).
' ============================================================

Module StubsAntenna

    Public Sub SendMain(ind As Integer, msg As String)
    End Sub

    Public Sub SendMac(ind As Integer, msg As String)
    End Sub

    Public Sub SendRX(ind As Integer, msg As String)
    End Sub

    Public Sub SendDC(ind As Integer, msg As String)
    End Sub

    Public Sub ScriviLOG(msg As String, tipo As Integer)
    End Sub

    Public Sub ScriviLOG1(msg As String, tipo As Integer)
    End Sub

    ' Usata solo da frmAntenne.vb quando si "seleziona" un'antenna per
    ' avviare una vera acquisizione hardware — non applicabile qui.
    Public Sub PredisponiAcquisizione()
    End Sub

End Module
