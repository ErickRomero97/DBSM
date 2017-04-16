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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaAlumno))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.ChIdAlumno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellido0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCorreo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsbAlumno = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(170, 158)
        Me.TxtBuscar.Multiline = True
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(314, 24)
        Me.TxtBuscar.TabIndex = 105
        '
        'ChIdAlumno
        '
        Me.ChIdAlumno.Text = "Cod. Alumno"
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
        'lsbAlumno
        '
        Me.lsbAlumno.BackColor = System.Drawing.Color.White
        Me.lsbAlumno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdAlumno, Me.chNombre, Me.ChApellido0, Me.chDireccion, Me.chTelefono, Me.chCorreo, Me.chSexo})
        Me.lsbAlumno.FullRowSelect = True
        Me.lsbAlumno.GridLines = True
        Me.lsbAlumno.Location = New System.Drawing.Point(-5, 212)
        Me.lsbAlumno.Name = "lsbAlumno"
        Me.lsbAlumno.Size = New System.Drawing.Size(746, 286)
        Me.lsbAlumno.TabIndex = 103
        Me.lsbAlumno.UseCompatibleStateImageBehavior = False
        Me.lsbAlumno.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(170, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Buscar por Código o Nombre"
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
        Me.BtnBuscar.Location = New System.Drawing.Point(490, 149)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 36)
        Me.BtnBuscar.TabIndex = 125
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmBusquedaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(737, 496)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.lsbAlumno)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBusquedaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusquedaAlumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents ChIdAlumno As ColumnHeader
    Friend WithEvents chNombre As ColumnHeader
    Friend WithEvents ChApellido0 As ColumnHeader
    Friend WithEvents chDireccion As ColumnHeader
    Friend WithEvents chTelefono As ColumnHeader
    Friend WithEvents chCorreo As ColumnHeader
    Friend WithEvents chSexo As ColumnHeader
    Friend WithEvents lsbAlumno As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
End Class
