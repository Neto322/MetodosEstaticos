using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoEstatico
{ 
    class Matematicas
    {
        public static double Potencia(double numeroBase, double exponente)
        {
            double resultado;
            resultado = 1;
            for (int cont=0 ; cont < exponente; cont++)
            {
                resultado = resultado *numeroBase;
            }
            return resultado;
        }
    }
}
