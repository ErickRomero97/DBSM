<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaModelo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaModelo))
        Me.LsvModeloBu = New System.Windows.Forms.ListView()
        Me.chIdModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombreModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RdoNombreMo = New System.Windows.Forms.RadioButton()
        Me.RdoCodigoMo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarMo = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvModeloBu
        '
        Me.LsvModeloBu.BackColor = System.Drawing.Color.White
        Me.LsvModeloBu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdModelo, Me.chNombreModelo, Me.chMarca})
        Me.LsvModeloBu.GridLines = True
        Me.LsvModeloBu.Location = New System.Drawing.Point(-1, 222)
        Me.LsvModeloBu.Name = "LsvModeloBu"
        Me.LsvModeloBu.Size = New System.Drawing.Size(581, 194)
        Me.LsvModeloBu.TabIndex = 95
        Me.LsvModeloBu.UseCompatibleStateImageBehavior = False
        Me.LsvModeloBu.View = System.Windows.Forms.View.Details
        '
        'chIdModelo
        '
        Me.chIdModelo.Text = "Codigo Modelo"
        Me.chIdModelo.Width = 153
        '
        'chNombreModelo
        '
        Me.chNombreModelo.Text = "Nombre Modelo"
        Me.chNombreModelo.Width = 197
        '
        'chMarca
        '
        Me.chMarca.Text = "Marca"
        Me.chMarca.Width = 226
        '
        'RdoNombreMo
        '
        Me.RdoNombreMo.AutoSize = True
        Me.RdoNombreMo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoNombreMo.Location = New System.Drawing.Point(164, 22)
        Me.RdoNombreMo.Name = "RdoNombreMo"
        Me.RdoNombreMo.Size = New System.Drawing.Size(114, 17)
        Me.RdoNombreMo.TabIndex = 1
        Me.RdoNombreMo.TabStop = True
        Me.RdoNombreMo.Text = "Nombre de modelo"
        Me.RdoNombreMo.UseVisualStyleBackColor = True
        '
        'RdoCodigoMo
        '
        Me.RdoCodigoMo.AutoSize = True
        Me.RdoCodigoMo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCodigoMo.Location = New System.Drawing.Point(20, 22)
        Me.RdoCodigoMo.Name = "RdoCodigoMo"
        Me.RdoCodigoMo.Size = New System.Drawing.Size(110, 17)
        Me.RdoCodigoMo.TabIndex = 0
        Me.RdoCodigoMo.TabStop = True
        Me.RdoCodigoMo.Text = "Código de modelo"
        Me.RdoCodigoMo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdoNombreMo)
        Me.GroupBox1.Controls.Add(Me.RdoCodigoMo)
        Me.GroupBox1.Location = New System.Drawing.Point(100, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 56)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda:"
        '
        'TxtBuscarMo
        '
        Me.TxtBuscarMo.Location = New System.Drawing.Point(100, 171)
        Me.TxtBuscarMo.Name = "TxtBuscarMo"
        Me.TxtBuscarMo.Size = New System.Drawing.Size(323, 20)
        Me.TxtBuscarMo.TabIndex = 108
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
        Me.BtnBuscar.Location = New System.Drawing.Point(429, 162)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 36)
        Me.BtnBuscar.TabIndex = 124
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmBusquedaModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(578, 414)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtBuscarMo)
        Me.Controls.Add(Me.LsvModeloBu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaModelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Modelo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LsvModeloBu As ListView
    Friend WithEvents chIdModelo As ColumnHeader
    Friend WithEvents chNombreModelo As ColumnHeader
    Friend WithEvents chMarca As ColumnHeader
    Friend WithEvents RdoNombreMo As RadioButton
    Friend WithEvents RdoCodigoMo As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBuscarMo As TextBox
    Friend WithEvents BtnBuscar As Button
End Class
