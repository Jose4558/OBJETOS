using System;

public class Ausencia
{
    public int AusenciaID { get; set; }
    public int EmpleadoID { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public string Tipo { get; set; }  // Ejemplo: "Justificada", "No Justificada"
    public bool Aprobada { get; set; }

    public Ausencia(int ausenciaID, int empleadoID, DateTime fechaInicio, DateTime fechaFin, string tipo)
    {
        AusenciaID = ausenciaID;
        EmpleadoID = empleadoID;
        FechaInicio = fechaInicio;
        FechaFin = fechaFin;
        Tipo = tipo;
        Aprobada = false;
    }

    public void AprobarAusencia()
    {
        Aprobada = true;
    }

    public decimal CalcularDescuentoSalario(Empleado empleado)
    {
        if (Tipo == "No Justificada" && Aprobada)
        {
            int diasAusencia = (FechaFin - FechaInicio).Days + 1;
            return (empleado.SalarioBase / 30) * diasAusencia;
        }
        return 0;
    }
}
