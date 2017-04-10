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
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RdoNumMaquina = New System.Windows.Forms.RadioButton()
        Me.RdoSerieCom = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtBuscar.Location = New System.Drawing.Point(143, 142)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(314, 27)
        Me.TxtBuscar.TabIndex = 78
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(504, 130)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(48, 39)
        Me.BtnBuscar.TabIndex = 79
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(140, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Opciones de búsqueda:"
        '
        'RdoNumMaquina
        '
        Me.RdoNumMaquina.AutoSize = True
        Me.RdoNumMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoNumMaquina.Location = New System.Drawing.Point(16, 11)
        Me.RdoNumMaquina.Name = "RdoNumMaquina"
        Me.RdoNumMaquina.Size = New System.Drawing.Size(165, 20)
        Me.RdoNumMaquina.TabIndex = 0
        Me.RdoNumMaquina.TabStop = True
        Me.RdoNumMaquina.Text = "Número de máquina"
        Me.RdoNumMaquina.UseVisualStyleBackColor = True
        '
        'RdoSerieCom
        '
        Me.RdoSerieCom.AutoSize = True
        Me.RdoSerieCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoSerieCom.Location = New System.Drawing.Point(274, 11)
        Me.RdoSerieCom.Name = "RdoSerieCom"
        Me.RdoSerieCom.Size = New System.Drawing.Size(160, 20)
        Me.RdoSerieCom.TabIndex = 1
        Me.RdoSerieCom.TabStop = True
        Me.RdoSerieCom.Text = "Serie Computadora"
        Me.RdoSerieCom.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RdoSerieCom)
        Me.Panel1.Controls.Add(Me.RdoNumMaquina)
        Me.Panel1.Location = New System.Drawing.Point(143, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 41)
        Me.Panel1.TabIndex = 82
        '
        'LsvEquipo
        '
        Me.LsvEquipo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvEquipo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNumMaquina, Me.chSerie, Me.chMarca, Me.chModelo, Me.chMouse, Me.chTeclado, Me.chTipoMonitor, Me.chRam, Me.chDiscoDuro, Me.chDescripcion, Me.chTipoPc, Me.ChRevo, Me.ChEstadoA, Me.ChSerieMo})
        Me.LsvEquipo.GridLines = True
        Me.LsvEquipo.Location = New System.Drawing.Point(3, 224)
        Me.LsvEquipo.Name = "LsvEquipo"
        Me.LsvEquipo.Size = New System.Drawing.Size(873, 201)
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
        '
        'FrmBusquedaComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 449)
        Me.Controls.Add(Me.LsvEquipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Name = "FrmBusquedaComputadora"
        Me.Text = "FrmBusquedaComputadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RdoNumMaquina As RadioButton
    Friend WithEvents RdoSerieCom As RadioButton
    Friend WithEvents Panel1 As Panel
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
End Class
