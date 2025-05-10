namespace Proyecto;

public class Hospedaje
{
    private enum TipoHabitacion 
    {
        Simple,
        Doble,
        Suite    
    }

    private string nombre {get; set;}
    private string direccion {get; set;}
    private short cantidadEstre {get; set;}
    private TipoHabitacion tipo;
    private bool desayuno {get; set;}

    public Hospedaje(string nombre, string direccion, short cantidadEstre, int tipo)
    {
        Validaciones.CadenaMin(nombre, 3, "El nombre del hotel no puede poseer menos de 3 caracteres");
        this.nombre = nombre;
        Validaciones.CadenaMin(direccion, 3, "La direccion no puede contener menos de 3 caracteres");
        this.direccion = direccion;
        Validaciones.EnteroBetween(Convert.ToInt16(cantidadEstre), 0, 5, "Las estrellas deben ser un numero entero entre 0 y 5");
        this.cantidadEstre = cantidadEstre;
        Validaciones.EnteroBetween(tipo, 1, 3, "Elija entre las opciones brindadas");
        this.tipo = (TipoHabitacion)tipo - 1;
        if(tipo == (int)TipoHabitacion.Suite)
        {
            this.desayuno = true;
        }else
        {
            this.desayuno = false;
        }
            
    }

    //Setters
    public void SetNombre (string nombre)
    {
        Validaciones.CadenaMin(nombre, 3, "El nombre del hotel no puede poseer menos de 3 caracteres");
        this.nombre = nombre;
    }
    public void SetDireccion (string direccion)
    {
        Validaciones.CadenaMin(direccion, 3, "La direccion no puede contener menos de 3 caracteres");
        this.direccion = direccion;
    }
    public void SetCantidadEstre (short cantidadEstre)
    {
        Validaciones.EnteroBetween(Convert.ToInt16(cantidadEstre), 0, 5, "Las estrellas deben ser un numero entero entre 0 y 5");
        this.cantidadEstre = cantidadEstre;
    }
    public void SetTipoHabitacion (int tipo)
    {
        Validaciones.EnteroBetween(tipo, 1, 3, "Elija entre las opciones brindadas");
        this.tipo = (TipoHabitacion)tipo - 1; 
    }
    public void SetDesayuno(bool desayuno)
    {
        if(desayuno == this.desayuno)
        {
            throw new ArgumentException("Este valor ya se encuentra asignado");
        }else
        {
            this.desayuno = desayuno;
        }
    }

    //Getters
    public string GetNombre() => nombre;
    public string GetDireccion() => direccion;
    public short GetCantidadEstre() => cantidadEstre;
    public string GetTipoHabitacion() => Convert.ToString(tipo);
    public bool GetDesayuno() => desayuno;
}