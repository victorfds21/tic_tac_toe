Public Class Form2
    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click

        'si el usuario selecciona una imagen y le da ok ...

        If ofd_selector.ShowDialog = DialogResult.OK Then

            'cogeremos la imagen y la asignaremos al visor
            pic_visor.Image = Image.FromFile(ofd_selector.FileName)

            'cuando la imagen se muestre, tambien mostrara la ruta del archivo
            Me.Text = ofd_selector.FileName

        End If

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'cierra el formulario actual

        Me.Close()

    End Sub

    Private Sub btn_agrandar_Click(sender As Object, e As EventArgs) Handles btn_agrandar.Click

        Me.Height += 10
        Me.Width += 10

        'Declaro una variable de tipo size para asignar un valor tipo Drawing.size'
        ' Dim tamaño As Drawing.Size'
        'tamaño.Width = 600'
        ' tamaño.Height = 500 '




    End Sub

    Private Sub btn_reducir_Click(sender As Object, e As EventArgs) Handles btn_reducir.Click
        Me.Height -= 10
        Me.Width -= 10
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_bordes_Click(sender As Object, e As EventArgs) Handles btn_bordes.Click

        'Declaramos variable de tipo grafico'

        Dim objGraphic As Graphics

        'Creamos el grafico dentro del formulario'
        objGraphic = Me.CreateGraphics

        'Restablecemos el grafico'

        objGraphic.Clear(SystemColors.Control)

        'Dibujamos el rectangulo eliginedo el "pincel", la posicion, la anchura y altura'

        objGraphic.DrawRectangle(Pens.Green,
                                 pic_visor.Left - 1, pic_visor.Top - 1,
                                 pic_visor.Width + 1, pic_visor.Height + 1)

        'Borramos la variable de tipo objeto para '

        objGraphic.Dispose()

    End Sub

    Private Sub pic_visor_MouseMove(sender As Object, e As MouseEventArgs) Handles pic_visor.MouseMove

        'Asignamos al texto


        Lbl_x.Text = "X: " & e.X

        Lbl_y.Text = "Y:" & e.Y


    End Sub

    Private Sub pic_visor_MouseLeave(sender As Object, e As EventArgs) Handles pic_visor.MouseLeave

        'Borramos los datos 

        Lbl_x.Text = "X: "

        Lbl_y.Text = "Y:"

    End Sub

    Private Sub pic_visor_Click(sender As Object, e As EventArgs) Handles pic_visor.Click

    End Sub

    Private Sub Lbl_x_Click(sender As Object, e As EventArgs) Handles Lbl_x.Click

    End Sub

    Private Sub Lbl_y_Click(sender As Object, e As EventArgs) Handles Lbl_y.Click

    End Sub
End Class