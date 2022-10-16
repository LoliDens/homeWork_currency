using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_currency
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float userRub;
            float userJpy;
            float userUsd;

            float rubInUsd = 0.01f;
            float rubInJpy = 2.4f;

            float usdInRub = 63.2f;
            float usdInJpy = 148.3f;

            float jpyInUsd = 0.0005f;
            float jpyInRub = 0.4f;

            int coutCurrency;
            int userInput;

            bool userCanConvert = true;


            Console.Write("Сколько у вас рублей: ");
            userRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас Долларов: ");
            userUsd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас Юаней: ");
            userJpy = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Для того чтобы обенять одну валюту на другую нажмите:" +
                "\n1 - Рубли в доллары" +
                "\n2 - Рубли в юани" +
                "\n3 - Доллары в рубли" +
                "\n4 - Доллары в юани" +
                "\n5 - Юани в рубли" +
                "\n6 - Юани в даллары");
            userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество волюты которое хотитеперевести");
            coutCurrency = Convert.ToInt32(Console.ReadLine());
            switch (coutCurrency) 
            {
                case 1:
                case 2:
                    if (coutCurrency > userRub) 
                    {
                        Console.WriteLine("Недостаточно золота");
                        userCanConvert = false;
                    }
                    break;

                case 3:
                case 4:
                    if (coutCurrency > userUsd)
                    {
                        Console.WriteLine("Недостаточно золота");
                        userCanConvert = false;
                    }
                    break;
                case 5:
                case 6:
                    if (coutCurrency > userUsd)
                    {
                        Console.WriteLine("Недостаточно золота");
                        userCanConvert = false;
                    }
                    break;
            }
            if (userCanConvert == true)
            {
                switch (userInput)
                {
                    case 1:
                        userUsd += coutCurrency * rubInUsd;
                        break;
                    case 2:
                        userJpy += coutCurrency * rubInJpy;
                        break;
                    case 3:
                        userRub += coutCurrency * usdInRub;
                        break;
                    case 4:
                        userJpy += coutCurrency * usdInJpy;
                        break;
                    case 5:
                        userRub += coutCurrency * jpyInRub;
                        break;
                    case 6:
                        userUsd += coutCurrency * jpyInUsd;
                        break;
                }
            }

            Console.WriteLine("Рублей:" + userRub);
            Console.WriteLine("Долларов:" + userUsd);
            Console.WriteLine("Юаней:" + userJpy);
            Console.ReadKey();



        }
    }
}
