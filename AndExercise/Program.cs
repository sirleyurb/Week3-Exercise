using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Mitu punkti saite matemaatikas?");
            int Matem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mitu punkti saite keemias?");
            int Keemia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mitu punkti saite bioloogias?");
            int bio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma eksami punktid:");

            if (Matem >= 85 && Keemia >= 90 && bio >= 95)
            {
                Console.WriteLine("Tubli töö! Õpi arstiks!");
            }
            else
            {
                Console.WriteLine("Ei ole piisavalt punkte");
            }
        }
    }
}
