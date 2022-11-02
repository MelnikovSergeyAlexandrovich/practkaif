using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practkaif
{
    internal class Program
    {


        static void Main(string[] args)
        {
            zamkaif zam1 = new zamkaif();
            zam1.name = "   День Рождения!";
            zam1.desc = "   Купить ламборигини урус";
            zam1.time = new DateTime(2022, 12, 27);

            zamkaif zam2 = new zamkaif();
            zam2.name = "   Chill out";
            zam2.desc = "   Почиллить дома и посмотреть кино";
            zam2.time = new DateTime(2022, 12, 23);

            zamkaif zam3 = new zamkaif();
            zam3.name = "   Сгонять в шарагу";
            zam3.desc = "   Погонять в баскет на физре и ждать зачеты";
            zam3.time = new DateTime(2022, 12, 23);

            zamkaif zam4 = new zamkaif();
            zam4.name = "   Сдать сессию";
            zam4.desc = "   Получить 3 автомата и ждать др";
            zam4.time = new DateTime(2022, 12, 24);

            zamkaif zam5 = new zamkaif();
            zam5.name = "   NEW YEAR HOHOHO";
            zam5.desc = "   Максимально кайфануть и отлично встретить новый год";
            zam5.time = new DateTime(2022, 12, 31);

            List<zamkaif> zams = new List<zamkaif> { zam1, zam2, zam3, zam4, zam5 };

            DateTime data = new DateTime(2022, 12, 24);

            Console.WriteLine(" Нажмите любую клавишу, чтобы войти в ежеднивник" +
                "\n Нажмите Q, чтобы выйти из ежедневника");
                

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Q)
            {
                Console.Clear();
            }

            int pos = 2;


            while (key.Key != ConsoleKey.Q)
            {
                Console.WriteLine(data);

                List<zamkaif> sortedZam = zams.Where(datacheck => datacheck.time.Date == data.Date).ToList();

                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if ((sortedZam.Count + 2) == pos)
                    {
                        pos = sortedZam.Count + 1;
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {

                    pos--;
                    if (pos == 1)
                    {
                        pos = 2;
                    }
                }

                Console.Clear();

                Console.WriteLine(data.Date.ToString("dd.MM.yyyy"));

                Console.WriteLine("|=================================|");

                if (sortedZam.Count == 0)
                {
                    Console.WriteLine("   Сегодня без дел !");
                }

                foreach (var zam in sortedZam)
                {
                    Console.WriteLine(zam.name);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        int bems = pos - 2;
                        text(sortedZam[bems]);
                    }

                    
                }
                

                Console.SetCursorPosition(0, pos);

                if (key.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("->");
                }

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.RightArrow)
                {
                    pos = 2;
                    data = data.AddDays(1);
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    pos = 2;
                    data = data.AddDays(-1);
                }

            }
        }
            static void text(zamkaif f1)
            {
                Console.WriteLine(f1.name);
                Console.WriteLine("|================================================|");
                Console.WriteLine("Дата: " + f1.time.ToString("dd.MM.yyyy"));
                Console.WriteLine("Планы на данную дату: " + f1.desc);
            }
            









            
            }
        }
    


