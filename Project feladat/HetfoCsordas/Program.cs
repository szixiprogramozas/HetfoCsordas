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

            int osszeg = 0;
            Masodik(erdo, osszeg);
            Harmadik(erdo);
            Negyedik(erdo);
            Otodik(erdo);
            Hatodik(erdo);
            Hetedik(erdo);
            int db = 0;
            Nyolcadik(erdo, db);
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

        public static int Masodik(int[,] erdo, int osszeg)
        {
            Console.WriteLine("2. feladat");
            osszeg = 0;

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    osszeg += erdo[i, k];
                }

            }
            Console.WriteLine("Összesen {0} db gombát szedtek! ", osszeg);
            return osszeg;
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
        public static void Negyedik(int[,] erdo)
        {
            int db = 0;
            Console.WriteLine("\n4. Feladat ");
            Console.WriteLine("Ezekben a sorokban nem volt gomba:");
            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    if (erdo[i, k] > 0)
                    {
                        db++;
                    }                  
                }
            }

            if (db > 33)
            {
                Console.WriteLine("Mindegyikben volt!");

            }
            else if (db <= 33)
            {
                for (int i = 0; i < col; i++)
                {
                    Console.WriteLine("A(z) " + (i+1) + ". sorban.");
                }               
            }
        }

        public static void Otodik(int[,] erdo)
        {
            StreamWriter fileki = new StreamWriter(@"max.txt");
            fileki.WriteLine("5. Feladat: ");
            fileki.WriteLine("A legtöbb gombát a következő területeken szedték: ");
            fileki.WriteLine("A területek (Sor, Oszlop)");
            int max = erdo[0, 0];

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    if (erdo[i, k] > max)
                    {
                        max = erdo[i, k];
                    }
                }
            }

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    if (max == erdo[i, k])
                    {
                        fileki.WriteLine("(" + (i + 2) + ", " + (k + 1) + ")");
                    }
                }
            }

            fileki.Flush();
            fileki.Close();
        }

        public static int Hatodik(int [,] erdo)
        {
            Console.WriteLine("\n6.feladat");
            Console.Write("Kérem adja meg a sor értéket: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg az oszlop értéket: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool joUtvonal = true;
            string utvonal = "";
            do
            {
                Console.Write("Adjon meg egy valid útvonalat: ");
                utvonal = Console.ReadLine();
                if (utvonal.Length > 255)
                {
                    joUtvonal = false;
                }
                else
                {
                    joUtvonal = true;
                    for (int i = 0; i < utvonal.Length; i++)
                    {
                        switch (char.GetNumericValue(utvonal[i]))
                        {
                            case 0:
                                break;
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            default:
                                joUtvonal = false;
                                break;
                        }
                    }
                }
            } while (joUtvonal == false);
            int gombakSzama = erdo[x, y];
            for (int i = 0; i < utvonal.Length; i++)
            {
                switch (char.GetNumericValue(utvonal[i]))
                {
                    case 0:
                        y = y - 1;
                        break;
                    case 1:
                        x = x + 1;
                        break;
                    case 2:
                        y = y + 1;
                        break;
                    case 3:
                        x = x - 1;
                        break;
                }
                gombakSzama += erdo[x, y];
                erdo[x, y] = 0;
            }
            Console.WriteLine("A talált gombák száma: " + gombakSzama);
            return erdo[x,y];
        }

        public static void Hetedik(int[,] erdo)
        {
            Console.WriteLine("\n7. feladat");
            List<string> bal_indexes = new List<string>();
            List<int> osszegek = new List<int>();
            int checker = 0;

            int osszeg = 0;

            for (int k = 0; k < col; k++)
            {
                for (int i = 0; i < row; i++)
                {
                    checker = 0;
                    try
                    {
                        osszeg = 0;
                        if ((k + 5) <= col)
                        {
                            for (int j = k; j <= (k + 4); j++)
                            {
                                if ((i + 5) <= row)
                                {
                                    for (int l = i; l <= (i + 4); l++)
                                    {
                                        osszeg += erdo[j, l];
                                        if (checker == 0)
                                        {
                                            bal_indexes.Add(Convert.ToString(j) + "; " + Convert.ToString(l));
                                        }
                                        checker = 1;
                                    }
                                }
                            }
                        }
                        osszegek.Add(osszeg);
                    }
                    catch
                    {
                        /*
                        osszeg = 0;
                        for (int h = k; h > (k + 5); h--)
                        {
                            for (int d = i; d > (i + 5); d--)
                            {
                                osszeg += erdo[h, d];
                                if (checker == 0)
                                {
                                    bal_indexes.Add(Convert.ToString(h) + "; " + Convert.ToString(d));
                                }
                                checker = 1;
                            }
                        }
                        osszegek.Add(osszeg);
                        */
                    }
                }
            }

            int index = 0;
            int max = osszegek[0];

            for (int m = 0; m < osszegek.Count(); m++)
            {
                if (max < osszegek[m])
                {
                    max = osszegek[m];
                    index = m;
                }
            }

            Console.WriteLine("[ LEGTÖBB GOMBA EGY TERÜLETEN ] Az ezen a koordinátán {0} lévő gombák száma: {1}", bal_indexes[index], max);
        }

        public static int Nyolcadik(int [,] erdo, int db)
        {
            Console.WriteLine("\n8.feladat");
            bool el = false;
            for (int i = 2; i < col-1; i++)
            {
                for (int j = 2; j < row-1; j++)
                {
                    if (erdo[i, j] > 0)
                    {
                        db = erdo[i - 1, j - 1] + erdo[i - 1, j] + erdo[i - 1, j + 1] +erdo[i, j - 1] + erdo[i, j + 1] + erdo[i + 1, j - 1] + erdo[i + 1, j] +erdo[i + 1, j + 1];
                        if (db==0)
                        {
                            el = true;
                        }
                    }

                }
            }
            if (el==true)
            {
                Console.WriteLine("Van");
            }
            else
            {
                Console.WriteLine("Nincs");
            }
            return db;
        }

    }
}