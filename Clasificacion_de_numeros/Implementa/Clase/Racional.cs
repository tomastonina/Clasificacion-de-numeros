using System;
using System.Linq;

namespace Numeros
{
    public class Racional
    {
        private int entero;
        private double decimall, cociente;
        public Racional() { }
        public Racional(Fraccionario fraccionario)
        {
            this.cociente = (double)fraccionario.NUMERADOR / fraccionario.DENOMINADOR;
        }
        public Racional(double cociente)
        {
            this.cociente = cociente;
        }
        public bool esFraccionario()
        {
            return cociente.ToString().Contains(',');
        }
        public bool esEntero()
        {
            return !esFraccionario();
        }
        public bool esIrracional()
        {
            if (esFraccionario())
            {
                int cont = 1;
                entero = (int)cociente;
                decimall = cociente - (double)entero;
                string coma = decimall.ToString();
                string[] x = coma.Split(',');
                long DespComa = Int64.Parse(x[1]);
                while (DespComa / 10 > 0)
                {
                    DespComa = DespComa / 10;
                    cont++;
                }
                int contPur = 0;
                int[] contenedor = new int[cont];
                for (int i = 0; i < cont; i++)
                {
                    decimall *= 10;
                    int nue = (int)decimall;
                    contenedor[i] = (int)decimall;
                    decimall = decimall - nue;
                }
                for (int u = 0; u < contenedor.Length; u++)
                {
                    int a = contenedor[u];
                    int c = u + 1;
                    for (int y = c; y < contenedor.Length; y++)
                    {
                        if (contenedor[0] != contenedor[1])
                        {
                            if (a == contenedor[y])
                            {
                                contPur++;
                            }
                        }
                        int b = contenedor[y];
                        if (a == contenedor[y])
                            contPur++;
                    }
                    if (contPur >= 2)
                        break;
                    else
                        break;
                }
                if (cont >= 14)
                {
                    int ir = 0;
                    for (int l = 0; l < contenedor.Length; l++)
                    {
                        if (contenedor[2] == contenedor[l])
                            ir++;
                    }
                    if (contenedor[0] != contenedor[1] && contenedor[1] != contenedor[2])
                        return true;
                }
            }
            return false;
        }
        public bool esRacional()
        {
            return (!esIrracional() && esFraccionario()) || esEntero();
        }
    }
}