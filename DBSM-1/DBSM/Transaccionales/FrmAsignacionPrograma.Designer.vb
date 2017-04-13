<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignacionPrograma
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignacionPrograma))
        Me.PlDatos = New System.Windows.Forms.Panel()
        Me.BtnLlenarPrograma = New System.Windows.Forms.Button()
        Me.BtnPrograma = New System.Windows.Forms.Button()
        Me.CboPrograma = New System.Windows.Forms.ComboBox()
        Me.DtpFechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNumLicencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboNumComputadora = New System.Windows.Forms.ComboBox()
        Me.DtpFechaAdquisicion = New System.Windows.Forms.DateTimePicker()
        Me.TxtCodSoftware = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkVer = New System.Windows.Forms.CheckBox()
        Me.LsvAsignacion = New System.Windows.Forms.ListView()
        Me.ChCodigoSoftware = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumLicencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumComputadora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlDatos
        '
        Me.PlDatos.BackColor = System.Drawing.Color.Transparent
        Me.PlDatos.Controls.Add(Me.BtnLlenarPrograma)
        Me.PlDatos.Controls.Add(Me.BtnPrograma)
        Me.PlDatos.Controls.Add(Me.CboPrograma)
        Me.PlDatos.Controls.Add(Me.DtpFechaInstalacion)
        Me.PlDatos.Controls.Add(Me.Label6)
        Me.PlDatos.Controls.Add(Me.Label4)
        Me.PlDatos.Controls.Add(Me.DtpFechaVencimiento)
        Me.PlDatos.Controls.Add(Me.Label3)
        Me.PlDatos.Controls.Add(Me.TxtNumLicencia)
        Me.PlDatos.Controls.Add(Me.Label2)
        Me.PlDatos.Controls.Add(Me.CboEstado)
        Me.PlDatos.Controls.Add(Me.Label11)
        Me.PlDatos.Controls.Add(Me.CboNumComputadora)
        Me.PlDatos.Controls.Add(Me.DtpFechaAdquisicion)
        Me.PlDatos.Controls.Add(Me.TxtCodSoftware)
        Me.PlDatos.Controls.Add(Me.Label12)
        Me.PlDatos.Controls.Add(Me.Label1)
        Me.PlDatos.Controls.Add(Me.Label5)
        Me.PlDatos.Location = New System.Drawing.Point(102, 125)
        Me.PlDatos.Name = "PlDatos"
        Me.PlDatos.Size = New System.Drawing.Size(568, 250)
        Me.PlDatos.TabIndex = 43
        '
        'BtnLlenarPrograma
        '
        Me.BtnLlenarPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLlenarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLlenarPrograma.Location = New System.Drawing.Point(493, 181)
        Me.BtnLlenarPrograma.Name = "BtnLlenarPrograma"
        Me.BtnLlenarPrograma.Size = New System.Drawing.Size(29, 23)
        Me.BtnLlenarPrograma.TabIndex = 106
        Me.BtnLlenarPrograma.Text = "..."
        Me.BtnLlenarPrograma.UseVisualStyleBackColor = False
        '
        'BtnPrograma
        '
        Me.BtnPrograma.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrograma.Location = New System.Drawing.Point(458, 181)
        Me.BtnPrograma.Name = "BtnPrograma"
        Me.BtnPrograma.Size = New System.Drawing.Size(29, 23)
        Me.BtnPrograma.TabIndex = 105
        Me.BtnPrograma.Text = "..."
        Me.BtnPrograma.UseVisualStyleBackColor = False
        '
        'CboPrograma
        '
        Me.CboPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPrograma.FormattingEnabled = True
        Me.CboPrograma.Location = New System.Drawing.Point(306, 182)
        Me.CboPrograma.Name = "CboPrograma"
        Me.CboPrograma.Size = New System.Drawing.Size(149, 21)
        Me.CboPrograma.TabIndex = 104
        '
        'DtpFechaInstalacion
        '
        Me.DtpFechaInstalacion.Location = New System.Drawing.Point(306, 209)
        Me.DtpFechaInstalacion.Name = "DtpFechaInstalacion"
        Me.DtpFechaInstalacion.Size = New System.Drawing.Size(210, 20)
        Me.DtpFechaInstalacion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 16)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Fecha de instalación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Programa:"
        '
        'DtpFechaVencimiento
        '
        Me.DtpFechaVencimiento.Location = New System.Drawing.Point(306, 130)
        Me.DtpFechaVencimiento.Name = "DtpFechaVencimiento"
        Me.DtpFechaVencimiento.Size = New System.Drawing.Size(210, 20)
        Me.DtpFechaVencimiento.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Fecha vencimiento:"
        '
        'TxtNumLicencia
        '
        Me.TxtNumLicencia.Location = New System.Drawing.Point(306, 76)
        Me.TxtNumLicencia.Name = "TxtNumLicencia"
        Me.TxtNumLicencia.Size = New System.Drawing.Size(210, 20)
        Me.TxtNumLicencia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Número de licencia:"
        '
        'CboEstado
        '
        Me.CboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(306, 49)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(97, 21)
        Me.CboEstado.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(178, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Estado licencia:"
        '
        'CboNumComputadora
        '
        Me.CboNumComputadora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboNumComputadora.FormattingEnabled = True
        Me.CboNumComputadora.Location = New System.Drawing.Point(306, 156)
        Me.CboNumComputadora.Name = "CboNumComputadora"
        Me.CboNumComputadora.Size = New System.Drawing.Size(149, 21)
        Me.CboNumComputadora.TabIndex = 6
        '
        'DtpFechaAdquisicion
        '
        Me.DtpFechaAdquisicion.Location = New System.Drawing.Point(306, 104)
        Me.DtpFechaAdquisicion.Name = "DtpFechaAdquisicion"
        Me.DtpFechaAdquisicion.Size = New System.Drawing.Size(210, 20)
        Me.DtpFechaAdquisicion.TabIndex = 4
        '
        'TxtCodSoftware
        '
        Me.TxtCodSoftware.Location = New System.Drawing.Point(306, 19)
        Me.TxtCodSoftware.Name = "TxtCodSoftware"
        Me.TxtCodSoftware.ReadOnly = True
        Me.TxtCodSoftware.Size = New System.Drawing.Size(97, 20)
        Me.TxtCodSoftware.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(152, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Código de Software:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Fecha adquisición:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 16)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Número de computadora:"
        '
        'chkVer
        '
        Me.chkVer.AutoSize = True
        Me.chkVer.BackColor = System.Drawing.Color.Transparent
        Me.chkVer.FlatAppearance.BorderSize = 0
        Me.chkVer.Location = New System.Drawing.Point(684, 337)
        Me.chkVer.Name = "chkVer"
        Me.chkVer.Size = New System.Drawing.Size(66, 17)
        Me.chkVer.TabIndex = 14
        Me.chkVer.Text = "Ver todo"
        Me.chkVer.UseVisualStyleBackColor = False
        '
        'LsvAsignacion
        '
        Me.LsvAsignacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoSoftware, Me.ChEstado, Me.ChNumLicencia, Me.ChFecha1, Me.ChFecha2, Me.ChNumComputadora, Me.ChPrograma, Me.ChFecha3})
        Me.LsvAsignacion.ContextMenuStrip = Me.CmsOpciones
        Me.LsvAsignacion.FullRowSelect = True
        Me.LsvAsignacion.GridLines = True
        Me.LsvAsignacion.Location = New System.Drawing.Point(-6, 519)
        Me.LsvAsignacion.Name = "LsvAsignacion"
        Me.LsvAsignacion.Size = New System.Drawing.Size(851, 185)
        Me.LsvAsignacion.TabIndex = 105
        Me.LsvAsignacion.UseCompatibleStateImageBehavior = False
        Me.LsvAsignacion.View = System.Windows.Forms.View.Details
        '
        'ChCodigoSoftware
        '
        Me.ChCodigoSoftware.Text = "Codigo Software"
        Me.ChCodigoSoftware.Width = 103
        '
        'ChEstado
        '
        Me.ChEstado.Text = "Estado Licencia"
        Me.ChEstado.Width = 102
        '
        'ChNumLicencia
        '
        Me.ChNumLicencia.Text = "Número de Licencia"
        Me.ChNumLicencia.Width = 124
        '
        'ChFecha1
        '
        Me.ChFecha1.Text = "Fecha Adquisición"
        Me.ChFecha1.Width = 108
        '
        'ChFecha2
        '
        Me.ChFecha2.Text = "Fecha Vencimiento"
        Me.ChFecha2.Width = 111
        '
        'ChNumComputadora
        '
        Me.ChNumComputadora.Text = "Numero Computadora"
        Me.ChNumComputadora.Width = 119
        '
        'ChPrograma
        '
        Me.ChPrograma.Text = "Programa"
        Me.ChPrograma.Width = 79
        '
        'ChFecha3
        '
        Me.ChFecha3.Text = "Fecha Instalación"
        Me.ChFecha3.Width = 98
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(521, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(426, 461)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "Modificar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(339, 461)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Guardar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(256, 461)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 15)
        Me.Label19.TabIndex = 123
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
        Me.BtnCancelar.Location = New System.Drawing.Point(520, 413)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 116
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(426, 413)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(55, 49)
        Me.BtnModificar.TabIndex = 117
        Me.BtnModificar.UseVisualStyleBackColor = False
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
        Me.BtnGuardar.Location = New System.Drawing.Point(336, 413)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 118
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
        Me.BtnNuevo.Location = New System.Drawing.Point(249, 413)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 119
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(41, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(836, 80)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
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
        'FrmAsignacionPrograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(840, 479)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.LsvAsignacion)
        Me.Controls.Add(Me.PlDatos)
        Me.Controls.Add(Me.chkVer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAsignacionPrograma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Software"
        Me.PlDatos.ResumeLayout(False)
        Me.PlDatos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlDatos As Panel
    Friend WithEvents CboNumComputadora As ComboBox
    Friend WithEvents TxtCodSoftware As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chkVer As CheckBox
    Protected WithEvents DtpFechaInstalacion As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Protected WithEvents DtpFechaVencimiento As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNumLicencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CboEstado As ComboBox
    Protected WithEvents DtpFechaAdquisicion As DateTimePicker
    Friend WithEvents LsvAsignacion As ListView
    Friend WithEvents ChCodigoSoftware As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents ChNumLicencia As ColumnHeader
    Friend WithEvents ChFecha1 As ColumnHeader
    Friend WithEvents ChFecha2 As ColumnHeader
    Friend WithEvents ChNumComputadora As ColumnHeader
    Friend WithEvents ChPrograma As ColumnHeader
    Friend WithEvents ChFecha3 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents CboPrograma As ComboBox
    Friend WithEvents BtnPrograma As Button
    Friend WithEvents BtnLlenarPrograma As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
