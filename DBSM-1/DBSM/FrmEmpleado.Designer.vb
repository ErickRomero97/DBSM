<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Me.ChkMostrarTodo = New System.Windows.Forms.CheckBox()
        Me.LsvDatosEmpleado = New System.Windows.Forms.ListView()
        Me.ChIdEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCorreo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.GbEmpleado = New System.Windows.Forms.GroupBox()
        Me.MtbCodEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.MtbTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmsOpciones.SuspendLayout()
        Me.GbEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChkMostrarTodo
        '
        Me.ChkMostrarTodo.AutoSize = True
        Me.ChkMostrarTodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkMostrarTodo.Location = New System.Drawing.Point(488, 337)
        Me.ChkMostrarTodo.Name = "ChkMostrarTodo"
        Me.ChkMostrarTodo.Size = New System.Drawing.Size(89, 17)
        Me.ChkMostrarTodo.TabIndex = 34
        Me.ChkMostrarTodo.Text = "Mostrar Todo"
        Me.ChkMostrarTodo.UseVisualStyleBackColor = False
        '
        'LsvDatosEmpleado
        '
        Me.LsvDatosEmpleado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdEmpleado, Me.ChNombre, Me.ChApellido, Me.ChDireccion, Me.ChTelefono, Me.ChCorreo, Me.ChSexo})
        Me.LsvDatosEmpleado.ContextMenuStrip = Me.CmsOpciones
        Me.LsvDatosEmpleado.FullRowSelect = True
        Me.LsvDatosEmpleado.GridLines = True
        Me.LsvDatosEmpleado.Location = New System.Drawing.Point(59, 374)
        Me.LsvDatosEmpleado.Name = "LsvDatosEmpleado"
        Me.LsvDatosEmpleado.Size = New System.Drawing.Size(535, 109)
        Me.LsvDatosEmpleado.TabIndex = 33
        Me.LsvDatosEmpleado.UseCompatibleStateImageBehavior = False
        Me.LsvDatosEmpleado.View = System.Windows.Forms.View.Details
        '
        'ChIdEmpleado
        '
        Me.ChIdEmpleado.Text = "Id Empleado"
        Me.ChIdEmpleado.Width = 79
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre "
        Me.ChNombre.Width = 72
        '
        'ChApellido
        '
        Me.ChApellido.Text = "Apellido"
        Me.ChApellido.Width = 74
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        Me.ChDireccion.Width = 105
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Telefono"
        Me.ChTelefono.Width = 76
        '
        'ChCorreo
        '
        Me.ChCorreo.Text = "Correo"
        Me.ChCorreo.Width = 72
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        '
        'CmsOpciones
        '
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(118, 48)
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
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(397, 332)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(316, 332)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 31
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(235, 332)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 30
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(154, 332)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 29
        Me.BtnAgregar.Text = "Nuevo"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'GbEmpleado
        '
        Me.GbEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.GbEmpleado.Controls.Add(Me.MtbCodEmpleado)
        Me.GbEmpleado.Controls.Add(Me.TxtDireccion)
        Me.GbEmpleado.Controls.Add(Me.MtbTelefono)
        Me.GbEmpleado.Controls.Add(Me.Label1)
        Me.GbEmpleado.Controls.Add(Me.CboSexo)
        Me.GbEmpleado.Controls.Add(Me.Label8)
        Me.GbEmpleado.Controls.Add(Me.Label3)
        Me.GbEmpleado.Controls.Add(Me.TxtCorreo)
        Me.GbEmpleado.Controls.Add(Me.TxtNombre)
        Me.GbEmpleado.Controls.Add(Me.Label7)
        Me.GbEmpleado.Controls.Add(Me.Label4)
        Me.GbEmpleado.Controls.Add(Me.Label6)
        Me.GbEmpleado.Controls.Add(Me.TxtApellido)
        Me.GbEmpleado.Controls.Add(Me.Label5)
        Me.GbEmpleado.Location = New System.Drawing.Point(154, 50)
        Me.GbEmpleado.Name = "GbEmpleado"
        Me.GbEmpleado.Size = New System.Drawing.Size(313, 266)
        Me.GbEmpleado.TabIndex = 28
        Me.GbEmpleado.TabStop = False
        Me.GbEmpleado.Text = "Datos Empleado"
        '
        'MtbCodEmpleado
        '
        Me.MtbCodEmpleado.Location = New System.Drawing.Point(129, 37)
        Me.MtbCodEmpleado.Mask = "0000-0000-00000"
        Me.MtbCodEmpleado.Name = "MtbCodEmpleado"
        Me.MtbCodEmpleado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbCodEmpleado.Size = New System.Drawing.Size(121, 20)
        Me.MtbCodEmpleado.TabIndex = 1
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(129, 115)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(156, 49)
        Me.TxtDireccion.TabIndex = 4
        '
        'MtbTelefono
        '
        Me.MtbTelefono.Location = New System.Drawing.Point(130, 170)
        Me.MtbTelefono.Mask = "0000-0000"
        Me.MtbTelefono.Name = "MtbTelefono"
        Me.MtbTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MtbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.MtbTelefono.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IdEmpleado"
        '
        'CboSexo
        '
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(129, 222)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(121, 21)
        Me.CboSexo.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(92, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre empleado"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(130, 196)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(155, 20)
        Me.TxtCorreo.TabIndex = 6
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(129, 63)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(156, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Teléfono"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(129, 89)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(156, 20)
        Me.TxtApellido.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Gestión Empleado"
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 370)
        Me.Controls.Add(Me.ChkMostrarTodo)
        Me.Controls.Add(Me.LsvDatosEmpleado)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GbEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmEmpleado"
        Me.Text = "Gestión Empleado"
        Me.CmsOpciones.ResumeLayout(False)
        Me.GbEmpleado.ResumeLayout(False)
        Me.GbEmpleado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChkMostrarTodo As CheckBox
    Friend WithEvents LsvDatosEmpleado As ListView
    Friend WithEvents ChIdEmpleado As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellido As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChCorreo As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents GbEmpleado As GroupBox
    Friend WithEvents MtbCodEmpleado As MaskedTextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents MtbTelefono As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
