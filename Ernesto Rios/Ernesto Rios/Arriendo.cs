using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Arriendo
    {
        Cliente tipo;
        Vehiculo vehiculo1;
        List<Accesorio> accesorios;
        String tiempo;

        public Arriendo(Cliente tipo1 , Vehiculo newVehiculo, List<Accesorio> accesorio1, String tiempo1)
        {
            tipo = tipo1;
            vehiculo1 = newVehiculo;
            accesorios = accesorio1;
            tiempo = tiempo1;
        }
        public Vehiculo GetVehiculo()
        {
            return vehiculo1;
        }
    }
}
