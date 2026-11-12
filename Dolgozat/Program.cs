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

        static void Main(string[] args)
        {
            
        }
    }
}
