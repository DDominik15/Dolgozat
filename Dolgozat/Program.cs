namespace Dolgozat
{
    internal class Program
    {
        static string[] huto = new string[10];

        static bool PutIn(string[] tomb, string item)
        {
            bool success = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == "")
                {
                    tomb[i] = item;
                    success = true;
                }
            }

            return success;
        }
        static int Takarit(string[] tomb)
        {
            string[] seged = new string[tomb.Length];
            int y = 0;
            for (int i = 0; i < seged.Length; i++)
            {
                if (tomb[i] != "")
                {
                    seged[y] = tomb[i];
                    y++;
                }

            }
            return y + 1;

        }

        static void Main(string[] args)
        {
            
        }
    }
}
