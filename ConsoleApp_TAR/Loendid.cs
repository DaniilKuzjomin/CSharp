using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TAR
{
    class ulesanned
    {
        static void Main(string[] args)
        {
            /*
            List<int> alguses = new List<int>();
            List<int> lopus = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                alguses.Add(int.Parse(Console.ReadLine()));
            }
            int a1 = alguses[0];
            int an = alguses[alguses.Count - 1];
            alguses.Insert(0, an)
            alguses.Add









            
            List<int> numbrid = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                numbrid.Add(rnd.Next(0, 10));
            }
            foreach (int number in numbrid)
            {
                Console.WriteLine();
            }
            

            LinkedList<int> alguses = new LinkedList<int>();
            for (int i = 0; i < 5; i++)
            {
                alguses.AddLast(int.Parse(Console.ReadLine()));
            }
            LinkedList<int>.Enumerator ahel1 = alguses.GetEnumerator();
            while (ahel1.MoveNext())
            {
                Console.WriteLine(ahel1.Current);
            }
            int j = 0;
            foreach (int item in alguses)
            {
                if (j==0)
                {
                    alguses.RemoveFirst();
                    int a1 = alguses.First.Value;
                    alguses.AddFirst(a1 + alguses.Last.Value);

                }
                else if (i == alguses.Count-1)
                {
                    alguses.RemoveLast();
                    int a1 = alguses.Last.Value;
                    alguses.AddLast(a1 + alguses.First.Value);
                }
                else
                {
                    alguses.
                }
                j++;
            }
            */







            int[] arvud = new int[10] { 9, 5, 10, 2, 1, 4, 56, 77, 23, 7 };
            List<int> koik_arvud = new List<int>(arvud);
            List<int> paaris = new List<int>();
            List<int> paaritu = new List<int>();
            foreach (int arv in koik_arvud)
            {
                if (arv % 2==0)
                {
                    paaris.Add(arv);
                }
                else
                {
                    paaritu.Add(arv);
                }
                Console.WriteLine(paaris);
                Console.WriteLine(paaritu);
            }












            Console.ReadKey();
        }
    }
}
