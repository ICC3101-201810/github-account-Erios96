﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ernesto_Rios
{
    public class Persona : Cliente
    {
        String licencia;

        public Persona(String nombre1, String rut1, String licencia1)
            : base(nombre1, rut1)
        {
            licencia = licencia1;
        }
        public bool revisarPermiso(Vehiculo vehiculo)
        {
            if (vehiculo.getTipo() == "Bus")
            {
                Console.WriteLine("Las personas no pueden arrendar buses");
                return false;
            }
            if (licencia == vehiculo.getTipo())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
