using Proyecto;
AlmacenObjetos almacenObjetos = new AlmacenObjetos();

//Creacion Transportes
                                    //Tipo (1 a 3), Empresa, HorarioSalida
Transporte transporte1 = new Transporte(1, "FlechaBus", "07:00");
almacenObjetos.AgregarTransporte(transporte1);
Transporte transporte2 = new Transporte(2, "Trenes Argentinos", "09:00");
almacenObjetos.AgregarTransporte(transporte2);
Transporte transporte3 = new Transporte(3, "Aereolineas Argentinas", "10:00");
almacenObjetos.AgregarTransporte(transporte3);
Transporte transporte4 = new Transporte(3, "Aereolineas Argentinas", "06:30");
almacenObjetos.AgregarTransporte(transporte4);

//Creacion Actividades
                                    //Tipo (1 a 3), Nombre, Descripcion, Duracion(enHoras), Opcionalidad, Lugar
Actividad actividad1 = new Actividad(1, "Actividad1", "Vale por una descripcion1", 2, 2, "Vale por un lugar1");
almacenObjetos.AgregarActividad(actividad1);
Actividad actividad2 = new Actividad(2, "Actividad2", "Vale por una descripcion2", 3, 1, "Vale por un lugar2");
almacenObjetos.AgregarActividad(actividad2);
Actividad actividad3 = new Actividad(3, "Actividad3", "Vale por una descripcion3", 4, 2, "Vale por un lugar3");
almacenObjetos.AgregarActividad(actividad3);

//Creacion Hospedajes
                                    //Tipo (1 a 3), Nombre, Direccion, CantidadEstrellas(1 a 5)
Hospedaje hospedaje1 = new Hospedaje(1 ,"Hospedaje1", "Vale por una direccion1", 3);
almacenObjetos.AgregarHospedaje(hospedaje1);
Hospedaje hospedaje2 = new Hospedaje(2 ,"Hospedaje2", "Vale por una direccion2", 4);
almacenObjetos.AgregarHospedaje(hospedaje2);
Hospedaje hospedaje3 = new Hospedaje(3 ,"Hospedaje3", "Vale por una direccion3", 5);
almacenObjetos.AgregarHospedaje(hospedaje3);

//Creacion Clientes
                                //DNI, NombreCompleto, Mail, Telefono, Nacionalidad, Nacimiento
Cliente cliente1 = new Cliente(12345678, "Juan Ignacio", "Juan@gmail.com", 541187654321, "Argentina", "2000-01-01");
almacenObjetos.AgregarCliente(cliente1);
Cliente cliente2 = new Cliente(99999999, "Roberto Lopez", "Roberto@gmail.com", 541112345678, "Argentina", "2000-01-01");
almacenObjetos.AgregarCliente(cliente2);
Cliente cliente3 = new Cliente(89898989, "Federico Hernandez", "Fede@gmail.com", 541122223333, "Argentina", "2000-01-01");
almacenObjetos.AgregarCliente(cliente3);


almacenObjetos.MostrarTransportes();
/* almacenObjetos.MostrarActividades();
almacenObjetos.MostrarHospedajes();
almacenObjetos.MostrarClientes(); */





/* 
    A la hora de hacer la creacion de los objetos se requiere seguir un orden, siendo este en siguiente:

    Para la creacion de "Paquete Turistico" se requiere crear primero una "Actividad", un "Transporte" y un "Hospedaje".

    Para la creacion de una "Reserva" se requiere crear primero un "Cliente" y un "Paquete Turistico".

    Utilice los metodos Cliente(), Transporte(), Actividad(), Hospedaje(), Paquete(), Reserva() (Ubicados en la clase "CreacionObjeto"), para poder realizar el ingreso de datos y la creacion del objeto ejecutandolo de la siguiente manera:
 */

/* Transporte transporte10 = CreacionObjetos.Transporte();
Hospedaje hospedaje10 = CreacionObjetos.Hospedaje();
Cliente cliente10 = CreacionObjetos.Cliente();
Actividad actividad10 = CreacionObjetos.Actividad();
PaqueteTuristico paqueteTuristico10 = CreacionObjetos.Paquete(hospedaje2, transporte2, actividad2);
Reserva reserva10 = CreacionObjetos.Reserva(cliente2, paqueteTuristico2); */

/* 
    Tambien, cada objeto tiene el metodo "MostrarDatos" el cual mostrara los ATRIBUTOS (no otros objetos asociados) del objeto.
 */

 /* reserva1.cliente.MostrarDatos(); */