using System;
using System.Collections.Generic;
using System.Text;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dizim1 = new Dictionary<int, string>();

            dizim1.Add(1, "a");

            MyDictionary<int, string> dizim = new MyDictionary<int, string>();

            dizim.Add(1, "Nuri");
            dizim.Add(2, "Bilge");
            dizim.Add(3, "Ceylan");
            dizim.Add(4, "İzel");
            dizim.Add(5, "Çelik");
            dizim.Add(6, "Ercan");
            dizim.Add(7, "Mazhar");
            dizim.Add(8, "Fuat");
            dizim.Add(9, "Özkan");

            Console.Write("Eleman Sayısı: ");
            dizim.Count();
            dizim.ShowList();








        }
    }
}
