using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Xml;

namespace Dolgozat
{
    internal class Program
    {
        static Random r = new Random();
        static string[] huto = new string[10];
        static int[] szamok = new int[10];
        static void PutIn(string item)
        {

            for (int i = 0; i < huto.Length; i++)
            {

                if (huto[i] == "")
                {
                    huto[i] = item;
                    break;
                }
            }

       }
        static int Takarit()
        {
            string[] seged = new string[huto.Length];
            int y = 0;
            for (int i = 0; i < seged.Length; i++)
            {
                if (huto[i] != null)
                {
                    seged[y] = huto[i];
                    Console.WriteLine("Seged: " + seged[y]);
                    Console.WriteLine("huto: " + huto[i]);
                    y++;
                }
                
            }
            huto = seged;
            return y + 1;

        }

        static int KeresEtel(string itemName)
        {
            int foundIndex = -1;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] == itemName)
                {
                    foundIndex = i;
                }
            }

            return foundIndex;
        }

        static void MaganhangzoListazas()
        {
            char[] maganhangzok = new char[14]

            {
                'e', 'é', 'i', 'í', 'ö', 'ő', 'ü', 'ű', 'a', 'á', 'o', 'ó', 'u', 'ú'
            };

            Console.WriteLine("Magánhangzóval kezdődő szavak: ");
            for (int i = 0; i < huto.Length; i++)
            {
                Console.WriteLine("Elindult");
                string item = huto[i];
                Console.WriteLine();
                char betu = item[0];
                Console.WriteLine("item megadva");
                //item = item.ToLower();
                //Console.WriteLine("Item toLower");
                for (int y = 0; y < maganhangzok.Length; y++)
                {
                    Console.WriteLine("Huto: " + item);
                    Console.WriteLine("Csekkolt betu: " + maganhangzok[y]);
                    if (betu == maganhangzok[y])
                    {
                        Console.Write(huto[i] + ", ");
                    }
                }
                
            }
            
        }

        static int[] FeltoltEgyediekkel(int min, int max, int[] tomb)
        {
            bool tryAgain = false;
            int currentIndex = 0;
            do
            {
                int randomNum = r.Next(min, max);
                tryAgain = false;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (randomNum == tomb[i])
                    {
                        tryAgain = true;
                    }
                }
                if (!tryAgain)
                {
                    tomb[currentIndex] = randomNum;
                    currentIndex++;
                }
            } while (currentIndex < tomb.Length);

            return tomb;
        }

        static int[] LeghosszabbNovekvo()
        {
            bool sorozat = true;
            int previousNumber = szamok[0];
            string[] sorozatok = new string[szamok.Length];
            int y = 0;
            sorozatok[y] += Convert.ToString(szamok[0]);
            for (int i = 1; i < szamok.Length; i++)
            {
                if (sorozat && (previousNumber + 1) == szamok[i])
                {
                    sorozatok[y] += Convert.ToString(szamok[i]);
                    previousNumber = szamok[i];
                    sorozat = true;
                } else
                {
                    sorozat = false;
                    y++;
                }
                
                
            }
            //------------------TEST----------------------

            for (int i = 0; i < sorozatok.Length; i++)
            {
                Console.WriteLine($"{i+1}. sorozatt: " + sorozatok[i]);
            }

            //------------------------------------------

            int legnagyobbSorozatIndex = -1;
            int legnagyobbSorozatSzam = 0;
            
            for (int i = 0; i < sorozatok.Length; i++)
            {
                if (sorozatok[i] == null)
                {
                    continue;
                }

                int sorozattHossz = sorozatok[i].Length;
                
                if (sorozatok[i].Length > legnagyobbSorozatSzam)
                {
                    
                    legnagyobbSorozatIndex = i;
                    legnagyobbSorozatSzam = sorozatok.Length;
                    Console.WriteLine("index: " + legnagyobbSorozatIndex);
                    Console.WriteLine("legnagyobbSorozatSzam: " + legnagyobbSorozatSzam);
                }

            }


            int[] legnagyobbSorozat = new int[legnagyobbSorozatSzam];
            //Console.Write("Legnagyobb sorozat: ");
            string legnagyobbSorozatSorozat = sorozatok[legnagyobbSorozatIndex];
            Console.WriteLine(legnagyobbSorozatSorozat);
            int x = 0;
            foreach (char betu in legnagyobbSorozatSorozat)
            {
                Console.WriteLine(betu);
                legnagyobbSorozat[x] = Convert.ToInt32(betu);
                Console.WriteLine("legnagyobbSorozat tomb 1.: " + legnagyobbSorozat[x]);
                Console.WriteLine("sorozatokbol: " + Convert.ToInt32(betu));
                x++;
            }

            return legnagyobbSorozat;
        }

        static void AtlagAlattiDuplazas()
        {
            int sum = szamok.Sum();
            double atlag =  sum/szamok.Length;
            
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < atlag)
                {
                    szamok[i] = szamok[i] * 2;
                }
            }
        }

        static void Main(string[] args)
        {
            
            huto[5] = "igen";
            huto[6] = "Nem";
            huto[7] = "alma";
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = i;
            }
            LeghosszabbNovekvo();
            

        }
    }
}
