using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_004_03Enumerate
{
    class Program
    {
        static void Find(char[] Set, char[] Word, int N)
        {
            if (N == Word.Length)           
            {
                foreach (var e in Word) { Console.Write(e); }
                Console.WriteLine();
                return;
            }
 
            char[] tWord = Word;

            for (int i = 0; i < Set.Length; i++)
            {
                tWord[N] = Set[i];
                Find(Set, tWord, N + 1);      
            }
        }


        static void Main(string[] args)
        {
            char[] alphabet = { 'q', 'w', 'e','r','t' };
            char[] currentWord = new char[4];

            Find(alphabet, currentWord, 0);
        }
    }
}
