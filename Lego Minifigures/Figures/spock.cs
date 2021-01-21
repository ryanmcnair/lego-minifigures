using System;
using System.Collections.Generic;
using System.Text;

namespace Lego_Minifigures.Figures
{
    class Spock
    {
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public Spock(string hair, string head, string torso, string legs, string accessories)
        {
            Hair = hair;
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
            Console.WriteLine($"Spock's hair is {hair}. His head is {head}. Torso and legs are {torso} & {legs}. He carries {accessories} with him.");
        }

        public void Attack()
        {
            Console.WriteLine("Spock applies the Vulcan nerve pinch");
        }

        public void Logic()
        {
            Console.WriteLine("Your choices are highly illogical");
        }

        public void Salute()
        {
            Console.WriteLine("Live long and prosper");
        }
    }
}
