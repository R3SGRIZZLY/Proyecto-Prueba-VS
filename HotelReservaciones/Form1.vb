Imports System.Data

Public Class Form1
    Private reservacionDAL As New ReservacionDAL()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarReservaciones()
        cboTipoHabitacion.Items.AddRange({"Individual", "Doble", "Suite"})
    End Sub

    ' Método para cargar las reservaciones en el DataGridView
    Private Sub CargarReservaciones()
        Dim ds As DataSet = reservacionDAL.ObtenerReservaciones()
        dgvReservaciones.DataSource = ds.Tables(0)
    End Sub

    ' Evento para actualizar el costo al cambiar las fechas o el tipo de habitación
    Private Sub ActualizarCosto() Handles dtpFechaSalida.ValueChanged, cboTipoHabitacion.SelectedIndexChanged
        If cboTipoHabitacion.SelectedIndex = -1 OrElse dtpFechaSalida.Value <= dtpFechaEntrada.Value Then
            lblMostrarTotal.Text = "$0.00"
            Return
        End If

        Dim reservacion As New Reservacion() With {
            .FechaEntrada = dtpFechaEntrada.Value,
            .FechaSalida = dtpFechaSalida.Value,
            .NumeroNoches = (dtpFechaSalida.Value - dtpFechaEntrada.Value).Days,
            .TipoHabitacion = cboTipoHabitacion.SelectedItem.ToString()
        }
        reservacion.CalcularCosto()
        lblMostrarTotal.Text = reservacion.TotalConITBMS.ToString("C")
    End Sub

    ' Evento para agregar una nueva reservación
    Private Sub btnAgregarReservacion_Click(sender As Object, e As EventArgs) Handles btnAgregarReservacion.Click
        Dim reservacion As New Reservacion() With {
            .Nombre = txtNombreHuesped.Text,
            .FechaEntrada = dtpFechaEntrada.Value,
            .FechaSalida = dtpFechaSalida.Value,
            .NumeroNoches = (dtpFechaSalida.Value - dtpFechaEntrada.Value).Days,
            .TipoHabitacion = cboTipoHabitacion.SelectedItem.ToString()
        }
        reservacion.CalcularCosto()
        reservacionDAL.AgregarReservacion(reservacion)
        CargarReservaciones()
    End Sub

    ' Evento para actualizar una reservación seleccionada
    Private Sub btnActualizarReservacion_Click(sender As Object, e As EventArgs) Handles btnActualizarReservacion.Click
        If dgvReservaciones.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvReservaciones.SelectedRows(0).Cells("Id").Value)
            Dim reservacion As New Reservacion() With {
                .Id = id,
                .Nombre = txtNombreHuesped.Text,
                .FechaEntrada = dtpFechaEntrada.Value,
                .FechaSalida = dtpFechaSalida.Value,
                .NumeroNoches = (dtpFechaSalida.Value - dtpFechaEntrada.Value).Days,
                .TipoHabitacion = cboTipoHabitacion.SelectedItem.ToString()
            }
            reservacion.CalcularCosto()
            reservacionDAL.ActualizarReservacion(reservacion)
            CargarReservaciones()
        End If
    End Sub

    ' Evento para eliminar una reservación seleccionada
    Private Sub btnEliminarReservacion_Click(sender As Object, e As EventArgs) Handles btnEliminarReservacion.Click
        If dgvReservaciones.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvReservaciones.SelectedRows(0).Cells("Id").Value)
            reservacionDAL.EliminarReservacion(id)
            CargarReservaciones()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnAgregarReservacion_Click_1(sender As Object, e As EventArgs) Handles btnAgregarReservacion.Click

    End Sub
End Class
