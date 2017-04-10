<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarEmpleado
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
        Me.LsvDatosEmpleado = New System.Windows.Forms.ListView()
        Me.ChIdEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCorreo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RdbIdentidad = New System.Windows.Forms.RadioButton()
        Me.RdbNombre = New System.Windows.Forms.RadioButton()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(128, 100)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(297, 20)
        Me.TxtBuscar.TabIndex = 32
        '
        'LsvDatosEmpleado
        '
        Me.LsvDatosEmpleado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdEmpleado, Me.ChNombre, Me.ChApellido, Me.ChDireccion, Me.ChTelefono, Me.ChCorreo, Me.ChSexo})
        Me.LsvDatosEmpleado.FullRowSelect = True
        Me.LsvDatosEmpleado.GridLines = True
        Me.LsvDatosEmpleado.Location = New System.Drawing.Point(-3, 146)
        Me.LsvDatosEmpleado.Name = "LsvDatosEmpleado"
        Me.LsvDatosEmpleado.Size = New System.Drawing.Size(642, 308)
        Me.LsvDatosEmpleado.TabIndex = 29
        Me.LsvDatosEmpleado.UseCompatibleStateImageBehavior = False
        Me.LsvDatosEmpleado.View = System.Windows.Forms.View.Details
        '
        'ChIdEmpleado
        '
        Me.ChIdEmpleado.Text = "Id Empleado"
        Me.ChIdEmpleado.Width = 127
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre "
        Me.ChNombre.Width = 104
        '
        'ChApellido
        '
        Me.ChApellido.Text = "Apellido"
        Me.ChApellido.Width = 69
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        Me.ChDireccion.Width = 98
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Telefono"
        Me.ChTelefono.Width = 76
        '
        'ChCorreo
        '
        Me.ChCorreo.Text = "Correo"
        Me.ChCorreo.Width = 105
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        '
        'RdbIdentidad
        '
        Me.RdbIdentidad.AutoSize = True
        Me.RdbIdentidad.Location = New System.Drawing.Point(171, 19)
        Me.RdbIdentidad.Name = "RdbIdentidad"
        Me.RdbIdentidad.Size = New System.Drawing.Size(69, 17)
        Me.RdbIdentidad.TabIndex = 1
        Me.RdbIdentidad.TabStop = True
        Me.RdbIdentidad.Text = "Identidad"
        Me.RdbIdentidad.UseVisualStyleBackColor = True
        '
        'RdbNombre
        '
        Me.RdbNombre.AutoSize = True
        Me.RdbNombre.Location = New System.Drawing.Point(41, 19)
        Me.RdbNombre.Name = "RdbNombre"
        Me.RdbNombre.Size = New System.Drawing.Size(62, 17)
        Me.RdbNombre.TabIndex = 0
        Me.RdbNombre.TabStop = True
        Me.RdbNombre.Text = "Nombre"
        Me.RdbNombre.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(431, 98)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 33
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbIdentidad)
        Me.GroupBox1.Controls.Add(Me.RdbNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 44)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'FrmBuscarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 453)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvDatosEmpleado)
        Me.Name = "FrmBuscarEmpleado"
        Me.Text = "FrmBuscarEmpleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LsvDatosEmpleado As ListView
    Friend WithEvents ChIdEmpleado As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellido As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChCorreo As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents RdbIdentidad As RadioButton
    Friend WithEvents RdbNombre As RadioButton
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
