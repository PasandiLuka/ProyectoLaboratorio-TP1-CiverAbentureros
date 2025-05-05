namespace Proyecto;

public class Cliente
{
    private int DNI {get; set;}
    private string nombreCom {get; set;}
    private string correoElectronico {get; set;}
    private string telefono {get; set;}
    private string nacionalidad {get; set;}
    private string nacimiento {get; set;}

    public Cliente(int DNI, string nombreCom, string correoElectronico, string telefono, string nacionalidad, string nacimiento)
    {
        Validaciones.EnteroBetween(DNI, 0, 99999999, "El DNI se debe encontrar entre 0 y 99999999");
        this.DNI = DNI;
        Validaciones.CadenaMin(nombreCom, 4, "El nombre completo debe poseer minimo 4 letras.");
        this.nombreCom = nombreCom;
        Validaciones.CorreoElectronico(correoElectronico);
        this.correoElectronico = correoElectronico;
        Validaciones.
    }    
}   