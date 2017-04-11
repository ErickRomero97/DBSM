<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarAsignacionPrograma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarAsignacionPrograma))
        Me.LsvAsignacion = New System.Windows.Forms.ListView()
        Me.ChCodigoSoftware = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumLicencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNumComputadora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFecha3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbNumComputadora = New System.Windows.Forms.RadioButton()
        Me.RdbPrograma = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LsvAsignacion
        '
        Me.LsvAsignacion.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoSoftware, Me.ChEstado, Me.ChNumLicencia, Me.ChFecha1, Me.ChFecha2, Me.ChNumComputadora, Me.ChPrograma, Me.ChFecha3})
        Me.LsvAsignacion.FullRowSelect = True
        Me.LsvAsignacion.GridLines = True
        Me.LsvAsignacion.Location = New System.Drawing.Point(1, 192)
        Me.LsvAsignacion.Name = "LsvAsignacion"
        Me.LsvAsignacion.Size = New System.Drawing.Size(851, 158)
        Me.LsvAsignacion.TabIndex = 106
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
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(546, 149)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 109
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(243, 150)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(297, 20)
        Me.TxtBuscar.TabIndex = 108
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdbNumComputadora)
        Me.GroupBox1.Controls.Add(Me.RdbPrograma)
        Me.GroupBox1.Location = New System.Drawing.Point(243, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 61)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'RdbNumComputadora
        '
        Me.RdbNumComputadora.AutoSize = True
        Me.RdbNumComputadora.Location = New System.Drawing.Point(153, 26)
        Me.RdbNumComputadora.Name = "RdbNumComputadora"
        Me.RdbNumComputadora.Size = New System.Drawing.Size(113, 17)
        Me.RdbNumComputadora.TabIndex = 1
        Me.RdbNumComputadora.TabStop = True
        Me.RdbNumComputadora.Text = "Num Computadora"
        Me.RdbNumComputadora.UseVisualStyleBackColor = True
        '
        'RdbPrograma
        '
        Me.RdbPrograma.AutoSize = True
        Me.RdbPrograma.Location = New System.Drawing.Point(27, 26)
        Me.RdbPrograma.Name = "RdbPrograma"
        Me.RdbPrograma.Size = New System.Drawing.Size(70, 17)
        Me.RdbPrograma.TabIndex = 0
        Me.RdbPrograma.TabStop = True
        Me.RdbPrograma.Text = "Programa"
        Me.RdbPrograma.UseVisualStyleBackColor = True
        '
        'FrmBuscarAsignacionPrograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(847, 347)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LsvAsignacion)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBuscarAsignacionPrograma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Asignacion Programa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LsvAsignacion As ListView
    Friend WithEvents ChCodigoSoftware As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents ChNumLicencia As ColumnHeader
    Friend WithEvents ChFecha1 As ColumnHeader
    Friend WithEvents ChFecha2 As ColumnHeader
    Friend WithEvents ChNumComputadora As ColumnHeader
    Friend WithEvents ChPrograma As ColumnHeader
    Friend WithEvents ChFecha3 As ColumnHeader
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbNumComputadora As RadioButton
    Friend WithEvents RdbPrograma As RadioButton
End Class
