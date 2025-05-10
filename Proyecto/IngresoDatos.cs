namespace Proyecto;

public class IngresoDatos
{
    public static int Entero(string mensaje)
    {
        Console.WriteLine(mensaje);
        int resultado = int.Parse(Console.ReadLine());
        return resultado;
    }
    public static long Long(string mensaje)
    {
        Console.WriteLine(mensaje);
        long resultado = long.Parse(Console.ReadLine());
        return resultado;
    }
    public static string Cadena(string mensaje)
    {
        Console.WriteLine(mensaje);
        string resultado = Console.ReadLine();
        return resultado;
    }
    public static double Double(string mensaje)
    {
        Console.WriteLine(mensaje);
        double resultado = double.Parse(Console.ReadLine());
        return resultado;
    }
    public static short Short(string mensaje)
    {
        Console.WriteLine(mensaje);
        short resultado = short.Parse(Console.ReadLine());
        return resultado;
    }

    public static Cliente CreacionCliente()
    {
        int DNI = Entero("Ingrese el DNI del cliente:");
        string nombreCom = Cadena("Ingrese el nombre completo del cliente:");
        string correoElectronico = Cadena("Ingrese el correo electronico:");
        long telefono = Long("Ingrese el telefono del cliente:");
        string nacionalidad = Cadena("Ingrese la nacionalidad del cliente:");
        string nacimiento = Cadena("Ingrese la fecha de nacimiento con el formato 'YYYY-MM-DD'");

        Cliente cliente = new Cliente(DNI, nombreCom, correoElectronico, telefono, nacionalidad, nacimiento);

        return cliente;
    }
    public static Hospedaje CreacionHospedaje()
    {
        string nombre = Cadena("Ingrese el nombre del hotel:");
        string direccion = Cadena("Ingrese la direccion del hotel:");
        short cantidadEstre = Short("Ingrese la cantidad de estrellas (del 0 al 5)");
        int tipo = Entero("Ingrese el tipo de habitacion que desea: \n1 - Simple \n2 - Doble \n3 - Suite");
        
        Hospedaje hospedaje = new Hospedaje(nombre, direccion, cantidadEstre, tipo);

        return hospedaje;
    }
    public static Transporte CreacionTransporte()
    {
        int tipo = Entero("Ingrese el tipo del transporte: \n1 - Colectivo \n2 - Tren \n3 - Avion");
        string empresa = Cadena("Ingrese la empresa del transporte:");
        string horarioSalida = Cadena("Ingrese el horario de salida en el formato '00:00'");
        
        Transporte transporte = new Transporte(tipo, empresa, horarioSalida);

        return transporte;
    }
    public static Actividad CreacionActividad()
    {
        int tipo = Entero("Ingrese el tipo de actividad: \n1 - Excursiones \n2 - Visitas Guiadas \n3 - Eventos");
        string nombre = Cadena("Ingrese el nombre de la actividad:");
        string descripcion = Cadena("Ingrese la descripcion de la actividad:");
        int duracion = Entero("Ingrese la duracion de la actividad (en horas)");
        short opcional = Short("Indique si la actividad es obligatoria o no: \n1 - obligatoria \n2 - opcional");
        string lugar = Cadena("Ingrese el lugar donde se va a realizar la actividad");

        Actividad actividad = new Actividad(tipo, nombre, descripcion, duracion, opcional, lugar);

        return actividad;
    }
    public static Reserva CreacionReserva(Cliente cliente, PaqueteTuristico paqueteTuristico)
    {
        int idReserva = Entero("Ingrese el id de la reserva.");
        int metodoPago =Entero("Seleccione uno de los siguientes metodos de pago: \n1 - Credito \n2 - Debito \n3 - Transferencia \n4 - Efectivo");
        
        Reserva reserva = new Reserva(idReserva, metodoPago, cliente, paqueteTuristico);

        return reserva;
    }
    public static PaqueteTuristico CreacionPaquete(Hospedaje hospedaje, Transporte transporte, Actividad actividad)
    {
        string nombre = Cadena("Ingrese el nombre del paquete:");
        string descripcion = Cadena("Ingrese la descripcion del paquete:");
        double precioTotal = Double("Ingrese el precio total:");
        string fechaInicio = Cadena("Ingrese la fecha de inicio");
        string fechaFin = Cadena("Ingrese la fecha de fin");

        PaqueteTuristico paqueteTuristico = new PaqueteTuristico(nombre, descripcion, precioTotal, fechaInicio, fechaFin, hospedaje, transporte, actividad);

        return paqueteTuristico;
    }
}