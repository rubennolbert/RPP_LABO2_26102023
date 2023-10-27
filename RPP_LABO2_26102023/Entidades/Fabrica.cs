using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        private Fabrica()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public List<Vehiculo> Vehiculos
        {
            get { return vehiculos; }
        }

        public static Fabrica operator + (Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count() < fabrica.capacidad && !fabrica.vehiculos.Contains(vehiculo))
            {
                fabrica.vehiculos.Add(vehiculo);
                return fabrica;
            }
            return null;
        }

        public static Fabrica operator - (Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach(var v1 in fabrica.vehiculos)
            {
                if(v1 == vehiculo)
                {
                    fabrica.vehiculos.Remove(vehiculo);
                    return fabrica;
                    break;
                }            
            }
            return null;
        }
    }
}
