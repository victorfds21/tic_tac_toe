Public Class BuscarNumero
    Private Sub lb_buscarNumero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_buscarNumero.SelectedIndexChanged

    End Sub

    Private Sub btn_buscarnumero_Click(sender As Object, e As EventArgs) Handles btn_buscarnumero.Click

        'dimensionamos el contador y la cantidad de numeros a mostrar'

        Dim intBuscar As Integer = 1
        Dim intEncontrados As Integer = 0

        'Queremos que haga este bucle hasta encontrar 10 numeros'
        Do Until intEncontrados = 10

            'si el residuo es 0 es que es divisible entre 3'

            If intBuscar Mod 3 = 0 Then
                'muestra el numero y suma al contador de cantidad de numeros encontrados'

                lb_buscarNumero.Items.Add(CStr(intBuscar))
                intEncontrados = intEncontrados + 1
            End If

            'Sigue el contador'
            intBuscar = intBuscar + 1
        Loop


    End Sub
End Class