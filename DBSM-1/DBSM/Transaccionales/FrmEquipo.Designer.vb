<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEquipo))
        Me.PlCom = New System.Windows.Forms.Panel()
        Me.BtnActualizarModelo = New System.Windows.Forms.Button()
        Me.BtnActualizarMarca = New System.Windows.Forms.Button()
        Me.CboEstadoA = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtSerieMonitor = New System.Windows.Forms.TextBox()
        Me.TxtRevoDisco = New System.Windows.Forms.TextBox()
        Me.TxtCapRAM = New System.Windows.Forms.TextBox()
        Me.TxtCapDisco = New System.Windows.Forms.TextBox()
        Me.CboTipoMonitor = New System.Windows.Forms.ComboBox()
        Me.CboMouse = New System.Windows.Forms.ComboBox()
        Me.CboTipoPC = New System.Windows.Forms.ComboBox()
        Me.CboTeclado = New System.Windows.Forms.ComboBox()
        Me.CboModelo = New System.Windows.Forms.ComboBox()
        Me.CboMarca = New System.Windows.Forms.ComboBox()
        Me.TxtDescPro = New System.Windows.Forms.TextBox()
        Me.TxtSerieCompu = New System.Windows.Forms.TextBox()
        Me.TxtNumMaquina = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnIrModelo = New System.Windows.Forms.Button()
        Me.BtnIrMarca = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkVerTodo = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.LsvEquipo = New System.Windows.Forms.ListView()
        Me.chNumMaquina = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSerie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMouse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTeclado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipoMonitor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDiscoDuro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipoPc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRevo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSerieMo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PlCom.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlCom
        '
        Me.PlCom.BackColor = System.Drawing.Color.Transparent
        Me.PlCom.Controls.Add(Me.BtnActualizarModelo)
        Me.PlCom.Controls.Add(Me.BtnActualizarMarca)
        Me.PlCom.Controls.Add(Me.CboEstadoA)
        Me.PlCom.Controls.Add(Me.Label22)
        Me.PlCom.Controls.Add(Me.Label21)
        Me.PlCom.Controls.Add(Me.Label20)
        Me.PlCom.Controls.Add(Me.TxtSerieMonitor)
        Me.PlCom.Controls.Add(Me.TxtRevoDisco)
        Me.PlCom.Controls.Add(Me.TxtCapRAM)
        Me.PlCom.Controls.Add(Me.TxtCapDisco)
        Me.PlCom.Controls.Add(Me.CboTipoMonitor)
        Me.PlCom.Controls.Add(Me.CboMouse)
        Me.PlCom.Controls.Add(Me.CboTipoPC)
        Me.PlCom.Controls.Add(Me.CboTeclado)
        Me.PlCom.Controls.Add(Me.CboModelo)
        Me.PlCom.Controls.Add(Me.CboMarca)
        Me.PlCom.Controls.Add(Me.TxtDescPro)
        Me.PlCom.Controls.Add(Me.TxtSerieCompu)
        Me.PlCom.Controls.Add(Me.TxtNumMaquina)
        Me.PlCom.Controls.Add(Me.Label7)
        Me.PlCom.Controls.Add(Me.Label6)
        Me.PlCom.Controls.Add(Me.Label5)
        Me.PlCom.Controls.Add(Me.Label10)
        Me.PlCom.Controls.Add(Me.Label16)
        Me.PlCom.Controls.Add(Me.Label8)
        Me.PlCom.Controls.Add(Me.Label17)
        Me.PlCom.Controls.Add(Me.Label12)
        Me.PlCom.Controls.Add(Me.Label18)
        Me.PlCom.Controls.Add(Me.Label1)
        Me.PlCom.Controls.Add(Me.Label11)
        Me.PlCom.Controls.Add(Me.BtnIrModelo)
        Me.PlCom.Controls.Add(Me.BtnIrMarca)
        Me.PlCom.Controls.Add(Me.Label2)
        Me.PlCom.Controls.Add(Me.Label3)
        Me.PlCom.Controls.Add(Me.Label4)
        Me.PlCom.Controls.Add(Me.Label9)
        Me.PlCom.Location = New System.Drawing.Point(0, 100)
        Me.PlCom.Name = "PlCom"
        Me.PlCom.Size = New System.Drawing.Size(802, 253)
        Me.PlCom.TabIndex = 53
        '
        'BtnActualizarModelo
        '
        Me.BtnActualizarModelo.BackgroundImage = CType(resources.GetObject("BtnActualizarModelo.BackgroundImage"), System.Drawing.Image)
        Me.BtnActualizarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizarModelo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizarModelo.FlatAppearance.BorderSize = 0
        Me.BtnActualizarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarModelo.Location = New System.Drawing.Point(365, 102)
        Me.BtnActualizarModelo.Name = "BtnActualizarModelo"
        Me.BtnActualizarModelo.Size = New System.Drawing.Size(26, 23)
        Me.BtnActualizarModelo.TabIndex = 80
        Me.BtnActualizarModelo.UseVisualStyleBackColor = True
        '
        'BtnActualizarMarca
        '
        Me.BtnActualizarMarca.BackgroundImage = CType(resources.GetObject("BtnActualizarMarca.BackgroundImage"), System.Drawing.Image)
        Me.BtnActualizarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizarMarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizarMarca.FlatAppearance.BorderSize = 0
        Me.BtnActualizarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarMarca.Location = New System.Drawing.Point(365, 74)
        Me.BtnActualizarMarca.Name = "BtnActualizarMarca"
        Me.BtnActualizarMarca.Size = New System.Drawing.Size(26, 23)
        Me.BtnActualizarMarca.TabIndex = 79
        Me.BtnActualizarMarca.UseVisualStyleBackColor = True
        '
        'CboEstadoA
        '
        Me.CboEstadoA.FormattingEnabled = True
        Me.CboEstadoA.Location = New System.Drawing.Point(188, 221)
        Me.CboEstadoA.Name = "CboEstadoA"
        Me.CboEstadoA.Size = New System.Drawing.Size(170, 21)
        Me.CboEstadoA.TabIndex = 78
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(53, 222)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 16)
        Me.Label22.TabIndex = 77
        Me.Label22.Text = "Estado Asignacion:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(433, 198)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(154, 16)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Revoluciones del Disco:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(65, 191)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 16)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Serie del Monitor:"
        '
        'TxtSerieMonitor
        '
        Me.TxtSerieMonitor.Location = New System.Drawing.Point(188, 187)
        Me.TxtSerieMonitor.Name = "TxtSerieMonitor"
        Me.TxtSerieMonitor.Size = New System.Drawing.Size(170, 20)
        Me.TxtSerieMonitor.TabIndex = 74
        '
        'TxtRevoDisco
        '
        Me.TxtRevoDisco.Location = New System.Drawing.Point(598, 197)
        Me.TxtRevoDisco.Name = "TxtRevoDisco"
        Me.TxtRevoDisco.Size = New System.Drawing.Size(170, 20)
        Me.TxtRevoDisco.TabIndex = 73
        '
        'TxtCapRAM
        '
        Me.TxtCapRAM.Location = New System.Drawing.Point(598, 110)
        Me.TxtCapRAM.Name = "TxtCapRAM"
        Me.TxtCapRAM.Size = New System.Drawing.Size(170, 20)
        Me.TxtCapRAM.TabIndex = 72
        '
        'TxtCapDisco
        '
        Me.TxtCapDisco.Location = New System.Drawing.Point(188, 161)
        Me.TxtCapDisco.Name = "TxtCapDisco"
        Me.TxtCapDisco.Size = New System.Drawing.Size(170, 20)
        Me.TxtCapDisco.TabIndex = 71
        '
        'CboTipoMonitor
        '
        Me.CboTipoMonitor.FormattingEnabled = True
        Me.CboTipoMonitor.Location = New System.Drawing.Point(597, 18)
        Me.CboTipoMonitor.Name = "CboTipoMonitor"
        Me.CboTipoMonitor.Size = New System.Drawing.Size(171, 21)
        Me.CboTipoMonitor.TabIndex = 70
        '
        'CboMouse
        '
        Me.CboMouse.FormattingEnabled = True
        Me.CboMouse.Location = New System.Drawing.Point(598, 78)
        Me.CboMouse.Name = "CboMouse"
        Me.CboMouse.Size = New System.Drawing.Size(170, 21)
        Me.CboMouse.TabIndex = 70
        '
        'CboTipoPC
        '
        Me.CboTipoPC.FormattingEnabled = True
        Me.CboTipoPC.Location = New System.Drawing.Point(188, 129)
        Me.CboTipoPC.Name = "CboTipoPC"
        Me.CboTipoPC.Size = New System.Drawing.Size(170, 21)
        Me.CboTipoPC.TabIndex = 70
        '
        'CboTeclado
        '
        Me.CboTeclado.FormattingEnabled = True
        Me.CboTeclado.Location = New System.Drawing.Point(598, 51)
        Me.CboTeclado.Name = "CboTeclado"
        Me.CboTeclado.Size = New System.Drawing.Size(170, 21)
        Me.CboTeclado.TabIndex = 70
        '
        'CboModelo
        '
        Me.CboModelo.FormattingEnabled = True
        Me.CboModelo.Location = New System.Drawing.Point(188, 105)
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.Size = New System.Drawing.Size(139, 21)
        Me.CboModelo.TabIndex = 70
        '
        'CboMarca
        '
        Me.CboMarca.FormattingEnabled = True
        Me.CboMarca.Location = New System.Drawing.Point(188, 75)
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.Size = New System.Drawing.Size(139, 21)
        Me.CboMarca.TabIndex = 70
        '
        'TxtDescPro
        '
        Me.TxtDescPro.Location = New System.Drawing.Point(598, 136)
        Me.TxtDescPro.Multiline = True
        Me.TxtDescPro.Name = "TxtDescPro"
        Me.TxtDescPro.Size = New System.Drawing.Size(170, 49)
        Me.TxtDescPro.TabIndex = 69
        '
        'TxtSerieCompu
        '
        Me.TxtSerieCompu.Location = New System.Drawing.Point(188, 48)
        Me.TxtSerieCompu.Name = "TxtSerieCompu"
        Me.TxtSerieCompu.Size = New System.Drawing.Size(170, 20)
        Me.TxtSerieCompu.TabIndex = 69
        '
        'TxtNumMaquina
        '
        Me.TxtNumMaquina.Location = New System.Drawing.Point(188, 19)
        Me.TxtNumMaquina.Name = "TxtNumMaquina"
        Me.TxtNumMaquina.Size = New System.Drawing.Size(66, 20)
        Me.TxtNumMaquina.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(418, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 16)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Capacidad de RAM en Gb:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 16)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Descripción Procesador:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Capacidad de Disco en Gb:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(535, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Mouse:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(501, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 16)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Tipo Monitor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(525, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Teclado:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(119, 134)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 16)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Tipo PC:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 16)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Serie Computadora:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(122, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 16)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Modelo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Marca:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(44, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 16)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Número de Maquina:"
        '
        'BtnIrModelo
        '
        Me.BtnIrModelo.BackgroundImage = CType(resources.GetObject("BtnIrModelo.BackgroundImage"), System.Drawing.Image)
        Me.BtnIrModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnIrModelo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIrModelo.FlatAppearance.BorderSize = 0
        Me.BtnIrModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnIrModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnIrModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIrModelo.Location = New System.Drawing.Point(333, 103)
        Me.BtnIrModelo.Name = "BtnIrModelo"
        Me.BtnIrModelo.Size = New System.Drawing.Size(26, 23)
        Me.BtnIrModelo.TabIndex = 65
        Me.BtnIrModelo.UseVisualStyleBackColor = True
        '
        'BtnIrMarca
        '
        Me.BtnIrMarca.BackgroundImage = CType(resources.GetObject("BtnIrMarca.BackgroundImage"), System.Drawing.Image)
        Me.BtnIrMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnIrMarca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIrMarca.FlatAppearance.BorderSize = 0
        Me.BtnIrMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnIrMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnIrMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIrMarca.Location = New System.Drawing.Point(333, 74)
        Me.BtnIrMarca.Name = "BtnIrMarca"
        Me.BtnIrMarca.Size = New System.Drawing.Size(26, 23)
        Me.BtnIrMarca.TabIndex = 65
        Me.BtnIrMarca.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(253, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(261, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(269, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 30
        '
        'ChkVerTodo
        '
        Me.ChkVerTodo.AutoSize = True
        Me.ChkVerTodo.BackColor = System.Drawing.Color.Transparent
        Me.ChkVerTodo.FlatAppearance.BorderSize = 0
        Me.ChkVerTodo.Location = New System.Drawing.Point(808, 296)
        Me.ChkVerTodo.Name = "ChkVerTodo"
        Me.ChkVerTodo.Size = New System.Drawing.Size(66, 17)
        Me.ChkVerTodo.TabIndex = 54
        Me.ChkVerTodo.Text = "Ver todo"
        Me.ChkVerTodo.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(504, 432)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 82
        Me.Label13.Text = "Cancelar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(430, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 15)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Editar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(347, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Guardar"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(272, 429)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 15)
        Me.Label19.TabIndex = 85
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
        Me.BtnCancelar.Location = New System.Drawing.Point(502, 375)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(55, 49)
        Me.BtnCancelar.TabIndex = 78
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
        Me.BtnEditar.Location = New System.Drawing.Point(422, 375)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(55, 49)
        Me.BtnEditar.TabIndex = 79
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
        Me.BtnGuardar.Location = New System.Drawing.Point(344, 375)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(55, 49)
        Me.BtnGuardar.TabIndex = 80
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
        Me.BtnNuevo.Location = New System.Drawing.Point(267, 376)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(55, 49)
        Me.BtnNuevo.TabIndex = 81
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'LsvEquipo
        '
        Me.LsvEquipo.BackColor = System.Drawing.Color.White
        Me.LsvEquipo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNumMaquina, Me.chSerie, Me.chMarca, Me.chModelo, Me.chMouse, Me.chTeclado, Me.chTipoMonitor, Me.chRam, Me.chDiscoDuro, Me.chDescripcion, Me.chTipoPc, Me.ChRevo, Me.ChEstadoA, Me.ChSerieMo})
        Me.LsvEquipo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvEquipo.GridLines = True
        Me.LsvEquipo.Location = New System.Drawing.Point(0, 475)
        Me.LsvEquipo.Name = "LsvEquipo"
        Me.LsvEquipo.Size = New System.Drawing.Size(887, 222)
        Me.LsvEquipo.TabIndex = 86
        Me.LsvEquipo.UseCompatibleStateImageBehavior = False
        Me.LsvEquipo.View = System.Windows.Forms.View.Details
        '
        'chNumMaquina
        '
        Me.chNumMaquina.Text = "N° Maquina"
        Me.chNumMaquina.Width = 70
        '
        'chSerie
        '
        Me.chSerie.Text = "Serie Computadora"
        Me.chSerie.Width = 110
        '
        'chMarca
        '
        Me.chMarca.Text = "Marca"
        Me.chMarca.Width = 70
        '
        'chModelo
        '
        Me.chModelo.Text = "Modelo"
        Me.chModelo.Width = 70
        '
        'chMouse
        '
        Me.chMouse.Text = "Mouse"
        Me.chMouse.Width = 50
        '
        'chTeclado
        '
        Me.chTeclado.Text = "Teclado"
        Me.chTeclado.Width = 55
        '
        'chTipoMonitor
        '
        Me.chTipoMonitor.Text = "Tipo Monitor"
        Me.chTipoMonitor.Width = 75
        '
        'chRam
        '
        Me.chRam.Text = "Cap. Ram en Gb."
        Me.chRam.Width = 45
        '
        'chDiscoDuro
        '
        Me.chDiscoDuro.Text = "Cap. DiscoDuro en Gb"
        Me.chDiscoDuro.Width = 75
        '
        'chDescripcion
        '
        Me.chDescripcion.Text = "Descripción Procesador"
        Me.chDescripcion.Width = 100
        '
        'chTipoPc
        '
        Me.chTipoPc.Text = "Tipo PC"
        Me.chTipoPc.Width = 80
        '
        'ChRevo
        '
        Me.ChRevo.Text = "Rev. Disco Duro"
        '
        'ChEstadoA
        '
        Me.ChEstadoA.Text = "Estado Asig."
        '
        'ChSerieMo
        '
        Me.ChSerieMo.Text = "Serie Monitor"
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
        Me.PictureBox1.Location = New System.Drawing.Point(12, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(896, 80)
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'FrmEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(886, 458)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LsvEquipo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.ChkVerTodo)
        Me.Controls.Add(Me.PlCom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEquipo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Equipo"
        Me.PlCom.ResumeLayout(False)
        Me.PlCom.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlCom As Panel
    Friend WithEvents CboTeclado As ComboBox
    Friend WithEvents CboMarca As ComboBox
    Friend WithEvents TxtNumMaquina As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnIrMarca As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CboTipoMonitor As ComboBox
    Friend WithEvents CboTipoPC As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CboMouse As ComboBox
    Friend WithEvents CboModelo As ComboBox
    Friend WithEvents TxtDescPro As TextBox
    Friend WithEvents TxtSerieCompu As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnIrModelo As Button
    Friend WithEvents ChkVerTodo As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents LsvEquipo As ListView
    Friend WithEvents chNumMaquina As ColumnHeader
    Friend WithEvents chSerie As ColumnHeader
    Friend WithEvents chMarca As ColumnHeader
    Friend WithEvents chModelo As ColumnHeader
    Friend WithEvents chMouse As ColumnHeader
    Friend WithEvents chTeclado As ColumnHeader
    Friend WithEvents chTipoMonitor As ColumnHeader
    Friend WithEvents chRam As ColumnHeader
    Friend WithEvents chDiscoDuro As ColumnHeader
    Friend WithEvents chDescripcion As ColumnHeader
    Friend WithEvents chTipoPc As ColumnHeader
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtSerieMonitor As TextBox
    Friend WithEvents TxtRevoDisco As TextBox
    Friend WithEvents TxtCapRAM As TextBox
    Friend WithEvents TxtCapDisco As TextBox
    Friend WithEvents CboEstadoA As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChRevo As ColumnHeader
    Friend WithEvents ChEstadoA As ColumnHeader
    Friend WithEvents ChSerieMo As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnActualizarModelo As Button
    Friend WithEvents BtnActualizarMarca As Button
End Class
