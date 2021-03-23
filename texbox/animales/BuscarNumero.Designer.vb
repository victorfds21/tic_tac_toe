<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarNumero
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
        Me.btn_buscarnumero = New System.Windows.Forms.Button()
        Me.lb_buscarNumero = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_buscarnumero
        '
        Me.btn_buscarnumero.Location = New System.Drawing.Point(85, 42)
        Me.btn_buscarnumero.Name = "btn_buscarnumero"
        Me.btn_buscarnumero.Size = New System.Drawing.Size(205, 23)
        Me.btn_buscarnumero.TabIndex = 0
        Me.btn_buscarnumero.Text = "Buscar numeros"
        Me.btn_buscarnumero.UseVisualStyleBackColor = True
        '
        'lb_buscarNumero
        '
        Me.lb_buscarNumero.FormattingEnabled = True
        Me.lb_buscarNumero.Location = New System.Drawing.Point(85, 83)
        Me.lb_buscarNumero.Name = "lb_buscarNumero"
        Me.lb_buscarNumero.Size = New System.Drawing.Size(205, 186)
        Me.lb_buscarNumero.TabIndex = 1
        '
        'BuscarNumero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 450)
        Me.Controls.Add(Me.lb_buscarNumero)
        Me.Controls.Add(Me.btn_buscarnumero)
        Me.Name = "BuscarNumero"
        Me.Text = "BuscarNumero"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_buscarnumero As Button
    Friend WithEvents lb_buscarNumero As ListBox
End Class
