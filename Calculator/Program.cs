using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static List<float> ObtendoValores()
        {
            System.Console.WriteLine("Informe os valores (Aperte ESC para realizar a operação)");
            System.Console.WriteLine("-------------------------------------------------------");

            var valores = new List<float>();

            do
            {
                var valor = Console.ReadLine();
                for (int i = 0; i <= 0; i++)
                {
                    valores.Add(float.Parse(valor));
                }

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            return valores;
        }
        static void RetornoResultado(string operacao, float resultado)
        {
            Console.Clear();
            Console.WriteLine($"O resultado da {operacao} é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Soma()
        {
            Console.Clear();
            var valores = ObtendoValores();
            float resultado = 0;

            foreach (var numero in valores)
            {
                resultado += numero;
            }
            RetornoResultado("soma", resultado);
        }
        static void Subtracao()
        {
            Console.Clear();
            var valores = ObtendoValores();
            float resultado = 0;

            foreach (var numero in valores)
            {
                resultado -= numero;
            }
            RetornoResultado("subtracao", resultado);
        }
        static void Multiplicacao()
        {
            Console.Clear();
            var valores = ObtendoValores();
            float resultado = 0;

            foreach (var numero in valores)
            {
                resultado *= numero;
            }
            RetornoResultado("multiplicação", resultado);
        }
        static void Divisao()
        {
            Console.Clear();
            var valores = ObtendoValores();
            float resultado = 0;

            foreach (var numero in valores)
            {
                resultado /= numero;
            }
            RetornoResultado("divisao", resultado);
        }
    }
}
