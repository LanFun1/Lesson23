using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            float rub = 2250f;
            float usd = 700f;
            float eur = 437f;
            Console.WriteLine($"Баланс:\nrub: {rub}\nusd: {usd}\neur: {eur}");
            string codeWord = "";
            Console.WriteLine("\nЕсли, после операции вы хотите закончить работать с валютами, введите exit. Для продолжения работы, можете ввести любое другое слово.\n");
            while (codeWord != "exit")
            {
                Console.WriteLine("Введите валюту, которую хотите конвертировать.(пример: rub, usd, eur)");
                string valueStart = Console.ReadLine();
                Console.WriteLine("Введите валюту, в которую хотите конвертировать.(пример: rub, usd, eur)");
                string valueFinish = Console.ReadLine();
                Console.WriteLine("Сколько вы хотите сконвертировать?");
                float convertibleMoney = Convert.ToInt32(Console.ReadLine());
                if (valueStart == "rub" && convertibleMoney <= rub)
                {
                    if (valueFinish == "usd")
                    {
                        float rubUsd = 70.74f;
                        usd += convertibleMoney / rubUsd;
                        rub -= convertibleMoney;
                    }
                    else if (valueFinish == "eur")
                    {
                        float rubEur = 79.90f;
                        eur += convertibleMoney / rubEur;
                        rub -= convertibleMoney;
                    }
                    else
                    {
                        return;
                    }
                }
                if (valueStart == "usd" && convertibleMoney <= usd)
                {
                    if (valueFinish == "rub")
                    {
                        float usdRub = 0.014f;
                        rub += convertibleMoney / usdRub;
                        usd -= convertibleMoney;
                    }
                    else if (valueFinish == "eur")
                    {
                        float usdEur = 1.13f;
                        eur += convertibleMoney / usdEur;
                        usd -= convertibleMoney;
                    }
                    else
                    {
                        return;
                    }
                }
                if (valueStart == "eur" && convertibleMoney <= eur)
                {
                    if (valueFinish == "rub")
                    {
                        float eurRub = 0.012f;
                        rub += convertibleMoney / eurRub;
                        eur -= convertibleMoney;
                    }
                    else if (valueFinish == "usd")
                    {
                        float eurUsd = 0.89f;
                        usd += convertibleMoney / eurUsd;
                        eur -= convertibleMoney;
                    }
                    else
                    {
                        return;
                    }
                }
                Console.WriteLine($"Баланс:\nrub: {rub}\nusd: {usd}\neur: {eur}");
                Console.WriteLine("\nВведите кодовое слово.\n");
                Console.ReadLine();
            }
            
            Console.ReadKey();
        }
    }
}
