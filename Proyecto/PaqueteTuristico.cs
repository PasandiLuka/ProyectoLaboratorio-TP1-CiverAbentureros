namespace Proyecto;

public class PaqueteTuristico
{
    private string nombre {get; set;}
    private string descripcion {get; set;}
    private double precioTotal {get; set;}
    private DateOnly fechaInicio {get; set;}
    private DateOnly fechaFin {get; set;}
    private Hospedaje hospedaje {get; set;}
    private Transporte transporte {get; set;}
    private Actividad actividad {get; set;}

    public PaqueteTuristico(string nombre, string descripcion, double precioTotal, string fechaInicio, string fechaFin, Hospedaje hospedaje, Transporte transporte, Actividad actividad)
    {
        Validaciones.CadenaMin(nombre, 3, "El nombre del hotel no puede poseer menos de 3 caracteres");
        this.nombre = nombre;
        Validaciones.CadenaMin(nombre, 10, "La descripcion de la actividad no puede poseer menos de 10 caracteres");
        this.descripcion = descripcion;
        ValidarPrecioTotal(precioTotal);
        this.fechaInicio = Validaciones.Fecha(fechaInicio);
        this.fechaFin = Validaciones.Fecha(fechaFin);
        this.hospedaje = hospedaje;
        this.transporte = transporte;
        this.actividad = actividad;
    }

    public void ValidarPrecioTotal(double precioTotal)
    {
        if(precioTotal < 0)
        {
            throw new ArgumentException("El precio total no puede ser negativo");
        }else
        {
            this.precioTotal = precioTotal;
        }
    }

    //Setters
    public void SetNombre(string nombre)
    {
        Validaciones.CadenaMin(nombre, 3, "El nombre del hotel no puede poseer menos de 3 caracteres");
        this.nombre = nombre;
    }
    public void SetDescripcion()
    {
        Validaciones.CadenaMin(nombre, 10, "La descripcion de la actividad no puede poseer menos de 10 caracteres");
        this.descripcion = descripcion;
    }
    public void SetPrecioTotal(double precioTotal)
    {
        ValidarPrecioTotal(precioTotal);
    }
    public void SetFechaInicio(string fechaInicio)
    {
        this.fechaInicio = Validaciones.Fecha(fechaInicio);
    }
    public void SetFechaFin(string fechaFin)
    {
        this.fechaFin = Validaciones.Fecha(fechaFin);
    }

    //Getters
    public string GetNombre() => nombre;
    public string GetDescripcion() => descripcion;
    public double GetPrecioTotal() => precioTotal;
    public DateOnly GetFechaInicio() => fechaInicio;
    public DateOnly GetFechaFin() => fechaFin;
}