<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TssUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TssIdUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusquedasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarAsignacionComputadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarAsignaciónProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarComputadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarMarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogAuditoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnEquipo = New System.Windows.Forms.Button()
        Me.BtnAC = New System.Windows.Forms.Button()
        Me.BtnAP = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Registro Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(515, 555)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Asignación Computadora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(864, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Asignación Programa"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TssUsuario, Me.ToolStripStatusLabel2, Me.TssIdUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 603)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario Activo:"
        '
        'TssUsuario
        '
        Me.TssUsuario.Name = "TssUsuario"
        Me.TssUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'TssIdUsuario
        '
        Me.TssIdUsuario.Name = "TssIdUsuario"
        Me.TssIdUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.BusquedasToolStripMenuItem, Me.LogAuditoriaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnoToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.ModeloToolStripMenuItem, Me.ProgramaToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Image = CType(resources.GetObject("CatálogosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'AlumnoToolStripMenuItem
        '
        Me.AlumnoToolStripMenuItem.Image = CType(resources.GetObject("AlumnoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AlumnoToolStripMenuItem.Name = "AlumnoToolStripMenuItem"
        Me.AlumnoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.AlumnoToolStripMenuItem.Text = "Alumno"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Image = CType(resources.GetObject("EmpleadoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Image = CType(resources.GetObject("MarcaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.MarcaToolStripMenuItem.Text = "Marca"
        '
        'ModeloToolStripMenuItem
        '
        Me.ModeloToolStripMenuItem.Image = CType(resources.GetObject("ModeloToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModeloToolStripMenuItem.Name = "ModeloToolStripMenuItem"
        Me.ModeloToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ModeloToolStripMenuItem.Text = "Modelo"
        '
        'ProgramaToolStripMenuItem
        '
        Me.ProgramaToolStripMenuItem.Image = CType(resources.GetObject("ProgramaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProgramaToolStripMenuItem.Name = "ProgramaToolStripMenuItem"
        Me.ProgramaToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ProgramaToolStripMenuItem.Text = "Programa"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'BusquedasToolStripMenuItem
        '
        Me.BusquedasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarAlumnoToolStripMenuItem, Me.BuscarAsignacionComputadoraToolStripMenuItem, Me.BuscarAsignaciónProgramaToolStripMenuItem, Me.BuscarComputadoraToolStripMenuItem, Me.BuscarEmpleadoToolStripMenuItem, Me.BuscarMarcaToolStripMenuItem, Me.BuscarModeloToolStripMenuItem, Me.BuscarProgramaToolStripMenuItem, Me.BuscarUsuarioToolStripMenuItem})
        Me.BusquedasToolStripMenuItem.Image = CType(resources.GetObject("BusquedasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BusquedasToolStripMenuItem.Name = "BusquedasToolStripMenuItem"
        Me.BusquedasToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.BusquedasToolStripMenuItem.Text = "Busquedas"
        '
        'BuscarAlumnoToolStripMenuItem
        '
        Me.BuscarAlumnoToolStripMenuItem.Image = CType(resources.GetObject("BuscarAlumnoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarAlumnoToolStripMenuItem.Name = "BuscarAlumnoToolStripMenuItem"
        Me.BuscarAlumnoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarAlumnoToolStripMenuItem.Text = "Buscar Alumno"
        '
        'BuscarAsignacionComputadoraToolStripMenuItem
        '
        Me.BuscarAsignacionComputadoraToolStripMenuItem.Image = CType(resources.GetObject("BuscarAsignacionComputadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarAsignacionComputadoraToolStripMenuItem.Name = "BuscarAsignacionComputadoraToolStripMenuItem"
        Me.BuscarAsignacionComputadoraToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarAsignacionComputadoraToolStripMenuItem.Text = "Buscar Asignación Computadora"
        '
        'BuscarAsignaciónProgramaToolStripMenuItem
        '
        Me.BuscarAsignaciónProgramaToolStripMenuItem.Image = CType(resources.GetObject("BuscarAsignaciónProgramaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarAsignaciónProgramaToolStripMenuItem.Name = "BuscarAsignaciónProgramaToolStripMenuItem"
        Me.BuscarAsignaciónProgramaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarAsignaciónProgramaToolStripMenuItem.Text = "Buscar Asignación Programa"
        '
        'BuscarComputadoraToolStripMenuItem
        '
        Me.BuscarComputadoraToolStripMenuItem.Image = CType(resources.GetObject("BuscarComputadoraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarComputadoraToolStripMenuItem.Name = "BuscarComputadoraToolStripMenuItem"
        Me.BuscarComputadoraToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarComputadoraToolStripMenuItem.Text = "Buscar Computadora"
        '
        'BuscarEmpleadoToolStripMenuItem
        '
        Me.BuscarEmpleadoToolStripMenuItem.Image = CType(resources.GetObject("BuscarEmpleadoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarEmpleadoToolStripMenuItem.Name = "BuscarEmpleadoToolStripMenuItem"
        Me.BuscarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarEmpleadoToolStripMenuItem.Text = "Buscar Empleado"
        '
        'BuscarMarcaToolStripMenuItem
        '
        Me.BuscarMarcaToolStripMenuItem.Image = CType(resources.GetObject("BuscarMarcaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarMarcaToolStripMenuItem.Name = "BuscarMarcaToolStripMenuItem"
        Me.BuscarMarcaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarMarcaToolStripMenuItem.Text = "Buscar Marca"
        '
        'BuscarModeloToolStripMenuItem
        '
        Me.BuscarModeloToolStripMenuItem.Image = CType(resources.GetObject("BuscarModeloToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarModeloToolStripMenuItem.Name = "BuscarModeloToolStripMenuItem"
        Me.BuscarModeloToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarModeloToolStripMenuItem.Text = "Buscar Modelo"
        '
        'BuscarProgramaToolStripMenuItem
        '
        Me.BuscarProgramaToolStripMenuItem.Image = CType(resources.GetObject("BuscarProgramaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarProgramaToolStripMenuItem.Name = "BuscarProgramaToolStripMenuItem"
        Me.BuscarProgramaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarProgramaToolStripMenuItem.Text = "Buscar Programa"
        '
        'BuscarUsuarioToolStripMenuItem
        '
        Me.BuscarUsuarioToolStripMenuItem.Image = CType(resources.GetObject("BuscarUsuarioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarUsuarioToolStripMenuItem.Name = "BuscarUsuarioToolStripMenuItem"
        Me.BuscarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.BuscarUsuarioToolStripMenuItem.Text = "Buscar Usuario"
        '
        'LogAuditoriaToolStripMenuItem
        '
        Me.LogAuditoriaToolStripMenuItem.Image = CType(resources.GetObject("LogAuditoriaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogAuditoriaToolStripMenuItem.Name = "LogAuditoriaToolStripMenuItem"
        Me.LogAuditoriaToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.LogAuditoriaToolStripMenuItem.Text = "LogAuditoria"
        '
        'BtnEquipo
        '
        Me.BtnEquipo.BackColor = System.Drawing.Color.Transparent
        Me.BtnEquipo.BackgroundImage = CType(resources.GetObject("BtnEquipo.BackgroundImage"), System.Drawing.Image)
        Me.BtnEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEquipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEquipo.FlatAppearance.BorderSize = 0
        Me.BtnEquipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEquipo.Location = New System.Drawing.Point(245, 216)
        Me.BtnEquipo.Name = "BtnEquipo"
        Me.BtnEquipo.Size = New System.Drawing.Size(181, 164)
        Me.BtnEquipo.TabIndex = 12
        Me.BtnEquipo.UseVisualStyleBackColor = False
        '
        'BtnAC
        '
        Me.BtnAC.BackColor = System.Drawing.Color.Transparent
        Me.BtnAC.BackgroundImage = CType(resources.GetObject("BtnAC.BackgroundImage"), System.Drawing.Image)
        Me.BtnAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAC.FlatAppearance.BorderSize = 0
        Me.BtnAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAC.Location = New System.Drawing.Point(576, 393)
        Me.BtnAC.Name = "BtnAC"
        Me.BtnAC.Size = New System.Drawing.Size(179, 159)
        Me.BtnAC.TabIndex = 13
        Me.BtnAC.UseVisualStyleBackColor = False
        '
        'BtnAP
        '
        Me.BtnAP.BackColor = System.Drawing.Color.Transparent
        Me.BtnAP.BackgroundImage = CType(resources.GetObject("BtnAP.BackgroundImage"), System.Drawing.Image)
        Me.BtnAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnAP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAP.FlatAppearance.BorderSize = 0
        Me.BtnAP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAP.Location = New System.Drawing.Point(897, 220)
        Me.BtnAP.Name = "BtnAP"
        Me.BtnAP.Size = New System.Drawing.Size(179, 159)
        Me.BtnAP.TabIndex = 13
        Me.BtnAP.UseVisualStyleBackColor = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1028, 625)
        Me.Controls.Add(Me.BtnAP)
        Me.Controls.Add(Me.BtnAC)
        Me.Controls.Add(Me.BtnEquipo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menú Pricipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TssUsuario As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TssIdUsuario As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BusquedasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarAsignacionComputadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarComputadoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarMarcaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarModeloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarAsignaciónProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogAuditoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnEquipo As Button
    Friend WithEvents BtnAC As Button
    Friend WithEvents BtnAP As Button
    Friend WithEvents BuscarAlumnoToolStripMenuItem As ToolStripMenuItem
End Class
