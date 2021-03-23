Public Class Form1


    Private Sub lblhola_Click(sender As Object, e As EventArgs) Handles lbltitulo.Click


        Dim mensaje As String
        mensaje = "Dale al boton y muestra el mensaje:"

        'Cambia las propiedades del texto de los controles'
        lbltitulo.Text = mensaje
        Buttonhola.Text = "Generar mensaje"

    End Sub

    Private Sub Buttonhola_Click(sender As Object, e As EventArgs) Handles Buttonhola.Click
        'cambia la propiedad de texto de texbox'
        txthola.ReadOnly = True
        txthola.Text = "Hola mundo!"

        lbltitulo.ResetText()
    End Sub

End Class