<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_comprobar = New System.Windows.Forms.Button()
        Me.txt_comprobar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_comprobar
        '
        Me.btn_comprobar.Location = New System.Drawing.Point(167, 170)
        Me.btn_comprobar.Name = "btn_comprobar"
        Me.btn_comprobar.Size = New System.Drawing.Size(134, 23)
        Me.btn_comprobar.TabIndex = 0
        Me.btn_comprobar.Text = "¿Es numerico?"
        Me.btn_comprobar.UseVisualStyleBackColor = True
        '
        'txt_comprobar
        '
        Me.txt_comprobar.Location = New System.Drawing.Point(136, 144)
        Me.txt_comprobar.Name = "txt_comprobar"
        Me.txt_comprobar.Size = New System.Drawing.Size(194, 20)
        Me.txt_comprobar.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 450)
        Me.Controls.Add(Me.txt_comprobar)
        Me.Controls.Add(Me.btn_comprobar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_comprobar As Button
    Friend WithEvents txt_comprobar As TextBox
End Class
