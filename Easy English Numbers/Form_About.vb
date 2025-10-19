Public Class Form_About
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button2.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("https://autastic-media.github.io/home")
        Me.Close()
    End Sub
End Class