<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Buttonhola = New System.Windows.Forms.Button()
        Me.lbltitulo = New System.Windows.Forms.Label()
        Me.txthola = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Buttonhola
        '
        Me.Buttonhola.Location = New System.Drawing.Point(331, 330)
        Me.Buttonhola.Name = "Buttonhola"
        Me.Buttonhola.Size = New System.Drawing.Size(101, 38)
        Me.Buttonhola.TabIndex = 0
        Me.Buttonhola.Text = "Button1"
        Me.Buttonhola.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.AutoSize = True
        Me.lbltitulo.Location = New System.Drawing.Point(349, 175)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(39, 13)
        Me.lbltitulo.TabIndex = 1
        Me.lbltitulo.Text = "Label1"
        '
        'txthola
        '
        Me.txthola.Location = New System.Drawing.Point(293, 220)
        Me.txthola.Name = "txthola"
        Me.txthola.Size = New System.Drawing.Size(172, 20)
        Me.txthola.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txthola)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.Buttonhola)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonhola As Button
    Friend WithEvents lbltitulo As Label
    Friend WithEvents txthola As TextBox
End Class
