using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogarTenis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool humido = false, chuva = false, vento = false;
            if (args.Length >= 1)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "humido":
                            humido = true;
                            break;
                        case "chuva":
                            chuva = true;
                            break;
                        case "vento":
                            vento = true;
                            break;
                        default:
                            Console.WriteLine("ERRO, as opções possiveis são: humido chuva vento");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                    }
                }
            }

            if(!chuva && !vento || !vento && !humido)
            {
                Console.WriteLine("Vamos jogar tenis!");
            }
            else
            {
                Console.WriteLine("Nao ha jogo hoje");
            }
            Console.ReadKey();
        }
    }
}
