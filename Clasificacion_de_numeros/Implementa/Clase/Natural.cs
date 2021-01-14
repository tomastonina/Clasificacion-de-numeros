using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Natural
    {
        public int i, a;
        public double num;
        public Natural(double num)
        {
            this.num = num;
        }
        public Natural() { }
        public double NUM
        {
            get { return this.num; }
            set { this.num = value; }
        }
        public bool esNatural()
        {
            return num > 0;
        }
        public bool esUno()
        {
            return esNatural() == true && num == 1;
        }
        public bool esPrimo()
        {
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    a++;
            }
            if (a == 2)
            {
                return esNatural() == true;
            }
            else
            {
                return false;
            }
        }
        public bool esCompuesto()
        {
            return esNatural() == true && num > 1 && esPrimo() == false;
        }
        public double suma(double num2)
        {
            return num + num2;
        }
        public double multiplicar(double num2)
        {
            return num * num2;
        }
    }
}