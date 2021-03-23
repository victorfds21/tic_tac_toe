<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.pic_visor = New System.Windows.Forms.PictureBox()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.ofd_selector = New System.Windows.Forms.OpenFileDialog()
        Me.btn_agrandar = New System.Windows.Forms.Button()
        Me.btn_reducir = New System.Windows.Forms.Button()
        Me.btn_bordes = New System.Windows.Forms.Button()
        Me.Lbl_x = New System.Windows.Forms.Label()
        Me.Lbl_y = New System.Windows.Forms.Label()
        CType(Me.pic_visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_visor
        '
        Me.pic_visor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_visor.Location = New System.Drawing.Point(12, 12)
        Me.pic_visor.Name = "pic_visor"
        Me.pic_visor.Size = New System.Drawing.Size(362, 413)
        Me.pic_visor.TabIndex = 0
        Me.pic_visor.TabStop = False
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_seleccionar.Location = New System.Drawing.Point(402, 21)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(118, 36)
        Me.btn_seleccionar.TabIndex = 1
        Me.btn_seleccionar.Text = "Seleccionar"
        Me.btn_seleccionar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(402, 81)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(118, 38)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'ofd_selector
        '
        Me.ofd_selector.Filter = "archivosjpeg|*.jpg|archivospng|*.png"
        Me.ofd_selector.Title = "Seleccionar imagen"
        '
        'btn_agrandar
        '
        Me.btn_agrandar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agrandar.Location = New System.Drawing.Point(393, 382)
        Me.btn_agrandar.Name = "btn_agrandar"
        Me.btn_agrandar.Size = New System.Drawing.Size(60, 34)
        Me.btn_agrandar.TabIndex = 3
        Me.btn_agrandar.Text = " ^"
        Me.btn_agrandar.UseVisualStyleBackColor = True
        '
        'btn_reducir
        '
        Me.btn_reducir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reducir.Location = New System.Drawing.Point(468, 382)
        Me.btn_reducir.Name = "btn_reducir"
        Me.btn_reducir.Size = New System.Drawing.Size(52, 34)
        Me.btn_reducir.TabIndex = 4
        Me.btn_reducir.Text = "v"
        Me.btn_reducir.UseVisualStyleBackColor = True
        '
        'btn_bordes
        '
        Me.btn_bordes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_bordes.Location = New System.Drawing.Point(402, 140)
        Me.btn_bordes.Name = "btn_bordes"
        Me.btn_bordes.Size = New System.Drawing.Size(118, 29)
        Me.btn_bordes.TabIndex = 5
        Me.btn_bordes.Text = "Dibujar bordes"
        Me.btn_bordes.UseVisualStyleBackColor = True
        '
        'Lbl_x
        '
        Me.Lbl_x.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_x.AutoSize = True
        Me.Lbl_x.Location = New System.Drawing.Point(399, 193)
        Me.Lbl_x.Name = "Lbl_x"
        Me.Lbl_x.Size = New System.Drawing.Size(17, 13)
        Me.Lbl_x.TabIndex = 6
        Me.Lbl_x.Text = "X:"
        '
        'Lbl_y
        '
        Me.Lbl_y.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_y.AutoSize = True
        Me.Lbl_y.Location = New System.Drawing.Point(402, 206)
        Me.Lbl_y.Name = "Lbl_y"
        Me.Lbl_y.Size = New System.Drawing.Size(17, 13)
        Me.Lbl_y.TabIndex = 7
        Me.Lbl_y.Text = "Y:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(572, 437)
        Me.Controls.Add(Me.Lbl_y)
        Me.Controls.Add(Me.Lbl_x)
        Me.Controls.Add(Me.btn_bordes)
        Me.Controls.Add(Me.btn_reducir)
        Me.Controls.Add(Me.btn_agrandar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_seleccionar)
        Me.Controls.Add(Me.pic_visor)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.pic_visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_visor As PictureBox
    Friend WithEvents btn_seleccionar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents ofd_selector As OpenFileDialog
    Friend WithEvents btn_agrandar As Button
    Friend WithEvents btn_reducir As Button
    Friend WithEvents btn_bordes As Button
    Friend WithEvents Lbl_x As Label
    Friend WithEvents Lbl_y As Label
End Class
