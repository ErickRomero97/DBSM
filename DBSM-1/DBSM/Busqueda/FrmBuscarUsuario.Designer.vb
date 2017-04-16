<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarUsuario))
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LsvMostrarUsuario = New System.Windows.Forms.ListView()
        Me.ChIdUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChContraseña = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbId = New System.Windows.Forms.RadioButton()
        Me.RdbNombre = New System.Windows.Forms.RadioButton()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(50, 157)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(297, 20)
        Me.TxtBuscar.TabIndex = 37
        '
        'LsvMostrarUsuario
        '
        Me.LsvMostrarUsuario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdUsuario, Me.ChUsuario, Me.ChContraseña, Me.ChEstado, Me.ChEmpleado, Me.ChTipoUsuario})
        Me.LsvMostrarUsuario.FullRowSelect = True
        Me.LsvMostrarUsuario.GridLines = True
        Me.LsvMostrarUsuario.Location = New System.Drawing.Point(-1, 198)
        Me.LsvMostrarUsuario.Name = "LsvMostrarUsuario"
        Me.LsvMostrarUsuario.Size = New System.Drawing.Size(481, 246)
        Me.LsvMostrarUsuario.TabIndex = 36
        Me.LsvMostrarUsuario.UseCompatibleStateImageBehavior = False
        Me.LsvMostrarUsuario.View = System.Windows.Forms.View.Details
        '
        'ChIdUsuario
        '
        Me.ChIdUsuario.Text = "Codigo Usuario"
        Me.ChIdUsuario.Width = 89
        '
        'ChUsuario
        '
        Me.ChUsuario.Text = "Usuario"
        Me.ChUsuario.Width = 80
        '
        'ChContraseña
        '
        Me.ChContraseña.Text = "Contraseña"
        Me.ChContraseña.Width = 76
        '
        'ChEstado
        '
        Me.ChEstado.Text = "Estado"
        '
        'ChEmpleado
        '
        Me.ChEmpleado.Text = "Id Empleado"
        Me.ChEmpleado.Width = 89
        '
        'ChTipoUsuario
        '
        Me.ChTipoUsuario.Text = "Tipo Usuario"
        Me.ChTipoUsuario.Width = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RdbId)
        Me.GroupBox1.Controls.Add(Me.RdbNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 57)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de busqueda"
        '
        'RdbId
        '
        Me.RdbId.AutoSize = True
        Me.RdbId.Location = New System.Drawing.Point(157, 25)
        Me.RdbId.Name = "RdbId"
        Me.RdbId.Size = New System.Drawing.Size(83, 17)
        Me.RdbId.TabIndex = 1
        Me.RdbId.TabStop = True
        Me.RdbId.Text = "Cod Usuario"
        Me.RdbId.UseVisualStyleBackColor = True
        '
        'RdbNombre
        '
        Me.RdbNombre.AutoSize = True
        Me.RdbNombre.Location = New System.Drawing.Point(31, 25)
        Me.RdbNombre.Name = "RdbNombre"
        Me.RdbNombre.Size = New System.Drawing.Size(62, 17)
        Me.RdbNombre.TabIndex = 0
        Me.RdbNombre.TabStop = True
        Me.RdbNombre.Text = "Nombre"
        Me.RdbNombre.UseVisualStyleBackColor = True
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
        Me.BtnBuscar.Location = New System.Drawing.Point(353, 148)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(39, 36)
        Me.BtnBuscar.TabIndex = 124
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'FrmBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(476, 448)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.LsvMostrarUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LsvMostrarUsuario As ListView
    Friend WithEvents ChIdUsuario As ColumnHeader
    Friend WithEvents ChUsuario As ColumnHeader
    Friend WithEvents ChContraseña As ColumnHeader
    Friend WithEvents ChEstado As ColumnHeader
    Friend WithEvents ChEmpleado As ColumnHeader
    Friend WithEvents ChTipoUsuario As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbId As RadioButton
    Friend WithEvents RdbNombre As RadioButton
    Friend WithEvents BtnBuscar As Button
End Class
