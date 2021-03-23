Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_comprobar.Click
        If IsNumeric(txt_comprobar.Text) Then
            MessageBox.Show("Es un numero")
            txt_comprobar.Text = ""
            txt_comprobar.Focus()
        Else
            MessageBox.Show("Es un string")
            txt_comprobar.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_comprobar.TextChanged

    End Sub
End Class
