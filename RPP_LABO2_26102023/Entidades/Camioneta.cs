using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        protected override string Tipo
        {
            get { return "Camioneta."; }
        }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
            this.esAWD = true;
        }

        protected override string GetInfo()//////
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GetInfo());
            sb.AppendLine($"con cabina: [Simple {this.cabinaSimple} o Doble {this.cabinaSimple}]");
            return sb.ToString();
        }
    }
}
