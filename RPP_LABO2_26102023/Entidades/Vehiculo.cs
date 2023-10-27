using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EPropulsion { Combustion, Hibrida, Electrica}


        protected bool esAWD;
        protected Guid numeroDeChasis;
        private EPropulsion propulsion;

        public EPropulsion Propulsion { get{ return propulsion; } }
        protected abstract string Tipo { get; }

        protected Vehiculo (EPropulsion propulsion)
        {
            this.esAWD = false;
            this.numeroDeChasis = Guid.NewGuid();
            this.propulsion = propulsion;
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD) : this(propulsion)
        {
            this.esAWD = esAWD;
        }

        protected virtual string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Tipo} con propulsion a {this.propulsion}, es AWD: {this.esAWD}, numero de chasis: {this.numeroDeChasis}");
            return sb.ToString();
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return (v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"4x4: {this.esAWD}");
            sb.AppendLine($"numero de chasis: {this.numeroDeChasis}");
            sb.AppendLine($"Propulsion. {this.propulsion}");

            return sb.ToString();
        }
    }
}