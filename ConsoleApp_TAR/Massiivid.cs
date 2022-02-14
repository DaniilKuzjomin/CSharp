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
            //int q = 10;
            //int korrutis = funksioonid.Korrustamine(q, 5);
            //Console.WriteLine(korrutis);


            //Array arvud;
            //arvud = funksioonid.Arvud_Massiviisse(10, false);
            //funksioonid.Arvud_Ekraanile(arvud);

            /*
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
            

            int[] arvud = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sisesta arv (5 korda)");
                arvud[i] = int.Parse(Console.ReadLine());
            }
            int summa = 0;
            int korrutis = 1;

            foreach (var arv in arvud)
            {
                summa += arv;
                korrutis *= arv; 
            }
            Console.WriteLine($"Summa -> {summa} ");
            Console.WriteLine($"Korrutis -> {korrutis} ");
            Console.WriteLine($"Keskmine -> {summa/arvud.Length,4} ");
            




            
            Console.WriteLine("Osta Elevant ara!!");
            string loom = Console.ReadLine();
            if (loom.ToUpper() != "elevant")
            {
                Console.WriteLine("Koik utlevad ostan " + loom + " aga sa osta!");
                Console.ReadLine();
            }
            Console.WriteLine("Elevant on sinu!");
            Console.ReadLine();
            

            
            Random rand = new Random();
            int i = rand.Next(10);
            int count = 1;
            Console.WriteLine("Arvuti arvas ara arvu vahemikus 0 kuni 9, proovige ara arvata!");
            Console.WriteLine("Sisetage arv:");
            int k = Convert.ToInt32(Console.ReadLine());
            while (count <= 3)
            {
                if (i == k)
                {
                    Console.WriteLine("Teie vastus on oige! Arvuti arvutas " + k + "!");
                    break;
                }
                else
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Sinu vastus on vale!. Arvuti arvutas " + i + "!");
                        break;
                    }
                    Console.WriteLine("Ei, see ei ole arv " + k + "! Katse " + count + ":");
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
            
            
            for (int b = 1; b < 11; b++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write((b * j).ToString() + "\t");
                }
                Console.WriteLine();
            

            Array massiiv4;
            massiiv4 = funksioonid.Arvud_Massiviisse(4, true);

                Array.Sort(massiiv4); // 1,2...
                int D = 0;
                for (int t = 0; t < massiiv4.Length; t++)
                {
                    D =(int)(D + massiiv4 * Math.Pow(10, t));
                }
                Console.WriteLine(D);
             */


            funksioonid.Leidmine_Kesk(5);
            Console.ReadKey();
            
            
        }
    }
}