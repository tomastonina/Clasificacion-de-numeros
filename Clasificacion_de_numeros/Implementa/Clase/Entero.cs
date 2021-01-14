using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Entero : Natural
    {
        public Entero(double num) : base(num) { }
        public double Valor
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public Entero() { }
        public bool esEntero()
        {
            return num >= 0 || num < 0;
        }
        public bool esCero()
        {
            return num == 0;
        }
        public bool esNegativo()
        {
            return num < 0;
        }
        public double resta(double num2)
        {
            return num - num2;
        }
    }
}
