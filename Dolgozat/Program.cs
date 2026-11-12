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
                string item = huto[i].ToLower();
                Console.WriteLine("Item");
                for (int y = 0; y < maganhangzok.Length; y++)
                {
                    Console.WriteLine("Huto: " + item);
                    Console.WriteLine("Csekkolt betu: " + maganhangzok[y]);
                    if (item.StartsWith(maganhangzok[y]))
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

        static void LeghosszabbNovekvo()
        {
            bool sorozat = true;
            int previousNumber = szamok[0];
            for (int i = 1; i < szamok.Length - 1; i++)
            {
                if (sorozat && (previousNumber + 1) == szamok[i])
                {
                    previousNumber = szamok[i];
                    sorozat = true;
                }
                
                
            }
        }

        static void Main(string[] args)
        {
            
            huto[5] = "Igen";
            huto[6] = "Nem";
            MaganhangzoListazas();
        }
    }
}
