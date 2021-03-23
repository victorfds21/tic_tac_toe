Public Class Form1
    Private Sub btn_hola_Click(sender As Object, e As EventArgs) Handles btn_hola.Click

        MessageBox.Show("hola guapo!", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        ' Comprueba el resultado de messagebox

        If MessageBox.Show("hola guapo!", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then

            ' cambia el atributo del formulario
            Me.BackColor = Color.LightSteelBlue

            Form2.Show()


        End If
    End Sub



    Private Sub btn_hola_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_hola.MouseDown

        If e.Clicks = 5 Then
            MessageBox.Show("hola guapo!")



        End If

    End Sub

End Class
