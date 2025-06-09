namespace Proyecto;

public class Reserva
{   
    public enum MetodoPago
    {
        Credito,
        Debito,
        Transferencia,
        Efectivo
    }
    
    private int idReserva {get; set;}
    private DateOnly fechaReserva {get; set;}
    private double monto {get; set;}
    private MetodoPago metodoPago {get; set;}
    public Cliente cliente {get; private set;}
    public PaqueteTuristico paqueteTuristico {get; private set;}

    public Reserva(int idReserva, int metodoPago)
    {
        DateOnly fechaReserva = DateOnly.FromDateTime(DateTime.Now);
        Validaciones.EnteroBetween(metodoPago, 1, 4, "Elija entre las opciones brindadas");
        this.metodoPago = (MetodoPago)metodoPago-1;
        Validaciones.Entero(idReserva);
        this.idReserva = idReserva;
        this.monto = paqueteTuristico.GetPrecioTotal();
        this.cliente = cliente;
        this.paqueteTuristico = paqueteTuristico;
    }

    public void MostrarDatos() => Console.WriteLine($"Id: {idReserva} \nFecha de Reservacion: {fechaReserva} \nMonto: {monto} \n");

    public void ValidarMonto(double monto)
    {
        if(monto < 0)
        {
            throw new ArgumentException("El monto debe ser positivo.");
        }
    }

    //Setters
    public void SetMetodoPago(int metodoPago)
    {
        Validaciones.EnteroBetween(metodoPago, 1, 3, "Elija entre las opciones brindadas");
        this.metodoPago = (MetodoPago)metodoPago-1;
    }

    //Getters
    public DateOnly GetFechaReserva() => fechaReserva;
    public double GetMonto() => monto;
    public int GetIdReserva() => idReserva;
    public string GetMetodoPago() => Convert.ToString(metodoPago);
}