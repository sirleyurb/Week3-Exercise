using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kastujal sisestada tähte
            //programm kontrolib, kas sisestatud täht on
            // täishäälik või kaashäälikud
            //kui sisestatud täht on täishäälik - programm kuvab
            //"täishäälik"
            //kui sisestatud täht on kaashäälik
            //programm kuvab - "kaashäälik"
            //kasutame switch'i 

            //"mingi sõna" - string
            // 'a' - character ehk char

            Console.WriteLine("Sisesta täht:");
            char userCharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userCharacter)
            {
                case 'a':
                    Console.WriteLine("täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("täishäälik");
                    break;
                case 'o':
                    Console.WriteLine("täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("täishäälik");
                    break;
                default:
                    Console.WriteLine("kaashäälik");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
