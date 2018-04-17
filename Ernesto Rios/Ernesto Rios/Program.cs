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
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Seleccione una opcion; ");
                Console.WriteLine("1. Crear sucursal");
                Console.WriteLine("2. Crear vehiculo");
                Console.WriteLine("3. Arrendar vehiculo");
                Console.WriteLine("4. Crear cliente");
                Console.WriteLine("5. Recibir Vehiculo");
                Console.WriteLine("6. Cerrar");
                Console.BackgroundColor = ConsoleColor.Black;
                String decision = Console.ReadLine();

                if(decision == "1")
                {
                    Console.WriteLine("Nombre de la sucursal: ");
                    String nombre1 = Console.ReadLine();
                    Console.WriteLine("Direccion de la sucursal");
                    String direccion1 = Console.ReadLine();
                    Sucursal sucursal1 = new Sucursal(nombre1, direccion1);
                    Sucursales.Add(sucursal1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Sucursal Creada con exito");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                    continue;
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vehiculo creado con exito");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
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
                    List<Accesorio> arriendoAccesorio = new List<Accesorio>();
                    foreach(Accesorio accesorio1 in Accesorios)
                    {
                        accesorio1.saludar();
                    }
                    
                    while (true) 
                    {
                        Console.WriteLine("Seleccione el accesorios que desea ocupar");
                        String a = Console.ReadLine();
                        Accesorio ac = Accesorios.Where(x => x.getTipo() == a).ToList().First();
                        arriendoAccesorio.Add(ac);
                        Console.WriteLine("Desea agregar otro accesorio (si/no): ");
                        String opcion = Console.ReadLine();
                        if (opcion == "si")
                        {
                            continue;
                        }
                        if (opcion == "no")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la opcion correctamente");
                            continue;
                        }
                        
                    }
                    Console.WriteLine("Cual sera el tiempo de arriendo: ");
                    String tiempo = Console.ReadLine();
                    if (tipo3 == "Persona")
                    {
                        Persona persona = Personas.Where(x => x.getRut() == rutCliente).ToList().First();
                        if (persona.revisarPermiso(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No tiene permiso");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                            Console.Beep();
                            continue;
                        }
                        Cliente cliente = Personas.Where(x => x.getRut() == rutCliente).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente, vehiculo1, arriendoAccesorio, tiempo);
                        foreach (Sucursal s in Sucursales)
                        {
                            if (nSucursal == s.getNombre())
                            {
                                s.NuevoArriendo(arriendo1);
                                break;
                            }
                        }
                    }
                    if (tipo3 == "Empresa")
                    {
                        Empresa cosa = Empresas.Where(x => x.getRut() == rutCliente).ToList().First();
                        if (cosa.revisarPermiso(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No tiene permiso");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                            Console.Beep();
                            continue;
                        }
                        Cliente cliente = Empresas.Where(x => x.getRut() == rutCliente).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente, vehiculo1, arriendoAccesorio, tiempo);
                        foreach (Sucursal s in Sucursales)
                        {
                            if (nSucursal == s.getNombre())
                            {
                                s.NuevoArriendo(arriendo1);
                                break;
                            }
                        }
                    }
                    if (tipo3 == "Organizacion")
                    {
                        Organizacion cosa = Organizaciones.Where(x => x.getRut() == rutCliente).ToList().First();
                        if (cosa.revisarPermiso(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No tiene permiso");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                            Console.Beep();
                            continue;
                        }
                        Cliente cliente = Organizaciones.Where(x => x.getRut() == rutCliente).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente, vehiculo1, arriendoAccesorio, tiempo);
                        foreach (Sucursal s in Sucursales)
                        {
                            if (nSucursal == s.getNombre())
                            {
                                s.NuevoArriendo(arriendo1);
                                break;
                            }
                        }
                    }
                    if (tipo3 == "Institucion")
                    {
                        Institucion cosa = Instituciones.Where(x => x.getRut() == rutCliente).ToList().First();
                        if (cosa.revisarPermiso(vehiculo1))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Permiso en orden");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No tiene permiso");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Beep();
                            Console.Beep();
                            continue;
                        }
                        Cliente cliente = Instituciones.Where(x => x.getRut() == rutCliente).ToList().First();
                        Arriendo arriendo1 = new Arriendo(cliente, vehiculo1, arriendoAccesorio, tiempo);
                        foreach (Sucursal s in Sucursales)
                        {
                            if (nSucursal == s.getNombre())
                            {
                                s.NuevoArriendo(arriendo1);
                                break;
                            }
                        }
                    }
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Arriendo Exitoso!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cliente creado con exito");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                    continue;
                }
                if(decision == "5")
                {
                    Console.WriteLine("Ingrese el nombre la sucursal de recepcion: ");
                    String n = Console.ReadLine();
                    Console.WriteLine("Ingrese la patente del Vehiculo que desea recibir");
                    String p = Console.ReadLine();
                    foreach(Sucursal s in Sucursales)
                    {
                        if(s.getNombre()==n)
                        {
                            s.recibirAuto(p);
                            break;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Recepcion exitosa");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                    continue;

                }
                if (decision == "6")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gracias por utilizar el software de Ernesto Rios");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error!!, Ingrese la opcion correctamente");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Beep();
                    Console.Beep();
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
