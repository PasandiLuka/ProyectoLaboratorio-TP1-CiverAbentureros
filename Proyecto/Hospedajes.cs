using Proyecto;

public class Hospedajes
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public int? Telefono { get; set; }
    public DateTime FechaIngreso { get; set; }
    public DateTime FechaSalida { get; set; }

    public Hospedajes(string nombre, string direccion, int telefono, DateTime fechaIngreso, DateTime fechaSalida)
{
    Nombre = nombre;
    Direccion = direccion;
    Telefono = telefono;
    FechaIngreso = fechaIngreso;
    FechaSalida = fechaSalida;
}

}

