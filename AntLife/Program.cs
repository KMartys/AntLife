using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntLifePCL.Test;

namespace AntLife
{
    class Program
    {
        private enum stanPoloczenia { poloczony = 10000, rozloczono = 2, laczenie = 3 }
        static void Main(string[] args)
        {
            Dictionary<int, TestClass> a = new Dictionary<int, TestClass>();
            a.Add(1, new TestClass { TestId = 21, TestClassName = "a1111dfs" });
            a.Add(2, new TestClass { TestId = 2123, TestClassName = "adfzxs" });
            a.Add(3, new TestClass { TestId = 2231, TestClassName = "a4zxdfs" });
            a.Add(5, new TestClass { TestId = 21, TestClassName = "adfs" });

            foreach (var i in a)
            {
                Console.WriteLine(i.Key + " " + i.Value.TestId + " " + i.Value.TestClassName);
            }

            Console.WriteLine(a[1].TestClassName);
            Console.WriteLine(a.ElementAt(0).Value.TestClassName);

            Console.ReadLine();

            KeyValuePair<int, TestClass> b = new KeyValuePair<int, TestClass>(1, new TestClass { TestId = 1, TestClassName = "asd" });

            KeyValuePair<int, TestClass> c = new KeyValuePair<int, TestClass>(1, new TestClass { TestId = 2, TestClassName = "as2134d" });
            List<KeyValuePair<int, TestClass>> litOfKvp = new List<KeyValuePair<int, TestClass>>();

            litOfKvp.Add(b);
            litOfKvp.Add(c);
            foreach (var i in litOfKvp)
            {
                Console.WriteLine(i.Key + " " + i.Value.TestId + " " + i.Value.TestClassName);
            }
            Console.ReadLine();

            stanPoloczenia wifi;

            wifi = stanPoloczenia.poloczony;
            Console.WriteLine(wifi + " " + (int)wifi);

            wifi = stanPoloczenia.rozloczono;
            Console.WriteLine(wifi + " " + (int)wifi);

            wifi = stanPoloczenia.laczenie;
            Console.WriteLine(wifi + " " + (int)wifi);

            wifi = (stanPoloczenia)2;
            Console.WriteLine(wifi + " " + (int)wifi);


            switch (wifi)
            {
                case stanPoloczenia.poloczony:
                    break;
                case stanPoloczenia.rozloczono:
                    break;
                case stanPoloczenia.laczenie:
                    break;
                default:
                    break;
            }

            Console.ReadLine();

        }
    }
}
