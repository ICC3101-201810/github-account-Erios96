using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Seleccione una opcion; ");
                Console.WriteLine("1. Crear sucursal");
                Console.WriteLine("2. Crear vehiculo");
                Console.WriteLine("3. Agregar vehiculo");
                Console.WriteLine("4. Cerrar");
                String decision = Console.ReadLine();

                if(decision == "1")
                {
                    Console.WriteLine("Nombre de la sucursal: ");
                    String nombre1 = Console.ReadLine();
                    Console.WriteLine("Direccion de la sucursal");
                    String direccion1 = Console.ReadLine();
                    Sucursal sucursal1 = new Sucursal(nombre1, direccion1);
                }
                if(decision == "2")
                {
                    Console.WriteLine("Tipo de vehiculo: ");
                    String tipo1 = Console.ReadLine();
                    Console.WriteLine("Tarifa de arriendo: ");
                    int t1 = Convert.ToInt32(Console.ReadLine());
                    Vehiculo vehiculo1 = new Vehiculo(tipo1, t1);
                }
            }
        }
    }
}
