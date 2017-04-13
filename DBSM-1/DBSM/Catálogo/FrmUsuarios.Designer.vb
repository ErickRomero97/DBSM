<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.LsvMostrarUsuario = New System.Windows.Forms.ListView()
        Me.ChIdUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChContraseña = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChkMostrarTodo = New System.Windows.Forms.CheckBox()
        Me.GbDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.MtbIdEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.BtnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.CboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtIdUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmsOpciones.SuspendLayout()
        Me.GbDatosUsuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LsvMostrarUsuario
        '
        Me.LsvMostrarUsuario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdUsuario, Me.ChUsuario, Me.ChContraseña, Me.ChEstado, Me.ChEmpleado, Me.ChTipoUsuario})
        Me.LsvMostrarUsuario.ContextMenuStrip = Me.CmsOpciones
        Me.LsvMostrarUsuario.FullRowSelect = True
        Me.LsvMostrarUsuario.GridLines = True
        Me.LsvMostrarUsuario.Location = New System.Drawing.Point(12, 401)
        Me.LsvMostrarUsuario.Name = "LsvMostrarUsuario"
        Me.LsvMostrarUsuario.Size = New System.Drawing.Size(527, 151)
        Me.LsvMostrarUsuario.TabIndex = 39
        Me.LsvMostrarUsuario.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarUsuario.View = System.Windows.Forms.View.Details
        '
        'ChIdUsuario
        '
        Me.ChIdUsuario.Text = "Id Usuario"
        Me.ChIdUsuario.Width = 67
        '
        'ChUsuario
        '
        Me.ChUsuario.Text = "Usuario"
        Me.ChUsuario.Width = 91
        '
        'ChContraseña
        '
        Me.ChContraseña.Text = "Contraseña"
        Me.ChContraseña.Width = 88
        '
        'ChEstado
        '
        Me.ChEstado.Text = "Estado"
        Me.ChEstado.Width = 74
        '
        'ChEmpleado
        '
        Me.ChEmpleado.Text = "Id Empleado"
        Me.ChEmpleado.Width = 104
        '
        'ChTipoUsuario
        '
        Me.ChTipoUsuario.Text = "Tipo Usuario"
        Me.ChTipoUsuario.Width = 99
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
        'ChkMostrarTodo
        '
        Me.ChkMostrarTodo.AutoSize = True
        Me.ChkMostrarTodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkMostrarTodo.Location = New System.Drawing.Point(426, 270)
        Me.ChkMostrarTodo.Name = "ChkMostrarTodo"
        Me.ChkMostrarTodo.Size = New System.Drawing.Size(89, 17)
        Me.ChkMostrarTodo.TabIndex = 38
        Me.ChkMostrarTodo.Text = "Mostrar Todo"
        Me.ChkMostrarTodo.UseVisualStyleBackColor = False
        '
        'GbDatosUsuario
        '
        Me.GbDatosUsuario.BackColor = System.Drawing.Color.Transparent
        Me.GbDatosUsuario.Controls.Add(Me.MtbIdEmpleado)
        Me.GbDatosUsuario.Controls.Add(Me.BtnBuscarEmpleado)
        Me.GbDatosUsuario.Controls.Add(Me.CboTipoUsuario)
        Me.GbDatosUsuario.Controls.Add(Me.CboEstado)
        Me.GbDatosUsuario.Controls.Add(Me.TxtContraseña)
        Me.GbDatosUsuario.Controls.Add(Me.TxtUsuario)
        Me.GbDatosUsuario.Controls.Add(Me.TxtIdUsuario)
        Me.GbDatosUsuario.Controls.Add(Me.Label7)
        Me.GbDatosUsuario.Controls.Add(Me.Label6)
        Me.GbDatosUsuario.Controls.Add(Me.Label5)
        Me.GbDatosUsuario.Controls.Add(Me.Label4)
        Me.GbDatosUsuario.Controls.Add(Me.Label3)
        Me.GbDatosUsuario.Controls.Add(Me.Label2)
        Me.GbDatosUsuario.Location = New System.Drawing.Point(83, 99)
        Me.GbDatosUsuario.Name = "GbDatosUsuario"
        Me.GbDatosUsuario.Size = New System.Drawing.Size(337, 203)
        Me.GbDatosUsuario.TabIndex = 33
        Me.GbDatosUsuario.TabStop = False
        Me.GbDatosUsuario.Text = "Datos del usuario"
        '
        'MtbIdEmpleado
        '
        Me.MtbIdEmpleado.Enabled = False
        Me.MtbIdEmpleado.Location = New System.Drawing.Point(141, 140)
        Me.MtbIdEmpleado.Mask = "0000-0000-00000"
        Me.MtbIdEmpleado.Name = "MtbIdEmpleado"
        Me.MtbIdEmpleado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.MtbIdEmpleado.TabIndex = 14
        '
        'BtnBuscarEmpleado
        '
        Me.BtnBuscarEmpleado.Location = New System.Drawing.Point(247, 139)
        Me.BtnBuscarEmpleado.Name = "BtnBuscarEmpleado"
        Me.BtnBuscarEmpleado.Size = New System.Drawing.Size(28, 22)
        Me.BtnBuscarEmpleado.TabIndex = 13
        Me.BtnBuscarEmpleado.Text = "..."
        Me.BtnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'CboTipoUsuario
        '
        Me.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoUsuario.FormattingEnabled = True
        Me.CboTipoUsuario.Location = New System.Drawing.Point(141, 167)
        Me.CboTipoUsuario.Name = "CboTipoUsuario"
        Me.CboTipoUsuario.Size = New System.Drawing.Size(121, 21)
        Me.CboTipoUsuario.TabIndex = 12
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(141, 112)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(121, 21)
        Me.CboEstado.TabIndex = 11
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(141, 86)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TxtContraseña.TabIndex = 9
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(141, 60)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 8
        '
        'TxtIdUsuario
        '
        Me.TxtIdUsuario.Location = New System.Drawing.Point(141, 34)
        Me.TxtIdUsuario.Name = "TxtIdUsuario"
        Me.TxtIdUsuario.ReadOnly = True
        Me.TxtIdUsuario.Size = New System.Drawing.Size(64, 20)
        Me.TxtIdUsuario.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Tipo Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Codigo Empleado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código Usuario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(366, 360)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(282, 360)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "Editar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(184, 360)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 100
        Me.Label15.Text = "Guardar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(101, 360)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 15)
        Me.Label19.TabIndex = 101
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
        Me.BtnCancelar.Location = New System.Drawing.Point(365, 312)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 94
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(271, 312)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 95
        Me.BtnEditar.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(181, 312)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 96
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
        Me.BtnNuevo.Location = New System.Drawing.Point(94, 312)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 97
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(9, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(581, 67)
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 393)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LsvMostrarUsuario)
        Me.Controls.Add(Me.ChkMostrarTodo)
        Me.Controls.Add(Me.GbDatosUsuario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Usuarios"
        Me.CmsOpciones.ResumeLayout(False)
        Me.GbDatosUsuario.ResumeLayout(False)
        Me.GbDatosUsuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvMostrarUsuario As ListView
    Friend WithEvents ChIdUsuario As ColumnHeader
    Friend WithEvents ChUsuario As ColumnHeader
    Friend WithEvents ChContraseña As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents ChEmpleado As ColumnHeader
    Friend WithEvents ChTipoUsuario As ColumnHeader
    Friend WithEvents ChkMostrarTodo As CheckBox
    Friend WithEvents GbDatosUsuario As GroupBox
    Friend WithEvents MtbIdEmpleado As MaskedTextBox
    Friend WithEvents BtnBuscarEmpleado As Button
    Friend WithEvents CboTipoUsuario As ComboBox
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtIdUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
End Class
