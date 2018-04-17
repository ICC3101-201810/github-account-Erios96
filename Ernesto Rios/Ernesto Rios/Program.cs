using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    class Program
    {
        protected static void Main(string[] args)
        {
            List<Sucursal> Sucursales = new List<Sucursal>();
            List<Accesorio> Accesorios = new List<Accesorio>()
            {
                new Accesorio("GPS",1000),
                new Accesorio("Rueda de respuesto",2000),
                new Accesorio("Silla de niño",1500),
                new Accesorio("Bluetooth",500),
                new Accesorio("Cortinas",100)
            };
            List<Persona> Personas = new List<Persona>();
            List<Empresa> Empresas = new List<Empresa>();
            List<Organizacion> Organizaciones = new List<Organizacion>();
            List<Institucion> Instituciones = new List<Institucion>();

            for (; ; )
            {
                Console.WriteLine("Seleccione una opcion; ");
                Console.WriteLine("1. Crear sucursal");
                Console.WriteLine("2. Crear vehiculo");
                Console.WriteLine("3. Arrendar vehiculo");
                Console.WriteLine("4. Crear cliente");
                Console.WriteLine("5. Cerrar");
                String decision = Console.ReadLine();

                if(decision == "1")
                {
                    Console.WriteLine("Nombre de la sucursal: ");
                    String nombre1 = Console.ReadLine();
                    Console.WriteLine("Direccion de la sucursal");
                    String direccion1 = Console.ReadLine();
                    Sucursal sucursal1 = new Sucursal(nombre1, direccion1);
                    Sucursales.Add(sucursal1);
                }
                if(decision == "2")
                {
                    Console.WriteLine("Tipo de vehiculo: ");
                    String tipo1 = Console.ReadLine();
                    Console.WriteLine("Tarifa de arriendo: ");
                    int t1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Patente del vehiculo: ");
                    String patente1 = Console.ReadLine();
                    Vehiculo vehiculo1 = new Vehiculo(tipo1, t1, patente1);
                    Console.WriteLine("Nombre de la sucursal en que desea agregar el vehiculo: ");
                    String nombre1 = Console.ReadLine();
                    foreach (Sucursal sucursal1 in Sucursales)
                    {
                        if (sucursal1.getNombre() == nombre1)
                        {
                            sucursal1.AgregarVehiculo(vehiculo1);
                            break;
                        }
                    }
                    continue;
                }
                if(decision == "3")
                {
                    Console.WriteLine("Nombre de la sucursal en que desea arrendar");
                    String nSucursal = Console.ReadLine();
                    Console.WriteLine("Rut del cliente que desea arrendar");
                    String rutCliente = Console.ReadLine();
                    Console.WriteLine("Tipo de cliente");
                    String tipo3 = Console.ReadLine();
                    Sucursal sucursal = Sucursales.Where(x => x.getNombre() == nSucursal).ToList().First();
                    Console.WriteLine("Ingrese patente del vehiculo: ");
                    Vehiculo vehiculo1 = sucursal.getVehiculo(Console.ReadLine());
                    if(tipo3=="Persona")
                    {
                        Cliente cliente = Personas.Where(x => x.getRut() == rutCliente).ToList().First();
                    }
                    if (tipo3 == "Empresa")
                    {
                        Cliente cliente = Empresas.Where(x => x.getRut() == rutCliente).ToList().First();
                    }
                    if (tipo3 == "Organizacion")
                    {
                        Cliente cliente = Organizaciones.Where(x => x.getRut() == rutCliente).ToList().First();
                    }
                    if (tipo3 == "Institucion")
                    {
                        Cliente cliente = Instituciones.Where(x => x.getRut() == rutCliente).ToList().First();
                    }
                    continue;

                }
                if(decision == "4")
                {
                    Console.WriteLine("Nombre del cliente: ");
                    String nCliente = Console.ReadLine();
                    Console.WriteLine("Rut del cliente: ");
                    String rutCliente = Console.ReadLine();
                    Console.WriteLine("Permiso del cliente: ");//Se asume que los clientes solo pueden manejar un tipo de vehiculo
                    String permiso = Console.ReadLine();
                    Console.WriteLine("Tipo de cliente(Persona, Empresa, Organizacion o Institucion): ");
                    String tipo = Console.ReadLine();
                    if(tipo=="Persona")
                    {
                        Persona persona1 = new Persona(nCliente, rutCliente, permiso);
                        Personas.Add(persona1);
                    }
                    if(tipo=="Empresa")
                    {
                        Empresa empresa1 = new Empresa(nCliente, rutCliente, permiso);
                        Empresas.Add(empresa1);
                    }
                    if(tipo=="Organizacion")
                    {
                        Organizacion organizacion1 = new Organizacion(nCliente, rutCliente, permiso);
                        Organizaciones.Add(organizacion1);
                    }
                    if(tipo=="Institucion")
                    {
                        Institucion institucion1 = new Institucion(nCliente, rutCliente, permiso);
                        Instituciones.Add(institucion1);
                    }
                    else
                    {
                        Console.WriteLine("Se ingreso un tipo de cliente incorrecto");
                    }
                    continue;
                }
                if(decision == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error!!, Ingrese la opcion correctamente");
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
