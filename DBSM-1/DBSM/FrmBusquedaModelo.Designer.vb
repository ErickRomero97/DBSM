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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdoNombreMo = New System.Windows.Forms.RadioButton()
        Me.RdoCodigoMo = New System.Windows.Forms.RadioButton()
        Me.TxtBuscarMo = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvModeloBu
        '
        Me.LsvModeloBu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvModeloBu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdModelo, Me.chNombreModelo, Me.chMarca})
        Me.LsvModeloBu.GridLines = True
        Me.LsvModeloBu.Location = New System.Drawing.Point(19, 199)
        Me.LsvModeloBu.Name = "LsvModeloBu"
        Me.LsvModeloBu.Size = New System.Drawing.Size(557, 164)
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
        Me.chNombreModelo.Width = 145
        '
        'chMarca
        '
        Me.chMarca.Text = "Marca"
        Me.chMarca.Width = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(71, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 16)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Opciones de búsqueda:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RdoNombreMo)
        Me.Panel1.Controls.Add(Me.RdoCodigoMo)
        Me.Panel1.Location = New System.Drawing.Point(74, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 41)
        Me.Panel1.TabIndex = 91
        '
        'RdoNombreMo
        '
        Me.RdoNombreMo.AutoSize = True
        Me.RdoNombreMo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoNombreMo.Location = New System.Drawing.Point(272, 11)
        Me.RdoNombreMo.Name = "RdoNombreMo"
        Me.RdoNombreMo.Size = New System.Drawing.Size(159, 20)
        Me.RdoNombreMo.TabIndex = 1
        Me.RdoNombreMo.TabStop = True
        Me.RdoNombreMo.Text = "Nombre de modelo"
        Me.RdoNombreMo.UseVisualStyleBackColor = True
        '
        'RdoCodigoMo
        '
        Me.RdoCodigoMo.AutoSize = True
        Me.RdoCodigoMo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodigoMo.Location = New System.Drawing.Point(16, 11)
        Me.RdoCodigoMo.Name = "RdoCodigoMo"
        Me.RdoCodigoMo.Size = New System.Drawing.Size(154, 20)
        Me.RdoCodigoMo.TabIndex = 0
        Me.RdoCodigoMo.TabStop = True
        Me.RdoCodigoMo.Text = "Código de modelo"
        Me.RdoCodigoMo.UseVisualStyleBackColor = True
        '
        'TxtBuscarMo
        '
        Me.TxtBuscarMo.Location = New System.Drawing.Point(97, 156)
        Me.TxtBuscarMo.Multiline = True
        Me.TxtBuscarMo.Name = "TxtBuscarMo"
        Me.TxtBuscarMo.Size = New System.Drawing.Size(314, 24)
        Me.TxtBuscarMo.TabIndex = 96
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Location = New System.Drawing.Point(417, 156)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 97
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmBusquedaModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(592, 378)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscarMo)
        Me.Controls.Add(Me.LsvModeloBu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "FrmBusquedaModelo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBusquedaModelo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LsvModeloBu As ListView
    Friend WithEvents chIdModelo As ColumnHeader
    Friend WithEvents chNombreModelo As ColumnHeader
    Friend WithEvents chMarca As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RdoNombreMo As RadioButton
    Friend WithEvents RdoCodigoMo As RadioButton
    Friend WithEvents TxtBuscarMo As TextBox
    Friend WithEvents BtnBuscar As Button
End Class
