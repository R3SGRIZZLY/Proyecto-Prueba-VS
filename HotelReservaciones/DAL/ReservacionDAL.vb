Imports System.Data.SqlClient

Public Class ReservacionDAL
    Private connectionString As String = "Server=LAPTOP-PAHTQ5QE\SQLEXPRESS;Database=HotelDB;Trusted_Connection=True;"

    ' Método para obtener todas las reservaciones
    Public Function ObtenerReservaciones() As DataSet
        Dim ds As New DataSet()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM Reservaciones"
            Dim adapter As New SqlDataAdapter(query, connection)
            adapter.Fill(ds)
        End Using
        Return ds
    End Function

    ' Método para agregar una nueva reservación
    Public Sub AgregarReservacion(reservacion As Reservacion)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO Reservaciones (Nombre, FechaEntrada, FechaSalida, NumeroNoches, TipoHabitacion, CostoTotal, TotalConITBMS) 
                                   VALUES (@Nombre, @FechaEntrada, @FechaSalida, @NumeroNoches, @TipoHabitacion, @CostoTotal, @TotalConITBMS)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", reservacion.Nombre)
                command.Parameters.AddWithValue("@FechaEntrada", reservacion.FechaEntrada)
                command.Parameters.AddWithValue("@FechaSalida", reservacion.FechaSalida)
                command.Parameters.AddWithValue("@NumeroNoches", reservacion.NumeroNoches)
                command.Parameters.AddWithValue("@TipoHabitacion", reservacion.TipoHabitacion)
                command.Parameters.AddWithValue("@CostoTotal", reservacion.CostoTotal)
                command.Parameters.AddWithValue("@TotalConITBMS", reservacion.TotalConITBMS)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para actualizar una reservación
    Public Sub ActualizarReservacion(reservacion As Reservacion)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE Reservaciones SET Nombre=@Nombre, FechaEntrada=@FechaEntrada, FechaSalida=@FechaSalida, 
                                   NumeroNoches=@NumeroNoches, TipoHabitacion=@TipoHabitacion, CostoTotal=@CostoTotal, TotalConITBMS=@TotalConITBMS
                                   WHERE Id=@Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", reservacion.Id)
                command.Parameters.AddWithValue("@Nombre", reservacion.Nombre)
                command.Parameters.AddWithValue("@FechaEntrada", reservacion.FechaEntrada)
                command.Parameters.AddWithValue("@FechaSalida", reservacion.FechaSalida)
                command.Parameters.AddWithValue("@NumeroNoches", reservacion.NumeroNoches)
                command.Parameters.AddWithValue("@TipoHabitacion", reservacion.TipoHabitacion)
                command.Parameters.AddWithValue("@CostoTotal", reservacion.CostoTotal)
                command.Parameters.AddWithValue("@TotalConITBMS", reservacion.TotalConITBMS)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Método para eliminar una reservación
    Public Sub EliminarReservacion(id As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "DELETE FROM Reservaciones WHERE Id=@Id"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", id)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
