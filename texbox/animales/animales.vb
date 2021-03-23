Public Class animales
    Private Sub ComboBox_animales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_animales.SelectedIndexChanged


    End Sub

    Private Sub btn_patas_Click(sender As Object, e As EventArgs) Handles btn_patas.Click

        Dim animales As String = LCase(ComboBox_animales.Text)

        Select Case animales
            Case "perro", "jirafa"
                MessageBox.Show("tiene cuatro patas")
            Case "loro", "pato"
                MessageBox.Show("tiene dos patas")
            Case "pez", "serpiente"
                MessageBox.Show("no tienen patas")
            Case "ciempies"
                MessageBox.Show("tiene cien pies")
        End Select
    End Sub

    Private Sub btn_desvanecer_Click(sender As Object, e As EventArgs) Handles btn_desvanecer.Click

        'Dimensiona la variable de opacidad' 
        Dim sngOpacidad As Single

        'Entra ek bucle for para disminuir gradualmente la opacidad'
        For sngOpacidad = 1 To 0 Step -0.05

            'asigna la opacidad de la variable a la propiedad'
            Me.Opacity = sngOpacidad

            'repinta el formulario'
            Me.Refresh()

            'crea una pausa'
            System.Threading.Thread.Sleep(200)

        Next

        'le devolvemos la opacidad'
        Me.Opacity = 1

    End Sub
End Class
