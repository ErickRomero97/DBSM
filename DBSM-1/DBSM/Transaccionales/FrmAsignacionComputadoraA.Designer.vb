<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsignacionComputadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignacionComputadora))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.ChkVertodo = New System.Windows.Forms.CheckBox()
        Me.PlACA = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboCompu = New System.Windows.Forms.ComboBox()
        Me.TxtAsignacioC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFechaA = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaE = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboAlumno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LsvAsignacionCA = New System.Windows.Forms.ListView()
        Me.ChIdComputadora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodigoAlumno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaAsignacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaEntrega = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PlACA.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(399, 384)
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
        Me.Label14.Location = New System.Drawing.Point(320, 384)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Editar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(235, 384)
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
        Me.Label19.Location = New System.Drawing.Point(158, 384)
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
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(398, 328)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 108
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.BackgroundImage = CType(resources.GetObject("BtnEditar.BackgroundImage"), System.Drawing.Image)
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(314, 328)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 109
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImage = CType(resources.GetObject("BtnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(231, 328)
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
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(152, 328)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 111
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'ChkVertodo
        '
        Me.ChkVertodo.AutoSize = True
        Me.ChkVertodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkVertodo.Location = New System.Drawing.Point(541, 270)
        Me.ChkVertodo.Name = "ChkVertodo"
        Me.ChkVertodo.Size = New System.Drawing.Size(70, 17)
        Me.ChkVertodo.TabIndex = 107
        Me.ChkVertodo.Text = "Ver Todo"
        Me.ChkVertodo.UseVisualStyleBackColor = False
        '
        'PlACA
        '
        Me.PlACA.BackColor = System.Drawing.Color.Transparent
        Me.PlACA.Controls.Add(Me.Label5)
        Me.PlACA.Controls.Add(Me.CboCompu)
        Me.PlACA.Controls.Add(Me.TxtAsignacioC)
        Me.PlACA.Controls.Add(Me.Label4)
        Me.PlACA.Controls.Add(Me.DtpFechaA)
        Me.PlACA.Controls.Add(Me.Label3)
        Me.PlACA.Controls.Add(Me.DtpFechaE)
        Me.PlACA.Controls.Add(Me.Label2)
        Me.PlACA.Controls.Add(Me.CboAlumno)
        Me.PlACA.Controls.Add(Me.Label1)
        Me.PlACA.Controls.Add(Me.Label9)
        Me.PlACA.Location = New System.Drawing.Point(36, 121)
        Me.PlACA.Name = "PlACA"
        Me.PlACA.Size = New System.Drawing.Size(485, 192)
        Me.PlACA.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Codigo De Computadora:"
        '
        'CboCompu
        '
        Me.CboCompu.FormattingEnabled = True
        Me.CboCompu.Location = New System.Drawing.Point(229, 18)
        Me.CboCompu.Name = "CboCompu"
        Me.CboCompu.Size = New System.Drawing.Size(121, 21)
        Me.CboCompu.TabIndex = 80
        '
        'TxtAsignacioC
        '
        Me.TxtAsignacioC.Location = New System.Drawing.Point(327, 145)
        Me.TxtAsignacioC.Name = "TxtAsignacioC"
        Me.TxtAsignacioC.Size = New System.Drawing.Size(100, 20)
        Me.TxtAsignacioC.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 16)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Estado de Asignacion de Computadora:"
        '
        'DtpFechaA
        '
        Me.DtpFechaA.Location = New System.Drawing.Point(217, 108)
        Me.DtpFechaA.Name = "DtpFechaA"
        Me.DtpFechaA.Size = New System.Drawing.Size(210, 20)
        Me.DtpFechaA.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Fecha de Entrega:"
        '
        'DtpFechaE
        '
        Me.DtpFechaE.Location = New System.Drawing.Point(217, 82)
        Me.DtpFechaE.Name = "DtpFechaE"
        Me.DtpFechaE.Size = New System.Drawing.Size(210, 20)
        Me.DtpFechaE.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Fecha de Asignacion:"
        '
        'CboAlumno
        '
        Me.CboAlumno.FormattingEnabled = True
        Me.CboAlumno.Location = New System.Drawing.Point(229, 51)
        Me.CboAlumno.Name = "CboAlumno"
        Me.CboAlumno.Size = New System.Drawing.Size(121, 21)
        Me.CboAlumno.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Codigo del Alumno:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 50
        '
        'LsvAsignacionCA
        '
        Me.LsvAsignacionCA.BackColor = System.Drawing.Color.White
        Me.LsvAsignacionCA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdComputadora, Me.ChCodigoAlumno, Me.ChFechaAsignacion, Me.ChFechaEntrega, Me.ChDesc})
        Me.LsvAsignacionCA.ContextMenuStrip = Me.CmsOpciones
        Me.LsvAsignacionCA.FullRowSelect = True
        Me.LsvAsignacionCA.GridLines = True
        Me.LsvAsignacionCA.Location = New System.Drawing.Point(0, 426)
        Me.LsvAsignacionCA.Name = "LsvAsignacionCA"
        Me.LsvAsignacionCA.Size = New System.Drawing.Size(686, 152)
        Me.LsvAsignacionCA.TabIndex = 105
        Me.LsvAsignacionCA.UseCompatibleStateImageBehavior = False
        Me.LsvAsignacionCA.View = System.Windows.Forms.View.Details
        '
        'ChIdComputadora
        '
        Me.ChIdComputadora.Text = "Codigo Computadora"
        Me.ChIdComputadora.Width = 111
        '
        'ChCodigoAlumno
        '
        Me.ChCodigoAlumno.Text = "Codigo del Alumno"
        Me.ChCodigoAlumno.Width = 118
        '
        'ChFechaAsignacion
        '
        Me.ChFechaAsignacion.Text = "Fecha de Asignacion"
        Me.ChFechaAsignacion.Width = 95
        '
        'ChFechaEntrega
        '
        Me.ChFechaEntrega.Text = "Fecha Entrega"
        Me.ChFechaEntrega.Width = 107
        '
        'ChDesc
        '
        Me.ChDesc.Text = "Estado de Asignacion de Computadora"
        Me.ChDesc.Width = 250
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(23, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(678, 80)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'FrmAsignacionComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(686, 416)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.ChkVertodo)
        Me.Controls.Add(Me.PlACA)
        Me.Controls.Add(Me.LsvAsignacionCA)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAsignacionComputadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignación Computadora"
        Me.PlACA.ResumeLayout(False)
        Me.PlACA.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents ChkVertodo As CheckBox
    Friend WithEvents PlACA As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents CboCompu As ComboBox
    Friend WithEvents TxtAsignacioC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpFechaA As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaE As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents CboAlumno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LsvAsignacionCA As ListView
    Friend WithEvents ChIdComputadora As ColumnHeader
    Friend WithEvents ChCodigoAlumno As ColumnHeader
    Friend WithEvents ChFechaAsignacion As ColumnHeader
    Friend WithEvents ChFechaEntrega As ColumnHeader
    Friend WithEvents ChDesc As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
