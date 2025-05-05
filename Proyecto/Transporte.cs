namespace Proyecto
{
public class Transporte
{
    public string? Tipo { get; set; }
    public string? Empresa { get; set; }
    public int? NumeroAsiento { get; set; }
    public DateOnly HorarioSalida { get; set; }


    public Transporte(string tipo, string empresa, int numeroAsiento, string horarioSalida)
    {
        this.Tipo = tipo;
        this.Empresa = empresa;
        this.NumeroAsiento = numeroAsiento;
        this.HorarioSalida = horarioSalida;
    }
}
}