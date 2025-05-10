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
    private Cliente cliente {get; set;}
    private PaqueteTuristico paqueteTuristico {get; set;}

    public Reserva(int idReserva, int metodoPago, Cliente cliente, PaqueteTuristico paqueteTuristico)
    {
        DateOnly fechaReserva = DateOnly.FromDateTime(DateTime.Now);
        Validaciones.EnteroBetween(metodoPago, 1, 3, "Elija entre las opciones brindadas");
        this.metodoPago = (MetodoPago)metodoPago-1;
        Validaciones.Entero(idReserva);
        this.idReserva = idReserva;
        this.cliente = cliente;
        this.paqueteTuristico = paqueteTuristico;
        this.monto = paqueteTuristico.GetPrecioTotal();
    }

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