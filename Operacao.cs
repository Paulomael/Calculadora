using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{

    public class Operacao
    {
        
        public void  Somar(List<double> x)
        {
            double resultado = 0;
            foreach (var item in x)
            {
                resultado += item;
            }

            Console.WriteLine(resultado);
        }




        public void Subtrair(List<double> x)
        {
            double resultado = 0;
            foreach (var item in x)
            {
                resultado -= item;
            }

            Console.WriteLine(resultado);
        }


        public void Multiplicar(List<double> x)
        {
            double resultado = x[0];
            

            for (int i = 1; i < x.Count; i++)
            {
                resultado *= x[i];
            }

            Console.WriteLine(resultado);
        }


        public void Dividir(double x,double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Impossivel Dividir Por Zero");
            }
            else
            {
                Console.WriteLine($"O Resultado é {x / y}");
            }                                                                       
        }
    }
}





