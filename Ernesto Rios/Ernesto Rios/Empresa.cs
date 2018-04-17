using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Empresa: Cliente
    {
        String permiso;
        public Empresa(String nombre1, String rut1, String permiso1)
            : base(nombre1, rut1)
        {
            permiso = permiso1;
        }
        public bool revisarPermiso(Vehiculo vehiculo)
        {
            if( permiso == vehiculo.getTipo())
            {
                return true;
            }
            if(vehiculo.getTipo() == "Maquinaria pesada")
            {
                Random prob = new Random();
                int num = prob.Next(0, 100);
                if (num <= 63)
                {
                    permiso = "Maquinaria pesada";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool pedirPermisoBus()
        {
            Random prob = new Random();
            int num = prob.Next(0, 100);
            if (num <= 80)
            {
                permiso = "Bus";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
