Namespace My
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Try
                System.IO.File.AppendAllText(
                    System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "crash_exit.log"),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & vbCrLf & e.Exception.ToString() & vbCrLf & "----" & vbCrLf)
            Catch
            End Try
        End Sub
    End Class
End Namespace
