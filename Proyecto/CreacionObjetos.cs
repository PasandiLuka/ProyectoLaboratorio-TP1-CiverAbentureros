namespace Proyecto;

public class CreacionObjetos
{
public static Cliente Cliente()
{   
    Console.WriteLine("\nCreacion Cliente:");
    int DNI = IngresoDatos.Entero("Ingrese el DNI del cliente:");
    string nombreCom = IngresoDatos.Cadena("Ingrese el nombre completo del cliente:");
    string correoElectronico = IngresoDatos.Cadena("Ingrese el correo electronico:");
    long telefono = IngresoDatos.Long("Ingrese el telefono del cliente:");
    string nacionalidad = IngresoDatos.Cadena("Ingrese la nacionalidad del cliente:");
    string nacimiento = IngresoDatos.Cadena("Ingrese la fecha de nacimiento con el formato 'YYYY-MM-DD'");

    Cliente cliente = new Cliente(DNI, nombreCom, correoElectronico, telefono, nacionalidad, nacimiento);

    return cliente;
}
public static Hospedaje Hospedaje()
{
    Console.WriteLine("\nCreacion Hospedaje:");
    string nombre = IngresoDatos.Cadena("Ingrese el nombre del hotel:");
    string direccion = IngresoDatos.Cadena("Ingrese la direccion del hotel:");
    float cantidadEstre = IngresoDatos.Float("Ingrese la cantidad de estrellas (del 0 al 5)");
    int tipo = IngresoDatos.Entero("Ingrese el tipo de habitacion que desea: \n1 - Simple \n2 - Doble \n3 - Suite");
    
    Hospedaje hospedaje = new Hospedaje(tipo, nombre, direccion, cantidadEstre);

    return hospedaje;
}
public static Transporte Transporte()
{
    Console.WriteLine("\nCreacion Transporte:");
    int tipo = IngresoDatos.Entero("Ingrese el tipo del transporte: \n1 - Colectivo \n2 - Tren \n3 - Avion");
    string empresa = IngresoDatos.Cadena("Ingrese la empresa del transporte:");
    string horarioSalida = IngresoDatos.Cadena("Ingrese el horario de salida en el formato '00:00'");
    
    Transporte transporte = new Transporte(tipo, empresa, horarioSalida);

    return transporte;
}
public static Actividad Actividad()
{
    Console.WriteLine("\nCreacion Actividad:");
    int tipo = IngresoDatos.Entero("Ingrese el tipo de actividad: \n1 - Excursiones \n2 - Visitas Guiadas \n3 - Eventos");
    string nombre = IngresoDatos.Cadena("Ingrese el nombre de la actividad:");
    string descripcion = IngresoDatos.Cadena("Ingrese la descripcion de la actividad:");
    int duracion = IngresoDatos.Entero("Ingrese la duracion de la actividad (en horas)");
    short opcional = IngresoDatos.Short("Indique si la actividad es obligatoria o no: \n1 - obligatoria \n2 - opcional");
    string lugar = IngresoDatos.Cadena("Ingrese el lugar donde se va a realizar la actividad");

    Actividad actividad = new Actividad(tipo, nombre, descripcion, duracion, opcional, lugar);

    return actividad;
}
public static PaqueteTuristico Paquete(Hospedaje hospedaje, Transporte transporte, Actividad actividad)
{
    Console.WriteLine("\nCreacion Paquete:");
    string nombre = IngresoDatos.Cadena("Ingrese el nombre del paquete:");
    string descripcion = IngresoDatos.Cadena("Ingrese la descripcion del paquete:");
    double precioTotal = IngresoDatos.Double("Ingrese el precio total:");
    string fechaInicio = IngresoDatos.Cadena("Ingrese la fecha de inicio (con el formato 'YYYY-MM-DD')");
    string fechaFin = IngresoDatos.Cadena("Ingrese la fecha de fin (con el formato 'YYYY-MM-DD')");

    PaqueteTuristico paqueteTuristico = new PaqueteTuristico(nombre, descripcion, precioTotal, fechaInicio, fechaFin, hospedaje, transporte, actividad);

    return paqueteTuristico;
}
public static Reserva Reserva(Cliente cliente, PaqueteTuristico paqueteTuristico)
{
    Console.WriteLine("\nCreacion Reserva:");
    int idReserva = IngresoDatos.Entero("Ingrese el id de la reserva.");
    int metodoPago = IngresoDatos.Entero("Seleccione uno de los siguientes metodos de pago: \n1 - Credito \n2 - Debito \n3 - Transferencia \n4 - Efectivo");
    
    Reserva reserva = new Reserva(idReserva, metodoPago);

    return reserva;
}
}