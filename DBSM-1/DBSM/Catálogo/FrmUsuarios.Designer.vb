<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Me.LsvMostrarUsuario = New System.Windows.Forms.ListView()
        Me.ChIdUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChContraseña = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpcion = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChkMostrarTodo = New System.Windows.Forms.CheckBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmsOpcion.SuspendLayout()
        Me.GbDatosUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvMostrarUsuario
        '
        Me.LsvMostrarUsuario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdUsuario, Me.ChUsuario, Me.ChContraseña, Me.ChEstado, Me.ChEmpleado, Me.ChTipoUsuario})
        Me.LsvMostrarUsuario.ContextMenuStrip = Me.CmsOpcion
        Me.LsvMostrarUsuario.FullRowSelect = True
        Me.LsvMostrarUsuario.GridLines = True
        Me.LsvMostrarUsuario.Location = New System.Drawing.Point(60, 336)
        Me.LsvMostrarUsuario.Name = "LsvMostrarUsuario"
        Me.LsvMostrarUsuario.Size = New System.Drawing.Size(458, 134)
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
        Me.ChUsuario.Width = 80
        '
        'ChContraseña
        '
        Me.ChContraseña.Text = "Contraseña"
        Me.ChContraseña.Width = 76
        '
        'ChEstado
        '
        Me.ChEstado.Text = "Estado"
        '
        'ChEmpleado
        '
        Me.ChEmpleado.Text = "Id Empleado"
        Me.ChEmpleado.Width = 89
        '
        'ChTipoUsuario
        '
        Me.ChTipoUsuario.Text = "Tipo Usuario"
        Me.ChTipoUsuario.Width = 82
        '
        'CmsOpcion
        '
        Me.CmsOpcion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpcion.Name = "CmsOpcion"
        Me.CmsOpcion.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ChkMostrarTodo
        '
        Me.ChkMostrarTodo.AutoSize = True
        Me.ChkMostrarTodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkMostrarTodo.Location = New System.Drawing.Point(449, 285)
        Me.ChkMostrarTodo.Name = "ChkMostrarTodo"
        Me.ChkMostrarTodo.Size = New System.Drawing.Size(89, 17)
        Me.ChkMostrarTodo.TabIndex = 38
        Me.ChkMostrarTodo.Text = "Mostrar Todo"
        Me.ChkMostrarTodo.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(358, 280)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 37
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(277, 280)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 36
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(196, 280)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 35
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(113, 280)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 34
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'GbDatosUsuario
        '
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
        Me.GbDatosUsuario.Location = New System.Drawing.Point(113, 49)
        Me.GbDatosUsuario.Name = "GbDatosUsuario"
        Me.GbDatosUsuario.Size = New System.Drawing.Size(337, 216)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Gestión Usuario"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 313)
        Me.Controls.Add(Me.LsvMostrarUsuario)
        Me.Controls.Add(Me.ChkMostrarTodo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GbDatosUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUsuarios"
        Me.Text = "Gestión Usuarios"
        Me.CmsOpcion.ResumeLayout(False)
        Me.GbDatosUsuario.ResumeLayout(False)
        Me.GbDatosUsuario.PerformLayout()
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
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents CmsOpcion As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
