using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TAR
{
    class Massiivid
    {
        static void Main(string[] args)
        {
            /*
            Random rnd = new Random();
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 100);
            }
            foreach (int arv in arvud)
            {
                Console.Write($" {arv,4} ");
            }
            

            string[] nimed = new string[5] {"Anna","Olga","Mark","Timur","Jegor"} ;
            int a=0;
            do
            {
                Console.Write("Jr. number (Tavaline inimene) -> ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

            } while (a<1 || a>5);
            Console.WriteLine(nimed[a-1]);
            

            Random rnd = new Random();
            int N = rnd.Next(1, 100);
            int M = rnd.Next(1, 100);
            Console.WriteLine($"N = {N}");
            Console.WriteLine($"M = {M}");
            if (N>M)
            {
                int abi = N;
                N = M;
                M = abi;
            }
            int[] NM = new int[M-N+1];
            for (int j = N; j < M+1; j++)
            {
                NM[j-N] = j;
                Console.WriteLine(j*j);
            }
            */

            int[] arvud = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sisesta arv (5 korda)");
                arvud[i] = int.Parse(Console.ReadLine());
            }
            foreach (var arv in arvud)
            {
                Console.WriteLine($" {arv+4} ");
                Console.WriteLine($" {arv/arv} ");
                Console.WriteLine($" {arv*arv} ");
            }




            Console.ReadKey();
        }
    }
}
