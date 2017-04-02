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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdoNombreMarca = New System.Windows.Forms.RadioButton()
        Me.RdoCodMarca = New System.Windows.Forms.RadioButton()
        Me.LsvMarca = New System.Windows.Forms.ListView()
        Me.chIdMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombreMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RdoNombreMarca)
        Me.Panel1.Controls.Add(Me.RdoCodMarca)
        Me.Panel1.Location = New System.Drawing.Point(69, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 41)
        Me.Panel1.TabIndex = 91
        '
        'RdoNombreMarca
        '
        Me.RdoNombreMarca.AutoSize = True
        Me.RdoNombreMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoNombreMarca.Location = New System.Drawing.Point(264, 11)
        Me.RdoNombreMarca.Name = "RdoNombreMarca"
        Me.RdoNombreMarca.Size = New System.Drawing.Size(150, 20)
        Me.RdoNombreMarca.TabIndex = 1
        Me.RdoNombreMarca.TabStop = True
        Me.RdoNombreMarca.Text = "Nombre de marca"
        Me.RdoNombreMarca.UseVisualStyleBackColor = True
        '
        'RdoCodMarca
        '
        Me.RdoCodMarca.AutoSize = True
        Me.RdoCodMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodMarca.Location = New System.Drawing.Point(16, 11)
        Me.RdoCodMarca.Name = "RdoCodMarca"
        Me.RdoCodMarca.Size = New System.Drawing.Size(145, 20)
        Me.RdoCodMarca.TabIndex = 0
        Me.RdoCodMarca.TabStop = True
        Me.RdoCodMarca.Text = "Código de marca"
        Me.RdoCodMarca.UseVisualStyleBackColor = True
        '
        'LsvMarca
        '
        Me.LsvMarca.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvMarca.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdMarca, Me.chNombreMarca})
        Me.LsvMarca.GridLines = True
        Me.LsvMarca.Location = New System.Drawing.Point(12, 199)
        Me.LsvMarca.Name = "LsvMarca"
        Me.LsvMarca.Size = New System.Drawing.Size(578, 146)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(66, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 16)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Opciones de búsqueda:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Location = New System.Drawing.Point(405, 154)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 99
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(85, 154)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(314, 24)
        Me.TxtBuscar.TabIndex = 98
        '
        'FrmBusquedaMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(603, 356)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LsvMarca)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Name = "FrmBusquedaMarca"
        Me.Text = "FrmBusquedaMarca"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RdoNombreMarca As RadioButton
    Friend WithEvents RdoCodMarca As RadioButton
    Friend WithEvents LsvMarca As ListView
    Friend WithEvents chIdMarca As ColumnHeader
    Friend WithEvents chNombreMarca As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
End Class
