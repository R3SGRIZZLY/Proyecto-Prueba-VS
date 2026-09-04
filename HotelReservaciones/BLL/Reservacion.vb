Public Class Reservacion
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property FechaEntrada As DateTime
    Public Property FechaSalida As DateTime
    Public Property NumeroNoches As Integer
    Public Property TipoHabitacion As String
    Public Property CostoTotal As Decimal
    Public Property TotalConITBMS As Decimal

    ' Método para calcular el costo total
    Public Sub CalcularCosto()
        Dim tarifa As Decimal
        Select Case TipoHabitacion
            Case "Individual"
                tarifa = 50
            Case "Doble"
                tarifa = 75
            Case "Suite"
                tarifa = 120
        End Select
        CostoTotal = NumeroNoches * tarifa
        TotalConITBMS = CostoTotal * 1.07 ' Incluye el 7% de ITBMS
    End Sub
End Class
