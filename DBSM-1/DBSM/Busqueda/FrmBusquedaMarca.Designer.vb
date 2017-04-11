<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaMarca))
        Me.LsvMarca = New System.Windows.Forms.ListView()
        Me.chIdMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombreMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdoNombreMarca = New System.Windows.Forms.RadioButton()
        Me.RdoCodMarca = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvMarca
        '
        Me.LsvMarca.BackColor = System.Drawing.Color.White
        Me.LsvMarca.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdMarca, Me.chNombreMarca})
        Me.LsvMarca.GridLines = True
        Me.LsvMarca.Location = New System.Drawing.Point(-1, 205)
        Me.LsvMarca.Name = "LsvMarca"
        Me.LsvMarca.Size = New System.Drawing.Size(576, 176)
        Me.LsvMarca.TabIndex = 95
        Me.LsvMarca.UseCompatibleStateImageBehavior = False
        Me.LsvMarca.View = System.Windows.Forms.View.Details
        '
        'chIdMarca
        '
        Me.chIdMarca.Text = "Código Marca"
        Me.chIdMarca.Width = 200
        '
        'chNombreMarca
        '
        Me.chNombreMarca.Text = "Nombre Marca"
        Me.chNombreMarca.Width = 372
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(411, 158)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 106
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(73, 159)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(323, 20)
        Me.TxtBuscar.TabIndex = 105
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdoNombreMarca)
        Me.GroupBox1.Controls.Add(Me.RdoCodMarca)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 56)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda:"
        '
        'RdoNombreMarca
        '
        Me.RdoNombreMarca.AutoSize = True
        Me.RdoNombreMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoNombreMarca.Location = New System.Drawing.Point(170, 23)
        Me.RdoNombreMarca.Name = "RdoNombreMarca"
        Me.RdoNombreMarca.Size = New System.Drawing.Size(109, 17)
        Me.RdoNombreMarca.TabIndex = 3
        Me.RdoNombreMarca.TabStop = True
        Me.RdoNombreMarca.Text = "Nombre de marca"
        Me.RdoNombreMarca.UseVisualStyleBackColor = True
        '
        'RdoCodMarca
        '
        Me.RdoCodMarca.AutoSize = True
        Me.RdoCodMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCodMarca.Location = New System.Drawing.Point(16, 23)
        Me.RdoCodMarca.Name = "RdoCodMarca"
        Me.RdoCodMarca.Size = New System.Drawing.Size(105, 17)
        Me.RdoCodMarca.TabIndex = 2
        Me.RdoCodMarca.TabStop = True
        Me.RdoCodMarca.Text = "Código de marca"
        Me.RdoCodMarca.UseVisualStyleBackColor = True
        '
        'FrmBusquedaMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(575, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvMarca)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBusquedaMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Marca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LsvMarca As ListView
    Friend WithEvents chIdMarca As ColumnHeader
    Friend WithEvents chNombreMarca As ColumnHeader
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdoNombreMarca As RadioButton
    Friend WithEvents RdoCodMarca As RadioButton
End Class
