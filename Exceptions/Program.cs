using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomizarExcessoes();
        }

        static void ObtendoInformacoesDoErro()
        {
            var array = new int[3];
            //Opções das exceções
            try
            {
                for (var index = 0; index < 10; index++)
                {
                    //IndexOutOfRangeException - Tipo da excessão
                    Console.WriteLine(array[index]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        static void TratandoErros()
        {
            var array = new int[3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    //IndexOutOfRangeException
                    Console.WriteLine(array[index]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Data);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        static void DisparandoErros()
        {
            string? texto = null;

            if (string.IsNullOrEmpty(texto))
            {
                //throw = arremessar / jogar (disparar)
                // A mensagem escrita chega na excessão com Message
                // Exception é a excessão genérica
                throw new Exception("O texto não pode ser vazio");
                throw new ArgumentNullException("Excessão especifica para argumentos nulos");
            }
        }

        static void CustomizarExcessoes()
        {
            try
            {
                string? texto = null;

                if (string.IsNullOrEmpty(texto))
                {
                    throw new MinhaException(DateTime.Now);
                }
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.QuandoAconteceu);
            }
        }

        static void Finally()
        {

            //Finally sempre será executado, independente se deu certo ou não

            try
            {
                string? texto = null;

                if (string.IsNullOrEmpty(texto))
                {
                    throw new MinhaException(DateTime.Now);
                }
            }
            catch (MinhaException ex)
            {
                Console.WriteLine(ex.QuandoAconteceu);
            }
            finally
            {
                Console.WriteLine("Acabou o programa!");
            }
        }

        public class MinhaException : Exception
        {
            public DateTime QuandoAconteceu { get; set; }

            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
        }
    }
}
