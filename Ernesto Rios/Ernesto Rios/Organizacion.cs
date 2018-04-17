using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Organizacion : Cliente
    {
        String permiso;

        public Organizacion(String nombre1, String rut1, String permiso1)
            : base(nombre1, rut1)
        {
            permiso = permiso1;
        }
        public bool revisarPermiso(Vehiculo vehiculo)
        {
            if (vehiculo.getTipo() == "Maquinaria pesada")
            {
                Console.WriteLine("Organizacion no puede arrendar maquinaria pesada");
                return false;
            }
            if (permiso == vehiculo.getTipo())
            {
                return true;
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
            if (num <= 35)
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
