using System;

public class Prestamo
{
    public int PrestamoID { get; set; }
    public int EmpleadoID { get; set; }
    public decimal Monto { get; set; }
    public int Plazo { get; set; }  // En meses
    public decimal SaldoPendiente { get; private set; }
    public DateTime FechaInicio { get; set; }

    public Prestamo(int prestamoID, int empleadoID, decimal monto, int plazo, DateTime fechaInicio)
    {
        PrestamoID = prestamoID;
        EmpleadoID = empleadoID;
        Monto = monto;
        Plazo = plazo;
        SaldoPendiente = monto;
        FechaInicio = fechaInicio;
    }

    public decimal CalcularCuotaMensual()
    {
        return Monto / Plazo;
    }

    public void ActualizarSaldo(decimal montoPagado)
    {
        SaldoPendiente -= montoPagado;
    }

    public string GenerarEstadoCuenta()
    {
        return $"Monto Original: {Monto}, Saldo Pendiente: {SaldoPendiente}, Cuotas Restantes: {Plazo - (Monto - SaldoPendiente) / CalcularCuotaMensual()}";
    }
}
