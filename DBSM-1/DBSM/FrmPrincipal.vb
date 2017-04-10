Public Class FrmPrincipal
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Equipo As New FrmEquipo
        Equipo.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim AsignacionComputadora As New FrmAsignacionComputadoraA
        AsignacionComputadora.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Asignacion As New FrmAsignacionPrograma
        Asignacion.Show()
    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnoToolStripMenuItem.Click
        Dim Alumno As New FrmAlumno
        Alumno.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Dim Empleado As New FrmEmpleado
        Empleado.Show()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        Dim Marcas As New FrmMarca
        Marcas.Show()
    End Sub

    Private Sub ModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModeloToolStripMenuItem.Click
        Dim Modelo As New FrmModelo
        Modelo.Show()
    End Sub

    Private Sub ProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramaToolStripMenuItem.Click
        Dim Programa As New FrmPrograma
        Programa.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim Usuario As New FrmUsuarios
        Usuario.Show()
    End Sub

    Private Sub BuscarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoToolStripMenuItem.Click
        Dim BuscarEmpleado As New FrmBuscarEmpleado
        BuscarEmpleado.Show()
    End Sub

    Private Sub BuscarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarUsuarioToolStripMenuItem.Click
        Dim BuscarUsuario As New FrmBuscarUsuario
        BuscarUsuario.Show()
    End Sub

    Private Sub BuscarAsignacionComputadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarAsignacionComputadoraToolStripMenuItem.Click
        Dim BuscarAsignacion As New FrmAsignacionComputadoraA
        BuscarAsignacion.Show()
    End Sub

    Private Sub BuscarComputadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarComputadoraToolStripMenuItem.Click
        Dim BuscarComputadora As New FrmBusquedaComputadora
        BuscarComputadora.Show()
    End Sub

    Private Sub BuscarMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarMarcaToolStripMenuItem.Click
        Dim BuscarMarca As New FrmMarca
        BuscarMarca.Show()
    End Sub

    Private Sub BuscarModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarModeloToolStripMenuItem.Click
        Dim BuscarModelo As New FrmBusquedaModelo
        BuscarModelo.Show()
    End Sub

    Private Sub BuscarAsignaciónProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarAsignaciónProgramaToolStripMenuItem.Click
        Dim AsignacionPrograma As New FrmAsignacionPrograma
        AsignacionPrograma.Show()
    End Sub

    Private Sub BuscarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProgramaToolStripMenuItem.Click
        Dim Programa As New FrmPrograma
        Programa.Show()
    End Sub
End Class