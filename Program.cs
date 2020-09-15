using System;

namespace The_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //there is nothing wrong
            {
                // So...
                // 2+2 is 4
                // -1 that's 3
                // Quick math...
                var FirstHorsemenOfApocalypse = new Random();
                var SecondHorsemenOfApocalypse = new string[] {" from death....... ", " from war......... ", " from Coronavirus. ", " from mans not hot " };
                var ThirdHorsemenOfApocalypse = FirstHorsemenOfApocalypse.Next(-100, -1) + SecondHorsemenOfApocalypse[FirstHorsemenOfApocalypse.Next(0, 3)];
                var FourthBlackHorsemenOfApocalypse = " 1800-ALLWAYS";
                // Riiiiiiiiiiiing 
                Console.WriteLine(ThirdHorsemenOfApocalypse+FourthBlackHorsemenOfApocalypse);
            }
        }
    }
}
