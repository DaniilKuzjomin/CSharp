﻿using System;
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
        
	public static float kassi_calc()
        {
			double a;
			double b;
			double res;
			char z;
			Console.WriteLine("Sisetage esimene arv");
			a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Sisetage kahe arv");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Sisetage mark");
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
	    string k = nurr
	    ress = res * k
	    return ress
            Console.WriteLine(ress);
		
        public static float stars()
	{
		Console.WriteLine("Sisetage kui palju tarni Sa tahad -> ");
		a = Convert.ToInt(Console.ReadLine());
		tarn = a * "*"
		Console.WriteLine(tarn);
	}
    }
}
