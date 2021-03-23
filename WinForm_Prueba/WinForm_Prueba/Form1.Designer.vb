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
		Me.btn_hola = New System.Windows.Forms.Button()
		Me.lbl_hola = New System.Windows.Forms.Label()
		Me.txb_hola = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btn_hola
		'
		Me.btn_hola.BackColor = System.Drawing.Color.Yellow
		Me.btn_hola.Location = New System.Drawing.Point(290, 305)
		Me.btn_hola.Name = "btn_hola"
		Me.btn_hola.Size = New System.Drawing.Size(160, 35)
		Me.btn_hola.TabIndex = 0
		Me.btn_hola.Text = "Aceptar"
		Me.btn_hola.UseVisualStyleBackColor = False
		'
		'lbl_hola
		'
		Me.lbl_hola.AutoSize = True
		Me.lbl_hola.Location = New System.Drawing.Point(287, 252)
		Me.lbl_hola.Name = "lbl_hola"
		Me.lbl_hola.Size = New System.Drawing.Size(145, 13)
		Me.lbl_hola.TabIndex = 1
		Me.lbl_hola.Text = "Haga click para mostrar texto"
		'
		'txb_hola
		'
		Me.txb_hola.Location = New System.Drawing.Point(290, 279)
		Me.txb_hola.Name = "txb_hola"
		Me.txb_hola.Size = New System.Drawing.Size(160, 20)
		Me.txb_hola.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.txb_hola)
		Me.Controls.Add(Me.lbl_hola)
		Me.Controls.Add(Me.btn_hola)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btn_hola As Button
	Friend WithEvents lbl_hola As Label
	Friend WithEvents txb_hola As TextBox
End Class
