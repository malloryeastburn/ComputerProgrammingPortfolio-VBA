Public Class frmMain
    Private Sub mnuMainMenuFileExit_Click(sender As Object, e As EventArgs) Handles mnuMainMenuFileExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuMainMenuAboutMe_Click(sender As Object, e As EventArgs) Handles mnuMainMenuAboutMe.Click
        Dim frmAboutMe = New frmAboutMe()
        frmAboutMe.ShowDialog()
    End Sub
End Class
