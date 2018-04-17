using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Accesorio
    {
        String tipo;
        int precio;
        public Accesorio(String tipo1, int precio1)
        {
            tipo = tipo1;
            precio = precio1;
        }
        public string getTipo()
        {
            return tipo;
        }
        public void saludar()
        {
            Console.WriteLine(tipo + " tiene un precio de " + precio);
        }
    }
}
