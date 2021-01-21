using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> AdYas = new MyDictionary<string, int>();
            AdYas.Add("ali",35);
            AdYas.Add("veli", 25);
            AdYas.Add("okkes",45);

            Console.WriteLine("Eleman Sayısı:"+AdYas.Length);
            Console.WriteLine("Anahtarlar");
            foreach (var item in AdYas.Key)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Degerler");
            foreach (var item in AdYas.Value)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
        }
    }
}
