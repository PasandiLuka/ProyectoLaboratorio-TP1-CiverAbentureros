namespace Proyecto
{
    public class Validaciones
    {
        public static void CadenaMin (string nombreAtributo, int minimo, string mensaje)
    {
        if((nombreAtributo.Length <=minimo) || nombreAtributo.Contains(" "))
        {
            new ArgumentException(mensaje);
        }
    }
    public static void Entero (int nombreAtributo)
    {
        if(nombreAtributo < 0)
        {
            new ArgumentException("El numero debe ser positivo");
        }
    }
    public static void EnteroBetween(int nombreAtributo, int minimo, int maximo, string mensaje)
    {
        if(!(nombreAtributo >=minimo && nombreAtributo <=maximo))
        {
            throw new ArgumentException(mensaje);
        }
    }//"El formato de las fechas es: 'YYYY-MM-DD'"
    /* public static void Date(string nombreAtributo, string mensaje)
    {
        List<string> numeros = new List<string>{};
        for(int i = 0; i <= 9; i++)
        {
            numeros.Add(Convert.ToString(i));   
        }
        
        if(nombreAtributo.Length == 10 && nombreAtributo.Contains("-"))
        {
            
        }else
        {
            throw new ArgumentException();
        }
    } */
    }
}