<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaComputadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaComputadora))
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
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoSerieCom = New System.Windows.Forms.RadioButton()
        Me.RdoNumMaquina = New System.Windows.Forms.RadioButton()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvEquipo
        '
        Me.LsvEquipo.BackColor = System.Drawing.Color.White
        Me.LsvEquipo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNumMaquina, Me.chSerie, Me.chMarca, Me.chModelo, Me.chMouse, Me.chTeclado, Me.chTipoMonitor, Me.chRam, Me.chDiscoDuro, Me.chDescripcion, Me.chTipoPc, Me.ChRevo, Me.ChEstadoA, Me.ChSerieMo})
        Me.LsvEquipo.GridLines = True
        Me.LsvEquipo.Location = New System.Drawing.Point(1, 224)
        Me.LsvEquipo.Name = "LsvEquipo"
        Me.LsvEquipo.Size = New System.Drawing.Size(989, 201)
        Me.LsvEquipo.TabIndex = 87
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
        Me.chRam.Text = "Cap. Ram"
        Me.chRam.Width = 45
        '
        'chDiscoDuro
        '
        Me.chDiscoDuro.Text = "Cap. DiscoDuro"
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
        Me.ChSerieMo.Width = 66
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(295, 177)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(323, 20)
        Me.TxtBuscar.TabIndex = 102
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdoSerieCom)
        Me.GroupBox1.Controls.Add(Me.RdoNumMaquina)
        Me.GroupBox1.Location = New System.Drawing.Point(295, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 66)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda:"
        '
        'RdoSerieCom
        '
        Me.RdoSerieCom.AutoSize = True
        Me.RdoSerieCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSerieCom.Location = New System.Drawing.Point(175, 25)
        Me.RdoSerieCom.Name = "RdoSerieCom"
        Me.RdoSerieCom.Size = New System.Drawing.Size(115, 17)
        Me.RdoSerieCom.TabIndex = 2
        Me.RdoSerieCom.TabStop = True
        Me.RdoSerieCom.Text = "Serie Computadora"
        Me.RdoSerieCom.UseVisualStyleBackColor = True
        '
        'RdoNumMaquina
        '
        Me.RdoNumMaquina.AutoSize = True
        Me.RdoNumMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoNumMaquina.Location = New System.Drawing.Point(9, 24)
        Me.RdoNumMaquina.Name = "RdoNumMaquina"
        Me.RdoNumMaquina.Size = New System.Drawing.Size(120, 17)
        Me.RdoNumMaquina.TabIndex = 1
        Me.RdoNumMaquina.TabStop = True
        Me.RdoNumMaquina.Text = "Número de máquina"
        Me.RdoNumMaquina.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(624, 168)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 36)
        Me.BtnBuscar.TabIndex = 124
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmBusquedaComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 449)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvEquipo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaComputadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Computadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents ChRevo As ColumnHeader
    Friend WithEvents ChEstadoA As ColumnHeader
    Friend WithEvents ChSerieMo As ColumnHeader
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdoSerieCom As RadioButton
    Friend WithEvents RdoNumMaquina As RadioButton
    Friend WithEvents BtnBuscar As Button
End Class
