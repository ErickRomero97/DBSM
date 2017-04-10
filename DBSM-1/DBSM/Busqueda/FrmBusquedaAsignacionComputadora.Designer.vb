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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdoCodAlumnoA = New System.Windows.Forms.RadioButton()
        Me.RdoCodCompuA = New System.Windows.Forms.RadioButton()
        Me.LsvBusquedaCompuA = New System.Windows.Forms.ListView()
        Me.ChCodCompuA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodAlumnoA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RdoCodAlumnoA)
        Me.Panel1.Controls.Add(Me.RdoCodCompuA)
        Me.Panel1.Location = New System.Drawing.Point(111, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(437, 41)
        Me.Panel1.TabIndex = 96
        '
        'RdoCodAlumnoA
        '
        Me.RdoCodAlumnoA.AutoSize = True
        Me.RdoCodAlumnoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodAlumnoA.Location = New System.Drawing.Point(264, 11)
        Me.RdoCodAlumnoA.Name = "RdoCodAlumnoA"
        Me.RdoCodAlumnoA.Size = New System.Drawing.Size(161, 20)
        Me.RdoCodAlumnoA.TabIndex = 1
        Me.RdoCodAlumnoA.TabStop = True
        Me.RdoCodAlumnoA.Text = "Codigo del  Alumno"
        Me.RdoCodAlumnoA.UseVisualStyleBackColor = True
        '
        'RdoCodCompuA
        '
        Me.RdoCodCompuA.AutoSize = True
        Me.RdoCodCompuA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RdoCodCompuA.Location = New System.Drawing.Point(16, 11)
        Me.RdoCodCompuA.Name = "RdoCodCompuA"
        Me.RdoCodCompuA.Size = New System.Drawing.Size(195, 20)
        Me.RdoCodCompuA.TabIndex = 0
        Me.RdoCodCompuA.TabStop = True
        Me.RdoCodCompuA.Text = "Código de Computadora"
        Me.RdoCodCompuA.UseVisualStyleBackColor = True
        '
        'LsvBusquedaCompuA
        '
        Me.LsvBusquedaCompuA.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LsvBusquedaCompuA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodCompuA, Me.ChCodAlumnoA, Me.ChFechaA, Me.ChFechaE, Me.ChEstadoA})
        Me.LsvBusquedaCompuA.GridLines = True
        Me.LsvBusquedaCompuA.Location = New System.Drawing.Point(1, 216)
        Me.LsvBusquedaCompuA.Name = "LsvBusquedaCompuA"
        Me.LsvBusquedaCompuA.Size = New System.Drawing.Size(674, 146)
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
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(456, 142)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(92, 39)
        Me.BtnBuscar.TabIndex = 99
        Me.BtnBuscar.Text = "Busqueda"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtBuscar.Location = New System.Drawing.Point(111, 152)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(314, 27)
        Me.TxtBuscar.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(108, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 16)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Opciones de búsqueda:"
        '
        'FrmBusquedaAsignacionComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 442)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LsvBusquedaCompuA)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmBusquedaAsignacionComputadora"
        Me.Text = "FrmBusquedaAsignacionComputadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RdoCodAlumnoA As RadioButton
    Friend WithEvents RdoCodCompuA As RadioButton
    Friend WithEvents LsvBusquedaCompuA As ListView
    Friend WithEvents ChCodCompuA As ColumnHeader
    Friend WithEvents ChCodAlumnoA As ColumnHeader
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ChFechaA As ColumnHeader
    Friend WithEvents ChFechaE As ColumnHeader
    Friend WithEvents ChEstadoA As ColumnHeader
End Class
