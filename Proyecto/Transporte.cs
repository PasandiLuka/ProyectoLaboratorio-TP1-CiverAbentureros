namespace Proyecto;

public class Transporte
{
    public enum TipoTransporte
    {
        Colectivo,
        Tren,
        Avion
    }
    private TipoTransporte tipo { get; set; }
    private string empresa { get; set; }
    private int numeroAsiento { get; set; }
    private TimeSpan horarioSalida { get; set; }

    public Transporte(int tipo, string empresa, string horarioSalida)
    {
        if(tipo-1 == (int)TipoTransporte.Avion)
        {
            int numeroAsiento = IngresoDatos.Entero("Ingrese el n° de asiento (1 a 30)");
            Validaciones.EnteroBetween(numeroAsiento, 1, 30, "El numero de asiento se debe encontrar entre el 1 y el 30");
            this.numeroAsiento = numeroAsiento;
        }
        Validaciones.EnteroBetween(tipo, 1, 3, "Elija entre las opciones brindadas");
        this.tipo = (TipoTransporte)tipo-1;
        Validaciones.CadenaMin(empresa, 3, "El nombre de la empresa debe contener un minimo de tres caracteres.");
        this.empresa = empresa;
        this.horarioSalida = Validaciones.Hora(horarioSalida);
    }
    public void MostrarDatos() => Console.WriteLine($"Tipo de Transporte: {tipo} \nEmpresa: {empresa} \nNumero de asiento: {numeroAsiento} \nHorario de Salida: {horarioSalida} \n");

    //Setters
    public void SetTipo(int tipo)
    {
        Validaciones.EnteroBetween(tipo, 1, 3, "Elija entre las opciones brindadas");
        this.tipo = (TipoTransporte)tipo-1;
    }
    public void SetEmpresa(string empresa)
    {
        Validaciones.CadenaMin(empresa, 3, "El nombre de la empresa debe contener un minimo de tres caracteres.");
        this.empresa = empresa;
    }
    public void SetNumeroAsiento(int numeroAsiento)
    {
        if((int)tipo == 2)
        {
            Validaciones.EnteroBetween(numeroAsiento, 1, 30, "El numero de asiento se debe encontrar entre el 1 y el 30");
            this.numeroAsiento = numeroAsiento;
        }else
        {
            throw new ArgumentException("El tipo de transporte no permite una asignacion de asiento.");
        }
    }
    public void SetHorarioSalida(string horarioSalida)
    {
        this.horarioSalida = Validaciones.Hora(horarioSalida);
    }

    //Setters
    public string GetTipo() => Convert.ToString(tipo);
    public string GetEmpresa() => empresa;
    public int GetNumeroAsiento() => numeroAsiento;
    public TimeSpan GetHorarioSalida() => horarioSalida;
}