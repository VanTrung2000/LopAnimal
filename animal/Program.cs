using System;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = 0;
            Animal a = new Animal();
            while (d >= 0)
            {
                d++;
                Console.WriteLine("Nhap ten dong vat: ");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap tieng keu dong vat: ");
                string shound = Console.ReadLine();
                Console.WriteLine("id: "+a.numofAnimals()+"  "+name + " se keu " + shound);
                
            }

        }
        }
    }
