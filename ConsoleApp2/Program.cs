using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du nyligen gått ut gymnasiet? j/n ");
            string svar1 = Console.ReadLine();
            Console.WriteLine("Hur gammal är du? ");
            int age = int.Parse(Console.ReadLine());

            

            if (svar1 == "j" & age <= 21)
            {
                
                
                 Console.WriteLine("Vi vill gärna anställa dig ");
                
            }
            else
            {
                Console.WriteLine("Vi letar efter annan personal just nu ");
            }
        }
    }
}
