using Proyecto;

/* 
    A la hora de hacer la creacion de los objetos se requiere seguir un orden, siendo este en siguiente:

    Para la creacion de "Paquete Turistico" se requiere crear primero una "Actividad", un "Transporte" y un "Hospedaje".

    Para la creacion de una "Reserva" se requiere crear primero un "Cliente" y un "Paquete Turistico".

    Utilice los metodos Cliente(), Transporte(), Actividad(), Hospedaje(), Paquete(), Reserva() (Ubicados en la clase "CreacionObjeto"), para poder realizar el ingreso de datos y la creacion del objeto ejecutandolo de la siguiente manera:
    
 */

Transporte transporte1 = CreacionObjetos.Transporte();
Hospedaje hospedaje1 = CreacionObjetos.Hospedaje();
Cliente cliente1 = CreacionObjetos.Cliente();
Actividad actividad1 = CreacionObjetos.Actividad();
PaqueteTuristico paqueteTuristico1 = CreacionObjetos.Paquete(hospedaje1, transporte1, actividad1);
Reserva reserva1 = CreacionObjetos.Reserva(cliente1, paqueteTuristico1);

/* 
    Tambien, cada objeto tiene el metodo "MostrarDatos" el cual mostrara los ATRIBUTOS (no otros objetos asociados) del objeto.
 */

 reserva1.cliente.MostrarDatos();