<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarPrograma
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
        Me.LsvPrograma = New System.Windows.Forms.ListView()
        Me.ChCodPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbCodPrograma = New System.Windows.Forms.RadioButton()
        Me.RdbPrograma = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvPrograma
        '
        Me.LsvPrograma.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodPrograma, Me.ChNombre, Me.ChDescripcion, Me.ChTipo})
        Me.LsvPrograma.FullRowSelect = True
        Me.LsvPrograma.Location = New System.Drawing.Point(2, 142)
        Me.LsvPrograma.Name = "LsvPrograma"
        Me.LsvPrograma.Size = New System.Drawing.Size(463, 140)
        Me.LsvPrograma.TabIndex = 119
        Me.LsvPrograma.UseCompatibleStateImageBehavior = False
        Me.LsvPrograma.View = System.Windows.Forms.View.Details
        '
        'ChCodPrograma
        '
        Me.ChCodPrograma.Text = "Cod Programa"
        Me.ChCodPrograma.Width = 93
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre Programa"
        Me.ChNombre.Width = 110
        '
        'ChDescripcion
        '
        Me.ChDescripcion.Text = "Descripcion"
        Me.ChDescripcion.Width = 122
        '
        'ChTipo
        '
        Me.ChTipo.Text = "Tipo Programa"
        Me.ChTipo.Width = 132
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(352, 99)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 122
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(49, 100)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(297, 20)
        Me.TxtBuscar.TabIndex = 121
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbCodPrograma)
        Me.GroupBox1.Controls.Add(Me.RdbPrograma)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 64)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'RdbCodPrograma
        '
        Me.RdbCodPrograma.AutoSize = True
        Me.RdbCodPrograma.Location = New System.Drawing.Point(178, 31)
        Me.RdbCodPrograma.Name = "RdbCodPrograma"
        Me.RdbCodPrograma.Size = New System.Drawing.Size(92, 17)
        Me.RdbCodPrograma.TabIndex = 1
        Me.RdbCodPrograma.TabStop = True
        Me.RdbCodPrograma.Text = "Cod Programa"
        Me.RdbCodPrograma.UseVisualStyleBackColor = True
        '
        'RdbPrograma
        '
        Me.RdbPrograma.AutoSize = True
        Me.RdbPrograma.Location = New System.Drawing.Point(52, 31)
        Me.RdbPrograma.Name = "RdbPrograma"
        Me.RdbPrograma.Size = New System.Drawing.Size(70, 17)
        Me.RdbPrograma.TabIndex = 0
        Me.RdbPrograma.TabStop = True
        Me.RdbPrograma.Text = "Programa"
        Me.RdbPrograma.UseVisualStyleBackColor = True
        '
        'FrmBuscarPrograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 283)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LsvPrograma)
        Me.Name = "FrmBuscarPrograma"
        Me.Text = "FrmBuscarPrograma"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvPrograma As ListView
    Friend WithEvents ChCodPrograma As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChDescripcion As ColumnHeader
    Friend WithEvents ChTipo As ColumnHeader
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbCodPrograma As RadioButton
    Friend WithEvents RdbPrograma As RadioButton
End Class
