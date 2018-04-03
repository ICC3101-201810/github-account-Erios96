using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Otros: Cliente
    {
        String tipo, permiso;

        public Otros(String nombre1, String rut1, String tipo1, String permiso1)
            : base(nombre1, rut1)
        {
            tipo = tipo1;
            permiso = permiso1;
        }
    }
}
