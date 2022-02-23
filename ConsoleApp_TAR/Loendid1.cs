using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_TAR
{
    class Loendid
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> opilased = new Dictionary<int, string>(6); // Создание словаря
            opilased.Add(74589, "Mihhail");
            opilased.Add(74590, "Aleksandr");
            opilased.Add(74621, "Daniil");
            opilased.Add(74634, "Edgar");
            opilased.Add(74658, "Alina");
            opilased.Add(74670, "Mark");
            string nimi = opilased[74590]; // Приравниваем и выводим имя
            opilased[74590] = "Aleksander"; // Переименовываем по ключу
            foreach (KeyValuePair<int,string> keyValue in opilased)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }








            LinkedList<string> loetelu = new LinkedList<string>();
            loetelu.AddLast("Kass");
            loetelu.AddLast("Koer");
            loetelu.AddLast("Hunt");
            LinkedList<string>.Enumerator ahel = loetelu.GetEnumerator();
            while (ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            Console.ReadLine();



            List<Inimesed> inimesed = new List<Inimesed>(3);
            inimesed.Add(new Inimesed() { Nimi = "Mati" });
            inimesed.Add(new Inimesed() { Nimi = "Juku" });
            inimesed.Add(new Inimesed() { Nimi = "Kati" });
            foreach (Inimesed inimene in inimesed)
            {
                Console.Write(inimene.Nimi+", ");
            }

            List<int> numbrid = new List<int>();
            numbrid.Add(0);
            for (int i = 0; i < 9; i++)
            {
                numbrid.Add(i+1);
            }
            int n = numbrid.Count();
            foreach (int num in numbrid)
            {
                Console.WriteLine(num);
            }


            if (numbrid.Contains(100))
            {
                Console.WriteLine("100 on olemas loendis");
            }
            else
            {
                Console.WriteLine("100 ei ole loendis");
            }
            Console.ReadKey();
        }
    }
}
