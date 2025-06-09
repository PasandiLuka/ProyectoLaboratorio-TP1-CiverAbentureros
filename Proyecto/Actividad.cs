namespace Proyecto;

public class Actividad
{
    public enum TipoActividad
    {
        Excursiones,
        VisitasGuiadas,
        Eventos
    }
    private TipoActividad tipo {get; set;}
    private string nombre {get; set;}
    private string descripcion {get; set;}
    private int duracion {get; set;} //En horas
    private bool opcional {get; set;}
    private string lugar {get; set;} 


    public Actividad(int tipo, string nombre, string descripcion, int duracion, short opcional, string lugar)
    {
        Validaciones.EnteroBetween(tipo, 1, 3, "Elija entre las opciones brindadas");
        this.tipo = (TipoActividad)tipo-1;
        Validaciones.CadenaMin(nombre, 3, "El nombre de la actividad no puede poseer menos de 3 caracteres");
        this.nombre = nombre;
        Validaciones.CadenaMin(nombre, 10, "La descripcion de la actividad no puede poseer menos de 10 caracteres");
        this.descripcion = descripcion;
        Validaciones.Entero(duracion);
        this.duracion = duracion;
        if(opcional == 1)
        {
            this.opcional = false;
        }else if(opcional == 2)
        {
            this.opcional = true;
        }else
        {
            throw new ArgumentException("Ingrese 1 o 2 para indicar si 1-Es obligatoria o 2-Es opcional.");
        }
        Validaciones.CadenaMin(lugar, 3, "El lugar de la actividad no puede poseer menos de 3 caracteres");
        this.lugar = lugar;
    }
    
    public void MostrarDatos() => Console.WriteLine($"Nombre: {nombre} \nTipo de Actividad: {tipo} \nDescripcion: {descripcion} \nDuracion(en Horas): {duracion} \nOpcional?: {opcional} \nLugar: {lugar} \n");

    //Setters
    public void SetTipoActividad(int tipo)
    {
        Validaciones.EnteroBetween(tipo, 1, 3, "Elija entre las opciones brindadas");
        this.tipo = (TipoActividad)tipo-1;
    }
    public void SetNombre(string nombre)
    {
        Validaciones.CadenaMin(nombre, 3, "El nombre de la actividad no puede poseer menos de 3 caracteres");
        this.nombre = nombre;
    }
    public void SetDescripcion(string descripcion)
    {
        Validaciones.CadenaMin(nombre, 10, "La descripcion de la actividad no puede poseer menos de 10 caracteres");
        this.descripcion = descripcion;
    }
    public void SetDuracion(int duracion)
    {
        Validaciones.Entero(duracion);
        this.duracion = duracion;
    }
    public void SetOpcionalidad(bool opcional)
    {
        if(opcional == this.opcional)
        {
            throw new ArgumentException("Este valor ya se encuentra asignado");
        }else
        {
            this.opcional = opcional;
        }
    }

    //Getters
    public string GetTipoActividad() => Convert.ToString(tipo);
    public string GetNombre() => nombre;
    public string GetDescripcion() => descripcion;
    public int GetDuracion() => duracion;
    public bool GetOpcional() => opcional;
    public string GetLugar() => lugar;
}