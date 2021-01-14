using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    public class Fraccionario
    {
        private double entero;
        private Entero numerador = new Entero();
        private Entero denominador = new Entero();
        private double cociente, decimall;

        public Fraccionario(Entero numerador, Entero denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }
        public Fraccionario() { }

        public double NUMERADOR
        {
            get { return this.numerador.Valor; }
            set { this.numerador.Valor = value; }
        }

        public double DENOMINADOR
        {
            get { return this.denominador.Valor; }
            set { this.denominador.Valor = value; }
        }

        public bool denominadorEsCero()
        {
            return denominador.esCero();
        }

        public bool esExacto()
        {
            if (!denominadorEsCero())
            {
                cociente = (double)numerador.Valor / denominador.Valor;
                entero = (int)cociente;
                decimall = cociente - (double)entero;
                string coma = decimall.ToString();
                string[] x = coma.Split(',');
                long DespComa = Int64.Parse(x[1]);
                int cont = 1;
                while (DespComa / 10 > 0)
                {
                    DespComa = DespComa / 10;
                    cont++;
                }
                if (cont < 5)
                {
                    return true;
                }
            }
            return false;
        }

        public bool esPeriodico()
        {
            return !denominadorEsCero() && !esExacto();
        }

        public bool esPeriodicoMixto()
        {
            if (esPeriodico())
            {
                cociente = (double)numerador.Valor / denominador.Valor;
                entero = (int)cociente;
                decimall = cociente - (double)entero;
                int[] contenedor = new int[16];
                for (int i = 0; i < contenedor.Length; i++)
                {
                    decimall *= 10;
                    int nue = (int)decimall;
                    contenedor[i] = (int)decimall;
                    decimall = decimall - nue;
                }
                int contPur = 0;
                int contmix = 0;
                for (int u = 0; u < contenedor.Length; u++)
                {
                    int a = contenedor[u];
                    int c = u + 1;
                    for (int y = c; y < contenedor.Length; y++)
                    {
                        int b = contenedor[y];
                        if (a == b)
                            contPur++;
                        else
                            contmix++;
                    }
                    if (contPur >= 2)
                        break;
                    if (contmix >= 2)
                        break;
                }
                if (contmix >= 2)
                    return true;
            }
            return false;
        }
        public bool esPeriodicoPuro()
        {
            if (esPeriodico())
            {
                cociente = (double)numerador.Valor / denominador.Valor;
                entero = (int)cociente;
                decimall = cociente - (double)entero;
                int[] contenedor = new int[16];
                for (int i = 0; i < contenedor.Length; i++)
                {
                    decimall *= 10;
                    int nue = (int)decimall;
                    contenedor[i] = (int)decimall;
                    decimall = decimall - nue;
                }
                int contPur = 0;
                int contmix = 0;
                for (int u = 0; u < contenedor.Length; u++)
                {
                    int a = contenedor[u];
                    int c = u + 1;
                    for (int y = c; y < contenedor.Length; y++)
                    {
                        int b = contenedor[y];
                        if (a == b)
                            contPur++;
                        else
                            contmix++;
                    }
                    if (contPur >= 2)
                        break;
                    if (contmix >= 2)
                        break;
                }
                if (contPur >= 2)
                    return true;
            }
            return false;
        }
    }
}

