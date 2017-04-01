<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModelo))
        Me.Chkvertodo = New System.Windows.Forms.CheckBox()
        Me.PlModelo = New System.Windows.Forms.Panel()
        Me.CboMarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCodModelo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LsvModelo = New System.Windows.Forms.ListView()
        Me.chIdModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombreModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlModelo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chkvertodo
        '
        Me.Chkvertodo.AutoSize = True
        Me.Chkvertodo.BackColor = System.Drawing.Color.Transparent
        Me.Chkvertodo.Location = New System.Drawing.Point(576, 166)
        Me.Chkvertodo.Name = "Chkvertodo"
        Me.Chkvertodo.Size = New System.Drawing.Size(70, 17)
        Me.Chkvertodo.TabIndex = 63
        Me.Chkvertodo.Text = "Ver Todo"
        Me.Chkvertodo.UseVisualStyleBackColor = False
        '
        'PlModelo
        '
        Me.PlModelo.BackColor = System.Drawing.Color.Transparent
        Me.PlModelo.Controls.Add(Me.CboMarca)
        Me.PlModelo.Controls.Add(Me.Label1)
        Me.PlModelo.Controls.Add(Me.Label8)
        Me.PlModelo.Controls.Add(Me.Label9)
        Me.PlModelo.Controls.Add(Me.TxtModelo)
        Me.PlModelo.Controls.Add(Me.Label10)
        Me.PlModelo.Controls.Add(Me.TxtCodModelo)
        Me.PlModelo.Location = New System.Drawing.Point(130, 54)
        Me.PlModelo.Name = "PlModelo"
        Me.PlModelo.Size = New System.Drawing.Size(443, 129)
        Me.PlModelo.TabIndex = 62
        '
        'CboMarca
        '
        Me.CboMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMarca.FormattingEnabled = True
        Me.CboMarca.Location = New System.Drawing.Point(206, 96)
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.Size = New System.Drawing.Size(171, 21)
        Me.CboMarca.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 15)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Codigo del Modelo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(149, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Marca:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 44
        '
        'TxtModelo
        '
        Me.TxtModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtModelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtModelo.Location = New System.Drawing.Point(206, 54)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(171, 20)
        Me.TxtModelo.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Nombre del Modelo:"
        '
        'TxtCodModelo
        '
        Me.TxtCodModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtCodModelo.Enabled = False
        Me.TxtCodModelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtCodModelo.Location = New System.Drawing.Point(206, 19)
        Me.TxtCodModelo.Name = "TxtCodModelo"
        Me.TxtCodModelo.Size = New System.Drawing.Size(171, 20)
        Me.TxtCodModelo.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Controls.Add(Me.BtnGuardar)
        Me.Panel2.Location = New System.Drawing.Point(193, 190)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 57)
        Me.Panel2.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Cancelar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Editar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Nuevo"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(184, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(52, 36)
        Me.BtnCancelar.TabIndex = 39
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(136, 5)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(42, 36)
        Me.BtnEditar.TabIndex = 38
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(19, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(42, 36)
        Me.BtnNuevo.TabIndex = 36
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(75, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(42, 36)
        Me.BtnGuardar.TabIndex = 37
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'LsvModelo
        '
        Me.LsvModelo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvModelo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdModelo, Me.chNombreModelo, Me.chMarca})
        Me.LsvModelo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvModelo.FullRowSelect = True
        Me.LsvModelo.Location = New System.Drawing.Point(73, 266)
        Me.LsvModelo.Name = "LsvModelo"
        Me.LsvModelo.Size = New System.Drawing.Size(575, 119)
        Me.LsvModelo.TabIndex = 60
        Me.LsvModelo.UseCompatibleStateImageBehavior = False
        Me.LsvModelo.View = System.Windows.Forms.View.Details
        '
        'chIdModelo
        '
        Me.chIdModelo.Text = "Código Modelo"
        Me.chIdModelo.Width = 100
        '
        'chNombreModelo
        '
        Me.chNombreModelo.Text = "Nombre Modelo"
        Me.chNombreModelo.Width = 180
        '
        'chMarca
        '
        Me.chMarca.Text = "Marca"
        Me.chMarca.Width = 180
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(122, 56)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'FrmModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 439)
        Me.Controls.Add(Me.Chkvertodo)
        Me.Controls.Add(Me.PlModelo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LsvModelo)
        Me.Name = "FrmModelo"
        Me.Text = "FrmModelo"
        Me.PlModelo.ResumeLayout(False)
        Me.PlModelo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chkvertodo As CheckBox
    Friend WithEvents PlModelo As Panel
    Friend WithEvents CboMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCodModelo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents LsvModelo As ListView
    Friend WithEvents chIdModelo As ColumnHeader
    Friend WithEvents chNombreModelo As ColumnHeader
    Friend WithEvents chMarca As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
