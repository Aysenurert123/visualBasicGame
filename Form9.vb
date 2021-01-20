Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label6.Visible = True
        MsgBox("Yanlış Cevap", MsgBoxStyle.Information, "Başarısız")
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label6.Visible = True
        MsgBox("Yanlış Cevap", MsgBoxStyle.Information, "Başarısız")
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label6.Visible = True
        MsgBox("Yanlış Cevap", MsgBoxStyle.Information, "Başarısız")
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label6.Visible = True
        Form10.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value - 1
        Label7.Text = ProgressBar1.Value
        If ProgressBar1.Value = 0 Then
            Label7.Visible = False
            Timer1.Stop()
            Label6.Visible = True
            MsgBox("Süre Bitti.", MsgBoxStyle.Information, "Başarısız")
            End
        End If
    End Sub
End Class