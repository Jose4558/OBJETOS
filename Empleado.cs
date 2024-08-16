using System;
using System.Collections.Generic;

public class Empleado
{
    public int EmpleadoID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public decimal SalarioBase { get; set; }
    public string Foto { get; set; }  // Ruta al archivo de la foto
    public string Departamento { get; set; }
    public List<Documento> Documentos { get; set; }

    public Empleado(int empleadoID, string nombre, string apellido, DateTime fechaNacimiento, decimal salarioBase, string foto, string departamento)
    {
        EmpleadoID = empleadoID;
        Nombre = nombre;
        Apellido = apellido;
        FechaNacimiento = fechaNacimiento;
        SalarioBase = salarioBase;
        Foto = foto;
        Departamento = departamento;
        Documentos = new List<Documento>();
    }

    public decimal CalcularAnticipo()
    {
        return SalarioBase * 0.45M;
    }

    public void ActualizarSalario(decimal nuevoSalario)
    {
        SalarioBase = nuevoSalario;
    }

    public int ObtenerEdad()
    {
        var edad = DateTime.Now.Year - FechaNacimiento.Year;
        if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear)
            edad--;
        return edad;
    }

    public void AgregarDocumento(Documento documento)
    {
        Documentos.Add(documento);
    }
}
