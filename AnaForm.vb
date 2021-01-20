Public Class AnaForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wmp.URL = Application.StartupPath + "\müzik.mp3"
    End Sub
End Class