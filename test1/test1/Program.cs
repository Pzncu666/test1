using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("╔════════╗" + "\r\n" + "║      DMA       ║" + "\r\n" + "╚════════╝");

            double rate = 0.2771;

            Console.WriteLine("請輸入日幣:");

            string input = Console.ReadLine();

            double total = int.Parse(input) * rate;

            Console.WriteLine("換算為台幣:{0}", total);

            Console.ReadLine();
        }
    }
}
