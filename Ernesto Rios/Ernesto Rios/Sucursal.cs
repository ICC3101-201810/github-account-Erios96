using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    class Sucursal
    {
        public List<Vehiculo> vehiculos = new List<Vehiculo>();
        String nombre, direccion;
        List<Arriendo> arriendos = new List<Arriendo>();

        public Sucursal(String nombre1, String direccion1)
        {
            nombre = nombre1;
            direccion = direccion1;
        }

        public void AgregarVehiculo(Vehiculo vehiculo) => vehiculos.Add(vehiculo);
        public void NuevoArriendo(Arriendo arriendo) => arriendos.Add(arriendo);
        public string getNombre()
        {
            return nombre;
        }

        public Vehiculo getVehiculo(String patente)
        {
            Vehiculo vehiculo = vehiculos.Where(x=>x.getPatente()==patente).ToList().First();
            return vehiculo;
        }
    }
}
