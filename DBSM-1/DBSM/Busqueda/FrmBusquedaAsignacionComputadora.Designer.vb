<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaAsignacionComputadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaAsignacionComputadora))
        Me.RdoCodAlumnoA = New System.Windows.Forms.RadioButton()
        Me.RdoCodCompuA = New System.Windows.Forms.RadioButton()
        Me.LsvBusquedaCompuA = New System.Windows.Forms.ListView()
        Me.ChCodCompuA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodAlumnoA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RdoCodAlumnoA
        '
        Me.RdoCodAlumnoA.AutoSize = True
        Me.RdoCodAlumnoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCodAlumnoA.Location = New System.Drawing.Point(171, 28)
        Me.RdoCodAlumnoA.Name = "RdoCodAlumnoA"
        Me.RdoCodAlumnoA.Size = New System.Drawing.Size(116, 17)
        Me.RdoCodAlumnoA.TabIndex = 1
        Me.RdoCodAlumnoA.TabStop = True
        Me.RdoCodAlumnoA.Text = "Codigo del  Alumno"
        Me.RdoCodAlumnoA.UseVisualStyleBackColor = True
        '
        'RdoCodCompuA
        '
        Me.RdoCodCompuA.AutoSize = True
        Me.RdoCodCompuA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoCodCompuA.Location = New System.Drawing.Point(5, 27)
        Me.RdoCodCompuA.Name = "RdoCodCompuA"
        Me.RdoCodCompuA.Size = New System.Drawing.Size(139, 17)
        Me.RdoCodCompuA.TabIndex = 0
        Me.RdoCodCompuA.TabStop = True
        Me.RdoCodCompuA.Text = "Código de Computadora"
        Me.RdoCodCompuA.UseVisualStyleBackColor = True
        '
        'LsvBusquedaCompuA
        '
        Me.LsvBusquedaCompuA.BackColor = System.Drawing.Color.White
        Me.LsvBusquedaCompuA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodCompuA, Me.ChCodAlumnoA, Me.ChFechaA, Me.ChFechaE, Me.ChEstadoA})
        Me.LsvBusquedaCompuA.GridLines = True
        Me.LsvBusquedaCompuA.Location = New System.Drawing.Point(-1, 216)
        Me.LsvBusquedaCompuA.Name = "LsvBusquedaCompuA"
        Me.LsvBusquedaCompuA.Size = New System.Drawing.Size(680, 187)
        Me.LsvBusquedaCompuA.TabIndex = 100
        Me.LsvBusquedaCompuA.UseCompatibleStateImageBehavior = False
        Me.LsvBusquedaCompuA.View = System.Windows.Forms.View.Details
        '
        'ChCodCompuA
        '
        Me.ChCodCompuA.Text = "Código de la Computadora"
        Me.ChCodCompuA.Width = 137
        '
        'ChCodAlumnoA
        '
        Me.ChCodAlumnoA.Text = "Codigo Alumno"
        Me.ChCodAlumnoA.Width = 91
        '
        'ChFechaA
        '
        Me.ChFechaA.Text = "Fecha Asignacion"
        Me.ChFechaA.Width = 108
        '
        'ChFechaE
        '
        Me.ChFechaE.Text = "Fecha de Entrega"
        Me.ChFechaE.Width = 124
        '
        'ChEstadoA
        '
        Me.ChEstadoA.Text = "Estado de Asignacion de Computadora"
        Me.ChEstadoA.Width = 321
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(127, 180)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(323, 20)
        Me.TxtBuscar.TabIndex = 101
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdoCodAlumnoA)
        Me.GroupBox1.Controls.Add(Me.RdoCodCompuA)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 66)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(456, 180)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 103
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmBusquedaAsignacionComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(678, 402)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvBusquedaCompuA)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmBusquedaAsignacionComputadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Asignacion Computadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RdoCodAlumnoA As RadioButton
    Friend WithEvents RdoCodCompuA As RadioButton
    Friend WithEvents LsvBusquedaCompuA As ListView
    Friend WithEvents ChCodCompuA As ColumnHeader
    Friend WithEvents ChCodAlumnoA As ColumnHeader
    Friend WithEvents ChFechaA As ColumnHeader
    Friend WithEvents ChFechaE As ColumnHeader
    Friend WithEvents ChEstadoA As ColumnHeader
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBuscar As Button
End Class
