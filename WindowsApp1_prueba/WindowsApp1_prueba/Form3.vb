Public Class Form3
    Private Sub Btn_nuevo_Click(sender As Object, e As EventArgs) Handles Btn_nuevo.Click

        Form2.MdiParent = Me.MdiParent
        Form2.Show()
        Form1.Show()

    End Sub
End Class