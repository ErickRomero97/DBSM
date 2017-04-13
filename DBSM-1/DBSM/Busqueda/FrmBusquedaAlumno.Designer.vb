<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaAlumno
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lsbAlumno = New System.Windows.Forms.ListView()
        Me.ChIdAlumno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCorreo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(170, 121)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(314, 24)
        Me.TxtBuscar.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(202, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 31)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Busqueda Alumno"
        '
        'lsbAlumno
        '
        Me.lsbAlumno.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lsbAlumno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdAlumno, Me.chNombre, Me.ChApellido0, Me.chDireccion, Me.chTelefono, Me.chCorreo, Me.chSexo})
        Me.lsbAlumno.FullRowSelect = True
        Me.lsbAlumno.GridLines = True
        Me.lsbAlumno.Location = New System.Drawing.Point(-5, 169)
        Me.lsbAlumno.Name = "lsbAlumno"
        Me.lsbAlumno.Size = New System.Drawing.Size(746, 286)
        Me.lsbAlumno.TabIndex = 103
        Me.lsbAlumno.UseCompatibleStateImageBehavior = False
        Me.lsbAlumno.View = System.Windows.Forms.View.Details
        '
        'ChIdAlumno
        '
        Me.ChIdAlumno.Text = "IdAlumno"
        Me.ChIdAlumno.Width = 87
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre"
        Me.chNombre.Width = 103
        '
        'ChApellido0
        '
        Me.ChApellido0.Text = "Apellido"
        Me.ChApellido0.Width = 90
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Direccion"
        Me.chDireccion.Width = 161
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Telefono"
        Me.chTelefono.Width = 96
        '
        'chCorreo
        '
        Me.chCorreo.Text = "Correo"
        Me.chCorreo.Width = 125
        '
        'chSexo
        '
        Me.chSexo.Text = "Sexo"
        Me.chSexo.Width = 128
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(526, 122)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 107
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmBusquedaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 496)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lsbAlumno)
        Me.Name = "FrmBusquedaAlumno"
        Me.Text = "BusquedaAlumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lsbAlumno As ListView
    Friend WithEvents ChIdAlumno As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents ChApellido0 As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chCorreo As ColumnHeader
    Friend WithEvents chSexo As ColumnHeader
    Friend WithEvents BtnBuscar As Button
End Class
