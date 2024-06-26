Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tF.Text = ((9 / 5) * Val(tC.Text) + 32).ToString()
        tK.Text = (273.15 + Val(tC.Text)).ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tC2.Text = ((Val(tF2.Text) - 32) * 5 / 9).ToString()
        tK2.Text = ((Val(tF2.Text) - 32) * 5 / 9 + 273.15).ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tC3.Text = (Val(tK3.Text) - 273.15).ToString()
        tF3.Text = ((Val(tK3.Text) - 273.15) * 9 / 5 + 32).ToString()
    End Sub
End Class
