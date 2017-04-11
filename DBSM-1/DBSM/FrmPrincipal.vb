Public Class FrmPrincipal

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
        Dim BuscarAsignacion As New FrmBusquedaAsignacionComputadora
        BuscarAsignacion.Show()
    End Sub

    Private Sub BuscarComputadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarComputadoraToolStripMenuItem.Click
        Dim BuscarComputadora As New FrmBusquedaComputadora
        BuscarComputadora.Show()
    End Sub

    Private Sub BuscarMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarMarcaToolStripMenuItem.Click
        Dim BuscarMarca As New FrmBusquedaMarca
        BuscarMarca.Show()
    End Sub

    Private Sub BuscarModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarModeloToolStripMenuItem.Click
        Dim BuscarModelo As New FrmBusquedaModelo
        BuscarModelo.Show()
    End Sub

    Private Sub BuscarAsignaciónProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarAsignaciónProgramaToolStripMenuItem.Click
        Dim AsignacionPrograma As New FrmBuscarAsignacionPrograma
        AsignacionPrograma.Show()
    End Sub

    Private Sub BuscarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProgramaToolStripMenuItem.Click
        Dim Programa As New FrmBuscarPrograma
        Programa.Show()
    End Sub

    Private Sub LogAuditoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogAuditoriaToolStripMenuItem.Click
        FrmLogAuditoria.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BtnEquipo_Click(sender As Object, e As EventArgs) Handles BtnEquipo.Click
        Dim Equipo As New FrmEquipo
        FrmEquipo.Show()
    End Sub

    Private Sub BtnAC_Click(sender As Object, e As EventArgs) Handles BtnAC.Click
        Dim AsignacionComputadora As New FrmAsignacionComputadora
        FrmAsignacionComputadora.Show()
    End Sub

    Private Sub BtnAP_Click(sender As Object, e As EventArgs) Handles BtnAP.Click
        Dim Asignacion As New FrmAsignacionPrograma
        FrmAsignacionPrograma.Show()
    End Sub
End Class