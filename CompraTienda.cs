using System;

public class CompraTienda
{
    public int CompraID { get; set; }
    public int EmpleadoID { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaCompra { get; set; }
    public int PlazoPago { get; set; }  // En meses

    public CompraTienda(int compraID, int empleadoID, decimal monto, DateTime fechaCompra, int plazoPago)
    {
        CompraID = compraID;
        EmpleadoID = empleadoID;
        Monto = monto;
        FechaCompra = fechaCompra;
        PlazoPago = plazoPago;
    }

    public decimal CalcularCuotaMensual()
    {
        return Monto / PlazoPago;
    }

    public bool VerificarLimiteCredito(Empleado empleado)
    {
        return empleado.CreditoDisponible >= Monto;
    }

    public string GenerarEstadoCuenta()
    {
        return $"Monto Total: {Monto}, Plazo de Pago: {PlazoPago} meses, Cuota Mensual: {CalcularCuotaMensual()}";
    }
}
