using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TAR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double hind = 15;
            string p_tuup = "tais";
            Console.WriteLine("Tere tulemast! Mis on sinu nimi?");
            Console.Title="Pealkiri";
            string nimi = Console.ReadLine();
            char[] tahed = nimi.ToCharArray(); //juku -> ["j","u","k","u"]
            int i = 0; // тип данных / название переменной / чему равно
            nimi = "";

            foreach (var t in tahed)
            {
                if (i==0)
                {
                    nimi += t.ToString().ToUpper();


                }
                else
                {
                    nimi += t.ToString().ToLower();
                }
                i++;
            }


            Console.WriteLine("Tere {0}", nimi);

            if (nimi.ToUpper()=="JUKU" || nimi.ToLower()=="daniil")
            {

                Console.WriteLine($"Tule külla! {nimi}, kas tahad kinno?");
                string vastus = Console.ReadLine();
                if (vastus.ToUpper()=="JAH" || vastus.ToLower()=="yes")
                {
                    Console.WriteLine("Kui vana sa oled?");
                    int vanus = int.Parse(Console.ReadLine()); // Parse - делает целое число
                    if (vanus <=0 || vanus > 109)
                    {
                        Console.WriteLine("Sa oled surnud");
                    }
                    else
                    {
                        if (vanus > 0 && vanus <= 6)
                        {
                            hind -= hind;
                            p_tuup = "tasuta";
                        }
                        else if (vanus > 6 && vanus <= 14)
                        {
                            hind -= hind * 0.5;
                            p_tuup = "laste";
                        }
                        else if (vanus > 15 && vanus <= 65)
                        {
                            hind -= hind * 0.2;
                            p_tuup = "tais";
                        }
                        else if (vanus > 65 && vanus <= 108)
                        {
                            hind -= hind * 0.6;
                            p_tuup = "soodus";
                        }
                        Console.WriteLine("{0}, sul on {2} pilet, vaja maksta {1}",nimi,hind,p_tuup);
                    }
                }
                else
                {
                    Console.WriteLine("Ei taha?!");
                }
            }
            else
            {
                Console.WriteLine("Täna ma olen hõivatud! :(");
            }
            */

            /*
            Console.WriteLine("Tere! Palun sisestage teie nimed");
            string nimi1 = Console.ReadLine();
            string nimi2 = Console.ReadLine();
            if ((nimi1=="Mihhail" && nimi2=="Marco")||(nimi2=="Marco" && nimi1=="Mihhail") || (nimi1 =="Marco" && nimi2 =="Edgar") || (nimi2 =="Edgar" && nimi1 =="Marco")|| (nimi1 == "Aleksander K" && nimi2 == "Aleksander A") || (nimi2 == "Aleksander A" && nimi1 == "Aleksander K")||(nimi1 == "Daniil" && nimi2 == "Aleksander A") || (nimi2 == "Aleksander A" && nimi1 == "Daniil")|| (nimi1 == "Elena" && nimi2 == "Alina") || (nimi2 == "Elena" && nimi1 == "Alina")|| (nimi1 == "Ervin" && nimi2 == "Vlademir") || (nimi2 == "Ervin" && nimi1 == "Vlademir"))
            {
                Console.WriteLine("Sa oled pinginaabrid");
            }
            else
            {
                Console.WriteLine("Teil ei ole pinginaabri :)");
            }
            

            Console.WriteLine("Sisestage põranda pindala!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a != 0 && b != 0) || (a<0 && b<0))
            {
                int S = a * b;
                Console.WriteLine(S+"m2");
                Console.WriteLine();
                Console.WriteLine("Kas sa tahad remondi teha?");
                string c = Console.ReadLine();
                if (c.ToUpper()=="JAH" || c.ToLower()=="jah")
                {
                    Console.WriteLine("Kui palju maksab 1 m2?");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kui palju maksab põranda vahetus?");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sul on vaja maksta -"+d+e+"€");
                }
                else
                {
                    Console.WriteLine(":(");
                }
            }
            else
            {
                Console.WriteLine("Viga");
            }
            */

            Console.WriteLine("Sinu pikkus?");
            double height = double.Parse(Console.ReadLine());
            if (height < 170 && height > 0)
            {
                Console.WriteLine("Vaike");
            }
            else if (height > 185 && height < 300)
            {
                Console.WriteLine("Suur");
            }
            else if (height >= 170 && height <= 185)
            {
                Console.WriteLine("Keskmine");
            }
            else
            {
                Console.WriteLine("Viga");
            }

            Console.WriteLine("Sinu pikkus?");
            double height1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sinu sugu?");
            string sugu = Console.ReadLine();
            if (height1 < 170 && height1 > 0)
            {
                Console.WriteLine("Vaike");
            }
            else if (height1 > 185 && height1 < 300)
            {
                Console.WriteLine("Suur");
            }
            else if (height1 >= 170 && height1 <= 185)
            {
                Console.WriteLine("Keskmine");
            }
            else
            {
                Console.WriteLine("Viga");
            }





            Console.ReadKey();
        }
    }
}
