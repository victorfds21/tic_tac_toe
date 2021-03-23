<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_nuevo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_nuevo
        '
        Me.Btn_nuevo.Location = New System.Drawing.Point(47, 23)
        Me.Btn_nuevo.Name = "Btn_nuevo"
        Me.Btn_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Btn_nuevo.TabIndex = 0
        Me.Btn_nuevo.Text = "Mostrar"
        Me.Btn_nuevo.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_nuevo)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_nuevo As Button
End Class
