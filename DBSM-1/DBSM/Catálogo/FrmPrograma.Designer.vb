<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrograma
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrograma))
        Me.ChkMostrarTodo = New System.Windows.Forms.CheckBox()
        Me.LsvPrograma = New System.Windows.Forms.ListView()
        Me.ChCodPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GbPrograma = New System.Windows.Forms.GroupBox()
        Me.CboTipoPrograma = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombreMPrograma = New System.Windows.Forms.TextBox()
        Me.TxtCodPrograma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbPrograma.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkMostrarTodo
        '
        Me.ChkMostrarTodo.AutoSize = True
        Me.ChkMostrarTodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkMostrarTodo.Location = New System.Drawing.Point(409, 212)
        Me.ChkMostrarTodo.Name = "ChkMostrarTodo"
        Me.ChkMostrarTodo.Size = New System.Drawing.Size(89, 17)
        Me.ChkMostrarTodo.TabIndex = 119
        Me.ChkMostrarTodo.Text = "Mostrar Todo"
        Me.ChkMostrarTodo.UseVisualStyleBackColor = False
        '
        'LsvPrograma
        '
        Me.LsvPrograma.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodPrograma, Me.ChNombre, Me.ChDescripcion, Me.ChTipo})
        Me.LsvPrograma.ContextMenuStrip = Me.CmsOpciones
        Me.LsvPrograma.FullRowSelect = True
        Me.LsvPrograma.Location = New System.Drawing.Point(13, 345)
        Me.LsvPrograma.Name = "LsvPrograma"
        Me.LsvPrograma.Size = New System.Drawing.Size(484, 140)
        Me.LsvPrograma.TabIndex = 118
        Me.LsvPrograma.UseCompatibleStateImageBehavior = False
        Me.LsvPrograma.View = System.Windows.Forms.View.Details
        '
        'ChCodPrograma
        '
        Me.ChCodPrograma.Text = "Cod Programa"
        Me.ChCodPrograma.Width = 93
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre Programa"
        Me.ChNombre.Width = 110
        '
        'ChDescripcion
        '
        Me.ChDescripcion.Text = "Descripcion"
        Me.ChDescripcion.Width = 135
        '
        'ChTipo
        '
        Me.ChTipo.Text = "Tipo Programa"
        Me.ChTipo.Width = 142
        '
        'GbPrograma
        '
        Me.GbPrograma.BackColor = System.Drawing.Color.Transparent
        Me.GbPrograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GbPrograma.Controls.Add(Me.CboTipoPrograma)
        Me.GbPrograma.Controls.Add(Me.Label4)
        Me.GbPrograma.Controls.Add(Me.TxtDescripcion)
        Me.GbPrograma.Controls.Add(Me.Label3)
        Me.GbPrograma.Controls.Add(Me.TxtNombreMPrograma)
        Me.GbPrograma.Controls.Add(Me.TxtCodPrograma)
        Me.GbPrograma.Controls.Add(Me.Label1)
        Me.GbPrograma.Controls.Add(Me.Label11)
        Me.GbPrograma.Controls.Add(Me.Label9)
        Me.GbPrograma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPrograma.Location = New System.Drawing.Point(39, 83)
        Me.GbPrograma.Name = "GbPrograma"
        Me.GbPrograma.Size = New System.Drawing.Size(364, 156)
        Me.GbPrograma.TabIndex = 117
        Me.GbPrograma.TabStop = False
        Me.GbPrograma.Text = "Datos del Programa"
        '
        'CboTipoPrograma
        '
        Me.CboTipoPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPrograma.FormattingEnabled = True
        Me.CboTipoPrograma.Location = New System.Drawing.Point(173, 120)
        Me.CboTipoPrograma.Name = "CboTipoPrograma"
        Me.CboTipoPrograma.Size = New System.Drawing.Size(150, 21)
        Me.CboTipoPrograma.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Tipo de Programa:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(173, 87)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(171, 20)
        Me.TxtDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Descripción:"
        '
        'TxtNombreMPrograma
        '
        Me.TxtNombreMPrograma.Location = New System.Drawing.Point(172, 55)
        Me.TxtNombreMPrograma.Name = "TxtNombreMPrograma"
        Me.TxtNombreMPrograma.Size = New System.Drawing.Size(171, 20)
        Me.TxtNombreMPrograma.TabIndex = 2
        '
        'TxtCodPrograma
        '
        Me.TxtCodPrograma.Location = New System.Drawing.Point(172, 23)
        Me.TxtCodPrograma.Name = "TxtCodPrograma"
        Me.TxtCodPrograma.ReadOnly = True
        Me.TxtCodPrograma.Size = New System.Drawing.Size(53, 20)
        Me.TxtCodPrograma.TabIndex = 1
        Me.TxtCodPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Nombre del Programa:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 16)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Codigó del Programa:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(357, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(262, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Modificar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(175, 306)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Guardar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(92, 306)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 15)
        Me.Label19.TabIndex = 115
        Me.Label19.Text = "Nuevo"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(356, 258)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 108
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(262, 258)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(55, 49)
        Me.BtnModificar.TabIndex = 109
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(172, 258)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 110
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.BackgroundImage = CType(resources.GetObject("BtnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(85, 258)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 111
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(530, 66)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(109, 30)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'FrmPrograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(509, 330)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChkMostrarTodo)
        Me.Controls.Add(Me.LsvPrograma)
        Me.Controls.Add(Me.GbPrograma)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmPrograma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa"
        Me.GbPrograma.ResumeLayout(False)
        Me.GbPrograma.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChkMostrarTodo As CheckBox
    Friend WithEvents LsvPrograma As ListView
    Friend WithEvents ChCodPrograma As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChDescripcion As ColumnHeader
    Friend WithEvents ChTipo As ColumnHeader
    Friend WithEvents GbPrograma As GroupBox
    Friend WithEvents CboTipoPrograma As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombreMPrograma As TextBox
    Friend WithEvents TxtCodPrograma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
End Class
