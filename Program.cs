using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sun = "Солнце";
            string rain = "Дождь";
            string wind = "Ветер";
            string snow = "Снег";
            string cold = "Холод";
            string hot = "Жара";
            m: Console.WriteLine("Привет. Я могу перевести 6 слов о погоде с русского на английский язык. Введите слово о погоде на русском языке");
            string userword = Console.ReadLine();
            if  (sun == userword)
            {
                Console.WriteLine("Sun", userword);
                goto m;
            }
            else if (rain ==userword)
            {
                Console.WriteLine("Rain", userword);
                goto m;
            }
            else if (wind == userword)
            {
                Console.WriteLine("Wind", userword);
                goto m;
            }
            else if (snow == userword)
            {
                Console.WriteLine("Snow", userword);
                goto m;
            }
            else if (cold == userword)
            {
                Console.WriteLine("Cold", userword);
                goto m;
            }
            else if (hot == userword)
            {
                Console.WriteLine("Hot", userword);
                goto m;
            }
            else
            {
                Console.WriteLine("Извините, в базе нет такого слова");
                goto m;

            }
           
            
        }
    }
}
