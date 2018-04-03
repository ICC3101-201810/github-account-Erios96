using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    class Sucursal
    {
        List<Vehiculo> vehiculos;
        String nombre, direccion;
        List<Arriendo> arriendos;

        public Sucursal(String nombre1, String direccion1)
        {
            nombre = nombre1;
            direccion = direccion1;
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            List<Arriendo> arriendos = new List<Arriendo>();
        }

        public void AgregarVehiculo(Vehiculo vehiculo) => vehiculos.Add(vehiculo);
        public void NuevoArriendo(Arriendo arriendo) => arriendos.Add(arriendo);
    }
}
