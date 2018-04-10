using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Vehiculo
    {
        String tipo, patente;

        int tarifa;
        public Vehiculo(String tipo1, int tarifa1, String patente1)
        {
            tipo = tipo1;
            tarifa = tarifa1;
            patente = patente1;
        }
        public string getTipo()
        {
            return tipo;
        }
    }
}
