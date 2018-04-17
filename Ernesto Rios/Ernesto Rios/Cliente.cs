using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Cliente
    {
        String nombre, rut;
        public Cliente(String nombre1, String rut1)
        {
            nombre = nombre1;
            rut = rut1;
        }
        public string getRut()
        {
            return rut;
        }
    }
}
