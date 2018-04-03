using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Arriendo
    {
        Cliente cliente1;
        Vehiculo vehiculo1;
        Accesorio[] accesorios;
        String tiempo;

        public Arriendo(Cliente newCliente, Vehiculo newVehiculo, Accesorio[] accesorio1, String tiempo1)
        {
            cliente1 = newCliente;
            vehiculo1 = newVehiculo;
            accesorios = accesorio1;
            tiempo = tiempo1;
        }
    }
}
