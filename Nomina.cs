using System;
using System.Collections.Generic;

public class Nomina
{
    public int NominaID { get; set; }
    public int Mes { get; set; }
    public int Anio { get; set; }
    public decimal TotalNomina { get; private set; }

    public Nomina(int nominaID, int mes, int anio)
    {
        NominaID = nominaID;
        Mes = mes;
        Anio = anio;
        TotalNomina = 0;
    }

    public decimal CalcularNomina(List<Empleado> empleados)
    {
        foreach (var empleado in empleados)
        {
            var salario = empleado.SalarioBase;
            TotalNomina += salario;
        }
        return TotalNomina;
    }

    public decimal GenerarReciboBono14(Empleado empleado)
    {
        var bono14 = empleado.SalarioBase / 12;
        return bono14;
    }

    public decimal GenerarReciboAguinaldo(Empleado empleado)
    {
        var aguinaldo = empleado.SalarioBase / 12;
        return aguinaldo;
    }

}
