using System;
using System.Globalization;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECIMAL É MAIS PRECISO PORÉM O DOUBLE ATENDE NA MAIORIA DOS CASOS
            decimal valorDecimal = 10.25m;
            double valorDouble = 10.25;

            Arredondamento();
        }

        static void FormatacaoMoedas()
        {
            decimal valorDecimal = 10563.25m;

            var culture = CultureInfo.CurrentCulture;
            var japao = CultureInfo.CreateSpecificCulture("ja-JP");

            // FORMATADORES
            // G - Padrão - 10,25 - 10.25
            // C - R$ 10,25 - ¥10
            // E04 - Caculadora - 1,0250E+001
            // N - 10.563,25
            // P - 1.056.325,00%
            // F - 10563,250

            Console.WriteLine(valorDecimal.ToString("P", culture));
        }

        static void Arredondamento()
        {
            decimal valorDecimal = 10.9m;

            // Arredonda para a média (<= .50 = menos / > .50 = mais )
            var resultado = Math.Round(valorDecimal);

            // Ceiling = Telhado -> Arredonda sempre para cima (+)
            resultado = Math.Ceiling(valorDecimal);

            // Floor = Chão -> Arredonda sempre para baixo (-)
            resultado = Math.Floor(valorDecimal);

            Console.WriteLine(resultado);
        }
    }
}
