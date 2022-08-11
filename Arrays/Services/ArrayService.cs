using Arrays.Models;
using Arrays.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Services
{
    public class ArrayService
    {
        public static void PercorrendoArraysComFor()
        {
            var MeuArray = new int[5] { 1, 2, 3, 4, 5 };

            for (var index = 0; index < MeuArray.Length; index++) // MeuArray.Length; - Tamanho quantidade de itens do array for para percorrer o array
                Console.WriteLine(MeuArray[index]);
        }

        public static void PercorrendoArraysComForeach()
        {
            var MeuArray = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var item in MeuArray)
                Console.WriteLine(item);

            var funcionarios = new Teste[2];
            funcionarios[0] = new Teste() { id = 222 };
            funcionarios[1] = new Teste() { id = 333 };

            foreach (var funcionario in funcionarios)
                Console.WriteLine(funcionario.id);
        }

        public static void AtribuindoValoresDeOutrosArrays()
        {
            var MeuArray = new int[5] { 1, 2, 3, 4, 5 };
            var MeuSegundorray = new int[5] { 5, 4, 3, 2, 1 };

            var ArrayCopia = MeuArray; //Por ser um tipo de referência, tudo o que for alterado no MeuArray será transferido para o ArrayCopia

            MeuArray[0] = MeuSegundorray[0]; // Transferindo valores de um array para outro

            MeuArray.CopyTo(MeuSegundorray, 0);  // Copiando todos os elementos para o outro a partir do indece 0

            MeuArray = (int[])MeuSegundorray.Clone(); // Clonando um array para o outro. Aqui foi necessário fazer uma conversão Implicita para o tipo int. É necessário que os array tenham o mesmo tamanho
        }
    }
}
