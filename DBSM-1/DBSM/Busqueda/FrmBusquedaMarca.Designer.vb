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
        Me.RdoNombreMarca = New System.Windows.Forms.RadioButton()
        Me.RdoCodMarca = New System.Windows.Forms.RadioButton()
        Me.LsvMarca = New System.Windows.Forms.ListView()
        Me.chIdMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombreMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RdoNombreMarca
        '
        Me.RdoNombreMarca.AutoSize = True
        Me.RdoNombreMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoNombreMarca.Location = New System.Drawing.Point(173, 22)
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
        Me.RdoCodMarca.Location = New System.Drawing.Point(20, 22)
        Me.RdoCodMarca.Name = "RdoCodMarca"
        Me.RdoCodMarca.Size = New System.Drawing.Size(105, 17)
        Me.RdoCodMarca.TabIndex = 2
        Me.RdoCodMarca.TabStop = True
        Me.RdoCodMarca.Text = "Código de marca"
        Me.RdoCodMarca.UseVisualStyleBackColor = True
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
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(73, 161)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(323, 20)
        Me.TxtBuscar.TabIndex = 108
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RdoNombreMarca)
        Me.GroupBox2.Controls.Add(Me.RdoCodMarca)
        Me.GroupBox2.Location = New System.Drawing.Point(73, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 57)
        Me.GroupBox2.TabIndex = 110
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de busqueda"
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
        Me.BtnBuscar.Location = New System.Drawing.Point(402, 152)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 36)
        Me.BtnBuscar.TabIndex = 124
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmBusquedaMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(575, 379)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvMarca)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Marca"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LsvMarca As ListView
    Friend WithEvents chIdMarca As ColumnHeader
    Friend WithEvents chNombreMarca As ColumnHeader
    Friend WithEvents RdoNombreMarca As RadioButton
    Friend WithEvents RdoCodMarca As RadioButton
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnBuscar As Button
End Class
