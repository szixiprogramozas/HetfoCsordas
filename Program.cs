using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace HetfoCsordas
{
    class Program
    {
        public static int hossz = File.ReadAllLines(@"erdo.txt").Count();
        static void Main(string[] args)
        {
            int[,] erdo = Beolvas();
            Console.ReadKey();
        }


        // Fájl beolvasása
        public static int[,] Beolvas()
        {
            StreamReader reader = new StreamReader(@"erdo.txt");

            string sor = reader.ReadLine();
            string[] temp = sor.Split(' ');

            int col = int.Parse(temp[0]);
            int row = int.Parse(temp[1]);        

            Console.Write(col);
            Console.Write(row + "\n");

            int[,] erdo = new int[col, row];

            int i = 0;
            int k = 0;

            while ((sor = reader.ReadLine()) != null)
            {
                string[] temp2 = sor.Split(' ');
                try
                {
                    i = 0;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    i++;
                    erdo[k, i] = int.Parse(temp2[i]);
                    k++;
                }
                catch
                {

                }
            }

            /*
            
            Itt hagyom hogy bármikor tudjuk visszanézni hogy jó-e
            
            for (int a = 0; a < col; a++)
            {
                for (int s = 0; s < row; s++)
                {
                    Console.Write(erdo[a, s]);
                }
                Console.WriteLine();
            }
            
            
            */
            
            return erdo;
        }

        public static void Elso()
        {

        }

        public static void Masodik()
        {

        }

        public static void Negyedik()
        {

        }

        public static void Otodik()
        {

        }

        public static void Hatodik()
        {

        }

        public static void Hetedik()
        {

        }

        public static void Nyolcadik()
        {

        }

    }
}
