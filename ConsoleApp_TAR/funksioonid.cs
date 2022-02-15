using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TAR
{
    class funksioonid
    {
        public static int Korrustamine(int arv1, int arv2)
        {
            int kor = arv1 * arv2;
            return kor;
        }
        /*
        public static int[] Arvud_Massiviisse(int n,bool t_f)
        {
            Random rnd = new Random();
            int[] arvud = new int[r];
            for (int i = 0; i < n; i++)
            {
                if (t_f)
                {
                    Console.WriteLine("Sisesta arv");
                    string input = Console.ReadLine();
                    int output;
                    if (int.TryParse(input, out output))
                    {
                        arvud[i] = output;
                    }

                }
                else
                {
                    arvud[i] = rnd.Next(1, 100);
                }
            }
            return arvud;
        }
        public static void Arvud_Ekraanile(Array massiiv)
        {
            int k, max = 0;
            
            foreach (var n in massiiv)
            {
                k = n.ToString().Length;
                if (k>max)
                {
                    max = k;
                }
            }
            max++;
            foreach (var n in massiiv)
            {
                Console.Write("{0,1}",n, max);
            }
        }

        */
        public static int Leidmine_Kesk(int n)
        {
            double [] arvud = new double[n];
            double kesk = 0;
            for (int i = 0; i < n; i++)
            {
                arvud[i] = int.Parse(Console.ReadLine());
            }
            foreach (double item in arvud)
            {
                kesk += item;
            }
            kesk = Math.Round( kesk/n,4);
            return (int)kesk;
        }
        public static int Kassi_kalc(int a1, int a2)
        {
            Console.WriteLine("Sisestage 1 arv:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisestage 2 arv:");
            int b = int.Parse(Console.ReadLine());

        }
        
	public static float Calculator()
        {
			double a;
			double b;
			double res;
			char z;
			Console.WriteLine("Write first number");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Write second number");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter an action");
			znak = Convert.ToChar(Console.ReadLine());
			if (z == '+')
			{
				res = a + b;
			}
			if (z=='-')
            {
				res = a - b;
			}
			if (z == '*')
            {
				res = a * b;
            }
			if (z == '/')
            {
				res = a / b;
            }
            Console.WriteLine()
        
    }
}
