using Arrays.Models;
using Arrays.Services;
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // INDICES: Inicia-se com 0 -> Total de indices = Tamanho do array - 1

            var MeuArray = new int[5]; // tamanho definido
            int[] MeuOutroArray; // sem tamanho definido

            var MeuOutroOutroArray = new int[5] { 1, 2, 3, 4, 5 };// criando e já preenchendo as posições
            MeuOutroOutroArray[0] = 12;

            var ArrayDoOutro = new Teste[2] { new Teste(), new Teste() }; // array com preenchimento de um tipo próprio criado pelo usuário
            ArrayDoOutro[0] = new Teste(); // setando o valor de outra forma

            Console.WriteLine(MeuArray[0]);
            Console.WriteLine(MeuArray[1]);
            Console.WriteLine(MeuArray[2]);
            Console.WriteLine(MeuArray[3]);
            Console.WriteLine(MeuArray[4]);

            ArrayDoOutro[0].id = 1; // Setando um valor na propriedade do indice informado

            ArrayService.PercorrendoArraysComForeach();
       }
    }
}
