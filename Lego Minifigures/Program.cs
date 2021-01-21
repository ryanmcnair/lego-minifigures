using System;
using Lego_Minifigures.Figures;

namespace Lego_Minifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            McCoy doctor = new McCoy("Brown", "Round", "Blue shirt", "Black pants", "Doctor bag");
            Spock vulcan = new Spock("Black", "Round", "Blue shirt", "Black pants", "European man bag");
            Kirk captain = new Kirk("Brown", "Round", "Green shirt", "Black pants", "Blaster");
            Console.WriteLine();
            doctor.Jump();
            doctor.Build();
            Console.WriteLine();
            vulcan.Attack();
            vulcan.Logic();
            vulcan.Salute();
            Console.WriteLine();
            captain.MakeLove();
        }
    }
}
