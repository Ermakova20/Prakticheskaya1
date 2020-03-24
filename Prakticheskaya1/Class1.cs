using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticheskaya1
{
    class Class1
    {
        
        public List<Obyv> a = new List<Obyv> { };
        public void Vivod()
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("Производитель: {0}", a[i].proizvoditel);
                Console.WriteLine("Размер: {0}", a[i].razmer);
                Console.WriteLine("Цена: {0}", a[i].cena);
            }
        }

        public void Zapis()
        {
            Console.WriteLine("Введите количество записей");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Введите производителя, размер, цену");
                a.Add(new Obyv()
                {
                    proizvoditel = Console.ReadLine(),
                    razmer = Convert.ToInt32(Console.ReadLine()),
                    cena = Convert.ToDouble(Console.ReadLine()),
                });
            }
        }
    }
}
