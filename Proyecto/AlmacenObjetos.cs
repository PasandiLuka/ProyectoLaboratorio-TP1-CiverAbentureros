using System.Linq;
using ConsoleTables;
namespace Proyecto;

public class AlmacenObjetos
{
    List<Transporte> transportes = new List<Transporte>();
    List<Actividad> actividades = new List<Actividad>();
    List<Hospedaje> hospedajes = new List<Hospedaje>();
    List<Cliente> clientes = new List<Cliente>();

    public void AgregarTransporte(Transporte transporte) => transportes.Add(transporte);
    public void AgregarActividad(Actividad actividad) => actividades.Add(actividad);
    public void AgregarHospedaje(Hospedaje hospedaje) => hospedajes.Add(hospedaje);
    public void AgregarCliente(Cliente cliente) => clientes.Add(cliente);

    public void MostrarTransportes()
    {
        var table = new ConsoleTable("Tipo", "Empresa", "NumeroAsiento", "HorarioSalida");
        foreach (Transporte t in transportes)
        {
            table.AddRow(t.GetTipo(), t.GetEmpresa(), t.GetNumeroAsiento(), t.GetHorarioSalida());
        }
        table.Write();
    }
    public void MostrarActividades()
    {
        for(int i = 1; i <= actividades.Count; i++)
        {
            Console.WriteLine($"\nActividad n°{i}:");
            actividades[i-1].MostrarDatos();
        }
    }
    public void MostrarHospedajes()
    {
        for(int i = 1; i <= hospedajes.Count; i++)
        {
            Console.WriteLine($"\nHospedaje n°{i}:");
            hospedajes[i-1].MostrarDatos();
        }
    }
    public void MostrarClientes()
    {
        for(int i = 1; i <= actividades.Count; i++)
        {
            Console.WriteLine($"\nCliente n°{i}:");
            clientes[i-1].MostrarDatos();
        }
    }
}