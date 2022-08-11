using System;
using System.Text;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void TipoGuid()
        {
            //-------------GUID-----------------
            // Globally Unique IDentifier - using System;
            // Gera um código (HASH) de 36 caracteres (128 bits)

            var id = Guid.NewGuid(); // Criando um novo GUID

            id.ToString(); // Convertendo GUID para String

            id = new Guid("cc31b098-5b9e-4696-a5e8-bdb96debf7df"); // Atribuindo um GUID já existente

            id.ToString().Substring(0, 8); // Pegando apenas os primeiros 8 caracteres

            if (id == Guid.NewGuid()) // Comparação quase impossível de se acontecer

                id = new Guid(); // retorna 00000000-0000-0000-0000-0000000000000

        }

        public void Concatenacao()
        {
            // ----------------- Concatenação ( + )-----------------

            var price = 10.2;

            var texto = "O preço do produto é" + price + "apenas na promoção"; // + faz um ToString na variavel e adiciona ela à string (concatenação)
        }

        public void MetodoStringFormat()
        {
            // ---------------- String.Format ----------------
            // usado também para formatar datas, moedas etc.
            var texto = string.Format("O preço do produto é {0} apenas na promoção", price); //as variaveis depois da virgula são adicionadas conforme o indice ({0}, {1}...) começando do zero
        }

        public void InterpolacaoECaracatresDeEscape()
        {
            //---------------- $ @ ---------------------------
            // Ao adicionar $, tudo que estiver entre chaves {} é convertido para uma string e é concatenado
            // podendo também fazer lógicas e condições
            // O @ permite criar strings com mais de 1 linha ignorando caracteres de escape (\n)
            var price = 10.9;
            var texto = $@"O preço do produto
            é {price} ou {10 + 10} apenas na promoção";
        }

        public void ComparacaoDeTextos()
        {
            var texto = "Testando";

            // CompareTo() compara se duas strings são exatamente iguais, retornando um INTEIRO (0 = igual) (1 = diferente)
            var retornaInt = texto.CompareTo("Testando");

            texto = "esse é um texto de teste";
            // Contains() verifica se o texto informado pode ser encontrado em uma string
            var retornaBool = texto.Contains("teste");
        }
        public void ModosDeComparacaoStringComparison()
        {
            var texto = "Teste";

            // StringComparison é o modo de comparação
            // - OrdinalIgnoreCase irá ignorar o case sensitive das strings
            var retornaBool = texto.Contains("teste", StringComparison.OrdinalIgnoreCase);
        }
        public void StartsWithEEndsWith()
        {
            // Começa com / Termina com

            var texto = "Esse texto é um teste";
            var retornaTrue = texto.StartsWith("Este");
            var retornaFalse = texto.EndsWith("Este");
        }

        public void ComparacaoEquals()
        {
            // Equals é encontrado em varios outros objetos
            var numero = 30;
            var texto = "Este texto é um teste";
            var retornaTrue = texto.Equals("Este");
            retornaTrue = numero.Equals(30);
        }

        public void Indice()
        {
            // Encontrado em todos os tipos de lista
            // Todos os indices começam com 0
            // String = lista de char

            var texto = "Este texto é um teste";

            //IndexOf retorna a primeira posição do objeto informado dentro da lista
            var retornaInt11 = texto.IndexOf("é");

            //LastIndexOf retorna a primeira posição do objeto informado dentro da lista
            var retornaInt19 = texto.LastIndexOf("s");
        }

        public void MetodosUteisString()
        {
            var texto = "Este texto é um teste";

            // Converte todos os textos para minusculos
            texto.ToLower();

            // Converte todos os textos para maiusculos
            texto.ToUpper();

            // Insere um texto na string a partir do index informado
            texto.Insert(11, "aqui");

            // Remove caracteres da string, informando o indice inicial e final da remoção
            // Length é uma propriedade, ele retorna a quantidade de caraceres
            texto.Remove(0, texto.Length); // limpa toda a string

            // Troca os caracteres de uma string em todos os caracteres informados
            // Caso ele não encontre a palavra, a string fica da mesma forma
            texto.Replace("Este", "isto");

            // Divide o texto com base no caractere informado
            // criando um array de strings
            texto.Split(",");

            // Com base nos indices, ele ira pegar os caracteres entre os indice
            texto.Substring(0, 5); // pega os 5 primeiros caracteres

            // Remove apenas os espaços em branco no inicio e no final
            texto.Trim();
        }

        public void CriandoComStringBuilder()
        {
            // using System.Text;
            //Cria strings de forma dinâmica

            var texto = new StringBuilder();
        }
    }
}
