<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class animales
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
        Me.ComboBox_animales = New System.Windows.Forms.ComboBox()
        Me.btn_patas = New System.Windows.Forms.Button()
        Me.btn_desvanecer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox_animales
        '
        Me.ComboBox_animales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_animales.FormattingEnabled = True
        Me.ComboBox_animales.Items.AddRange(New Object() {"Perro", "Jirafa", "Pez", "Loro", "Pato", "Serpiente", "Ciempies"})
        Me.ComboBox_animales.Location = New System.Drawing.Point(59, 57)
        Me.ComboBox_animales.Name = "ComboBox_animales"
        Me.ComboBox_animales.Size = New System.Drawing.Size(244, 21)
        Me.ComboBox_animales.TabIndex = 0
        '
        'btn_patas
        '
        Me.btn_patas.Location = New System.Drawing.Point(133, 105)
        Me.btn_patas.Name = "btn_patas"
        Me.btn_patas.Size = New System.Drawing.Size(104, 23)
        Me.btn_patas.TabIndex = 1
        Me.btn_patas.Text = "Ver patas"
        Me.btn_patas.UseVisualStyleBackColor = True
        '
        'btn_desvanecer
        '
        Me.btn_desvanecer.Location = New System.Drawing.Point(122, 372)
        Me.btn_desvanecer.Name = "btn_desvanecer"
        Me.btn_desvanecer.Size = New System.Drawing.Size(150, 23)
        Me.btn_desvanecer.TabIndex = 2
        Me.btn_desvanecer.Text = "Desvanecer"
        Me.btn_desvanecer.UseVisualStyleBackColor = True
        '
        'animales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 450)
        Me.Controls.Add(Me.btn_desvanecer)
        Me.Controls.Add(Me.btn_patas)
        Me.Controls.Add(Me.ComboBox_animales)
        Me.Name = "animales"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox_animales As ComboBox
    Friend WithEvents btn_patas As Button
    Friend WithEvents btn_desvanecer As Button
End Class
