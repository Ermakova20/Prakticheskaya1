using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticheskaya1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();
            for (; ; )
            {
                Console.WriteLine("Выберите пункт ");
                Console.WriteLine("1. Записать в список ");
                Console.WriteLine("2. Вывести список ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        a.Zapis();
                        break;
                    case 2:
                        a.Vivod();
                        break;
                }
            }
        }
    }
}
