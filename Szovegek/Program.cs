using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SZAVAKAT TARTALMAZÓ LISTA INICIALIZÁLÁSA
            string[] words = {"uborka", "alma", "ananász", "medve", "autó", "szennyvízcsatorna", "országút" };
            int uWordsN = 0;

            foreach (string word in words)
            {
                if (word.Contains("u"))
                {
                    uWordsN++;
                }
            }

            Console.WriteLine($"A 7 szóból {uWordsN} szóban található u betű");
        }


        // EZ A FÜGGVÉNY FELESLEGESSÉ VÁLT
        /*
        static bool ContainsU(string word)
        {
            bool contains = false;

            foreach (char c in word)
            {
                if (c == char.Parse("u"))
                {
                    contains = true;
                }
            }

            return contains;
        }
        */
    }
}
