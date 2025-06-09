namespace Proyecto
{
    public class Validaciones
    {
        public static void CadenaEspMin (string nombreAtributo, int minimo, string mensaje)
        {
            if((nombreAtributo.Length <=minimo) || nombreAtributo.Contains(" "))
            {
                new ArgumentException(mensaje);
            }
        }
        public static void CadenaMin(string nombreAtributo, int minimo, string mensaje)
        {
            if((nombreAtributo.Length <=minimo))
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
            if(!(nombreAtributo >= minimo && nombreAtributo <= maximo))
            {
                throw new ArgumentException(mensaje);
            }
        }
        public static void FloatBetween(float nombreAtributo, int minimo, int maximo, string mensaje)
        {
            if(!(nombreAtributo >= minimo && nombreAtributo <= maximo))
            {
                throw new ArgumentException(mensaje);
            }
        }
        public static DateOnly Fecha (string nombreAtributo)
        {
            if(!DateOnly.TryParse(nombreAtributo, out DateOnly resultado))
            {
                throw new ArgumentException("La fecha debe poseer el formato 'YYYY-MM-DD'");
            }
            return resultado;
        }
        public static TimeSpan Hora (string nombreAtributo)
        {
            if(!TimeSpan.TryParse(nombreAtributo, out TimeSpan resultado))
            {
                throw new ArgumentException("El formato de la hora debe ser '00:00'");
            }
            return resultado;
        }
        public static void CorreoElectronico(string nombreAtributo)
        {
            string mensaje = "El mail debe poseer el siguiente formato: minimo tres caracteres antes del '@', minimo tres caracteres entre el '@' y el punto, y tres caracteres a continuacion del '.' por ejemplo: 'hola@gmail.com";

            if(nombreAtributo.LastIndexOf("@") < nombreAtributo.LastIndexOf("."))
            {
                if (!((nombreAtributo.LastIndexOf("@") >= 3) && ((nombreAtributo.Substring(nombreAtributo.LastIndexOf("@"), nombreAtributo.LastIndexOf(".") - nombreAtributo.LastIndexOf("@"))).Length >= 4) && ((nombreAtributo.Substring(nombreAtributo.LastIndexOf("."))).Length == 4)))
                {
                    throw new ArgumentException(mensaje); 
                }
            }else
                throw new ArgumentException(mensaje);   
        }
        
    }
}