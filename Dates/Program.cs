using System;
using System.Globalization;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAtual = new DateTime(); // 01/01/0001 00:00:00
            dataAtual = DateTime.Now; // Pega da data atual
            var dataInformada = new DateTime(1999, 2, 7); // informando uma data fixa (ano, mes, dia)

            void FormatandoData()
            {
                // formatando a data da maneira que desejar
                var dataFormatada = String.Format("{0}/{1}/{2}", dataAtual.Year, dataAtual.Month, dataAtual.Day);

                // FORMATAÇÕES
                // yy = 22
                // yyy = 2022
                // MM = 07
                // MMM = jul
                // MMMM = julho
                // dd - 01
                // ddd - sáb
                // dddd - sábado
                // hh = Hora
                // mm - Minuto
                // ss - Segundo
                // ff - fração de segundo
                // zz - -03
                // zzz - -03:00

                // FORMATAÇÕES PADRÃO
                // :d - 01/08/2022
                // :D - sábado, 30 de julho de 2022
                // :f - segunda-feira, 1 de agosto de 2022 19:40
                // :F - segunda-feira, 1 de agosto de 2022 19:52:22
                // :g - 01/08/2022 19:40
                // :G - 01/08/2022 19:52:50
                // :M - 30 de julho
                // :m - 30 de julho
                // :r - Mon, 01 Aug 2022 19:41:39 GMT (Padrão sistema/JavaScript/ RFC1123 Pattern)
                // :s - 2022-08-01T19:43:09 (Sortable / JSON / NoSQL - Mongo)
                // :t - 19:50
                // :T - 19:53:46
                // :u - 2022-08-01 19:43:29Z (Universal)
                // :y - junho de 2022
                dataFormatada = String.Format("{0:Y}", dataAtual);
                dataFormatada = DateTime.Now.ToString("d");
            }

            void AdicionandoValoresAsDatas()
            {
                var data = DateTime.Now;
                data.AddDays(1);
                data.AddYears(-1);
                data.AddMonths(2 + 2);
                data.AddHours(1);
                data.AddMinutes(1);
                data.AddMilliseconds(1);
                data.AddTicks(1);
            }

            void ComparandoDatas()
            {
                // COMPARANDO DATAS
                // Ele compara toda a estrutura do objeto (dd/mm/yyyy hh:mm:ss:mmm z)
                var data = DateTime.Now.Date;
                if (data == DateTime.Now)
                    // Não tem como comparar devido aos milessegundos
                    if (data.Date == DateTime.Now.Date)
                        // Comparamos apenas a data
                        return;
            }

            void GlobalizacaoLocalizacao()
            {
                var pt = new System.Globalization.CultureInfo("pt-PT");
                var br = new System.Globalization.CultureInfo("pt-BR");
                var en = new System.Globalization.CultureInfo("en-US");
                var de = new System.Globalization.CultureInfo("de-DE");

                DateTime.Now.ToString("d", de);

                var atual = CultureInfo.CurrentCulture; //Pega a cultura da máquina que está rodando a aplicação

                var dateTime = DateTime.UtcNow; //Utiliza a data/hora universal ao invés do .Now que pega a hora da máquina

                dateTime.ToLocalTime(); // converte a data para o formato local

                var timezone =
                TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"); //Traz o timezone informado

                var horaAustralia =
                TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone); // Traz a data/hora da região informada com base no UTC

                horaAustralia =
                TimeZoneInfo.ConvertTimeToUtc(dateTime, timezone); // Convert a data/hora local para UTC

                // Mostra todas as timeszones disponveis na máquina
                var timezones = TimeZoneInfo.GetSystemTimeZones();
                foreach (var timez in timezones)
                {
                    Console.WriteLine(timez.Id);
                    Console.WriteLine(timez);
                    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timez));
                    Console.WriteLine("-----------");
                }
            }

            void TimeSpan()
            {
                // TIME-SPAN
                var timeSpan = new TimeSpan();
                timeSpan = new TimeSpan(1); // 00:00:00.0000001 fração de segundo
                timeSpan = new TimeSpan(5, 12, 8); // 05:12:08 // hh:mm:ss
                timeSpan = new TimeSpan(3, 5, 50, 10); // 3.05:50:10 // dd.hh:mm:ss
                timeSpan = new TimeSpan(15, 12, 55, 8, 100); // 15.12:55:08 // dd.hh:mm:ss.ms

                var props = timeSpan.Days;
                props = timeSpan.Hours;
                props = timeSpan.Minutes;
                props = timeSpan.Milliseconds;
                long tick = timeSpan.Ticks;
                double totalDays = timeSpan.TotalDays;

                var novoTimeSpan = new TimeSpan();
                var calculoHoras = novoTimeSpan - timeSpan;

                timeSpan.Add(new TimeSpan(12, 0, 0));
            }

            void MetodosMaisUtilizados()
            {
                //MÉTODOS MAIS UTILIZADOS
                var dias = DateTime.DaysInMonth(2020, 2); // (ano, mes) Quantos dias tem esse mês

                // verifica se é dia da semana ou não
                IsWeekend(DateTime.Now.DayOfWeek);

                bool IsWeekend(DayOfWeek today)
                {
                    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
                }

                // Verifica se está ou não no horário de verão
                DateTime.Now.IsDaylightSavingTime();
            }
        }
    }

}
