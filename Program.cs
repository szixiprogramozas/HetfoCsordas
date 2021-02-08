using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace HetfoCsordas
{
    
    class Program
    {
        public static StreamReader reader = new StreamReader(@"erdo.txt");
        public static string sor = reader.ReadLine();
        public static string[] temp = sor.Split(' ');

        public static int col = int.Parse(temp[0]);
        public static int row = int.Parse(temp[1]);
        
        static void Main(string[] args)
        {
            int[,] erdo = Beolvas();
            
            Masodik(erdo);
            Harmadik(erdo);
            Otodik(erdo);
            Console.ReadKey();
        }


        // Fájl beolvasása
        public static int[,] Beolvas()
        {
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

        public static void Masodik(int[,] erdo)
        {
            Console.WriteLine("2. feladat");
            int osszeg = 0;

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    osszeg += erdo[i, k];
                }

            }
            Console.WriteLine("Az összegük: " + osszeg);
        }

        public static void Harmadik(int[,] erdo)
        {
            Console.WriteLine("\n3. feladat");
            int eszak = 0;
            int kelet = 0;
            int del = 0;
            int nyugat = 0;
            int col_half = col / 2;
            int row_half = row / 2;

            List<int> kicsi = new List<int>();

            for (int k = 0; k < col; k++)
            {
                for (int i = 0; i < row; i++)
                {
                    if (k < row_half)
                    {
                        eszak += erdo[k, i];
                    }
                    else if (k > row_half)
                    {
                        del += erdo[k, i];
                    }
                    else if (i < col_half)
                    {
                        nyugat += erdo[k, i];
                    }
                    else if (i > col_half)
                    {
                        kelet += erdo[k, i];
                    }
                }
            }

            kicsi.Add(eszak);
            kicsi.Add(del);
            kicsi.Add(kelet);
            kicsi.Add(nyugat);

            kicsi.Sort();

            if (kicsi[0] == eszak)
            {
                Console.WriteLine("Észak");
            }

            if (kicsi[0] == kelet)
            {
                Console.WriteLine("Kelet");
            }

            if (kicsi[0] == nyugat)
            {
                Console.WriteLine("Nyugat");
            }

            if (kicsi[0] == del)
            {
                Console.WriteLine("Dél");
            }

        }
        public static void Negyedik()
        {

        }

        public static void Otodik(int[,] erdo)
        {
            StreamWriter fileki = new StreamWriter(@"d:\max.txt");
            int max = 0;

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    if (erdo[i, k] > max)
                    {
                        max = erdo[i, k];
                    }
                    fileki.WriteLine("A legtöbb gomba: " + erdo[i, k]);
                }
            }           
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
