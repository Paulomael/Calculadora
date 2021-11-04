using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora !");

            Operacao Op = new Operacao();
            List<double> numeros = new List<double>();

            string opcao;
            int n = 1;

            do
            {
                Console.WriteLine($"Informe {n} Numero");
                double numero1 = double.Parse(Console.ReadLine());
                numeros.Add(numero1);

                do
                {
                    Console.WriteLine("Deseja Informar outro numero ? sim ou nao");

                    opcao = Console.ReadLine();
                    if (opcao == "sim")
                    {
                        n += 1;
                    }
                    else if (opcao != "nao")
                    {
                        Console.WriteLine("Opção Invalida !");
                    }
                } while (opcao != "sim" && opcao != "nao");


            } while (opcao != "nao");
           
            Console.WriteLine("Digite : 1 - Somar \nDigite : 2 - Subtrair \nDigite : 3 - Multiplicar \nDigite : 4 - Dividir \n");

            string Escolha = Console.ReadLine();

            switch (Escolha)
            {
                case "1":
                    Op.Somar(numeros);
                    break;
                case "2":
                    Op.Subtrair(numeros);
                    break;
                case "3":
                    Op.Multiplicar(numeros);
                    break;
                case "4":
                    if (numeros.Count < 2)
                    {
                        Console.WriteLine("Não é Possivel Efetuar a Operação");
                    }
                    else
                    {
                        if (numeros.Count > 2)
                        {
                            Console.WriteLine($"So foi Possivel Realizar a operação com os numeros {numeros[0]} e {numeros[1]}");
                        }
                        Op.Dividir(numeros[0], numeros[1]);
                    }
                    break;
                default:
                    Console.WriteLine("Opção Incorreta");
                    break;
            }

            Console.ReadLine();
        }
    }
}
