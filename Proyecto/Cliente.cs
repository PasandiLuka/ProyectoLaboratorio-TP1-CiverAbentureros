namespace Proyecto;

public class Cliente
{
    private int DNI {get; set;}
    private string nombreCom {get; set;}
    private string correoElectronico {get; set;}
    private long telefono {get; set;}
    private string nacionalidad {get; set;}
    private DateOnly nacimiento {get; set;}

    public Cliente(int DNI, string nombreCom, string correoElectronico, long telefono, string nacionalidad, string nacimiento)
    {
        Validaciones.EnteroBetween(DNI, 0, 99999999, "El DNI se debe encontrar entre 0 y 99999999");
        this.DNI = DNI;
        Validaciones.CadenaMin(nombreCom, 4, "El nombre completo debe poseer minimo 4 letras.");
        this.nombreCom = nombreCom;
        Validaciones.CorreoElectronico(correoElectronico);
        this.correoElectronico = correoElectronico;
        ValidarTelefono(telefono);
        this.telefono = telefono;
        Validaciones.CadenaMin(nacionalidad, 3, "El pais no debe contener menos de 3 caracteres");
        this.nacionalidad = nacionalidad;
        this.nacimiento = Validaciones.Fecha(nacimiento);
    }
    private void ValidarTelefono(long telefono)
    {
        if(!(telefono >= 541100000000 && telefono <= 541199999999))
            {
                throw new ArgumentException("El telefono debe comenzar con 5411 y a continuacion debe poseer 8 digitos mas.");
            }
    }

    //SETTERS
    public void SetDNI(int DNI)
    {
        Validaciones.EnteroBetween(DNI, 0, 99999999, "El DNI se debe encontrar entre 0 y 99999999");
        this.DNI = DNI;
    }
    public void SetNombreCom (string nombreCom)
    {
        Validaciones.CadenaMin(nombreCom, 4, "El nombre completo debe poseer minimo 4 letras.");
        this.nombreCom = nombreCom;
    }
    public void  SetCorreoElectronico (string correoElectronico)
    {
        Validaciones.CorreoElectronico(correoElectronico);
        this.correoElectronico = correoElectronico;
    }
    public void SetTelefono (long telefono)
    {
        ValidarTelefono(telefono);
        this.telefono = telefono;
    }
    public void SetNacionalidad (string nacionalidad)
    {
        Validaciones.CadenaMin(nacionalidad, 3, "El pais no debe contener menos de 3 caracteres");
        this.nacionalidad = nacionalidad;
    }
    public void SetNacimiento (string nacimiento)
    {
        this.nacimiento = Validaciones.Fecha(nacimiento);
    }

    //GETTERS
    public int GetDNI() => this.DNI;
    public string GetNombreCom() => this.nombreCom;
    public string GetCorreo() => this.correoElectronico;
    public long GetTelefono() => this.telefono;
    public string GetNacionalidad() => this.nacionalidad;
    public DateOnly GetNacimiento() => this.nacimiento;
}   