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
            const int CommandRateRubToUsd = 1;
            const int CommandRateRubToJpy = 2;
            const int CommandRateUsdToRub = 3;
            const int CommandRateUsdToJpy = 4;
            const int CommandRateJpyToUsd = 5;
            const int CommandRateJpyToRub = 6;
            const int CommandIsExit = 7;

            float userRub;
            float userJpy;
            float userUsd;

            float rateRubToUsd = 0.01f;
            float rateRubToJpy = 2.4f;

            float rateUsdToRub = 63.2f;
            float rateUsdToJpy = 148.3f;

            float rateJpyToUsd = 0.0005f;
            float rateJpyToRub = 0.4f;

            int coutCurrency;
            int userInput;
            bool userCanConvert = true;
            bool isExit = false;


            Console.Write("Сколько у вас рублей: ");
            userRub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас Долларов: ");
            userUsd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Сколько у вас Юаней: ");
            userJpy = Convert.ToSingle(Console.ReadLine());

            while (isExit == false)
            {
                Console.WriteLine("Для того чтобы обенять одну валюту на другую нажмите:" +
                    $"\n{CommandRateRubToUsd} - Рубли в доллары" +
                    $"\n{CommandRateRubToJpy} - Рубли в юани" +
                    $"\n{CommandRateUsdToRub} - Доллары в рубли" +
                    $"\n{CommandRateUsdToJpy} - Доллары в юани" +
                    $"\n{CommandRateJpyToRub} - Юани в рубли" +
                    $"\n{CommandRateJpyToUsd} - Юани в даллары" +
                    $"\n{CommandIsExit} - Выйти из программы");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userCanConvert == true)
                {
                    switch (userInput)
                    {
                        case CommandRateRubToUsd:
                            Console.WriteLine("Введите колличество валюты которое хотите перевести");
                            coutCurrency = Convert.ToInt32(Console.ReadLine());

                            if (coutCurrency <= userRub)
                            {
                                userUsd += coutCurrency * rateRubToUsd;
                                userRub -= coutCurrency;
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода");
                            }
                            break;
                        case CommandRateRubToJpy:
                            Console.WriteLine("Введите колличество валюты которое хотите перевести");
                            coutCurrency = Convert.ToInt32(Console.ReadLine());

                            if (coutCurrency <= userRub)
                            {
                                userJpy += coutCurrency * rateRubToJpy;
                                userRub -= coutCurrency;
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода");
                            }
                            break;
                        case CommandRateUsdToRub:
                            Console.WriteLine("Введите колличество валюты которое хотите перевести");
                            coutCurrency = Convert.ToInt32(Console.ReadLine());

                            if (coutCurrency <= userUsd)
                            {
                                userRub += coutCurrency * rateUsdToRub;
                                userUsd -= coutCurrency;
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода");
                            }
                            break;
                        case CommandRateUsdToJpy:
                            Console.WriteLine("Введите колличество валюты которое хотите перевести");
                            coutCurrency = Convert.ToInt32(Console.ReadLine());

                            if (coutCurrency <= userUsd)
                            {
                                userJpy += coutCurrency * rateUsdToJpy;
                                userUsd -= coutCurrency;
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода");
                            }
                            break;
                        case CommandRateJpyToUsd:
                            Console.WriteLine("Введите колличество валюты которое хотите перевести");
                            coutCurrency = Convert.ToInt32(Console.ReadLine());

                            if (coutCurrency <= userJpy)
                            {
                                userRub += coutCurrency * rateJpyToRub;
                                userJpy -= coutCurrency;
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода");
                            }
                            break;
                        case CommandRateJpyToRub:
                            Console.WriteLine("Введите колличество валюты которое хотите перевести");
                            coutCurrency = Convert.ToInt32(Console.ReadLine());

                            if (coutCurrency <= userJpy)
                            {
                                userUsd += coutCurrency * rateJpyToUsd;
                                userJpy -= coutCurrency;
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно средств для перевода");
                            }
                            break;
                        case CommandIsExit:
                            isExit = true;
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
}
