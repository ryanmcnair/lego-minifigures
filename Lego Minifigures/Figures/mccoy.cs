using System;
using System.Collections.Generic;
using System.Text;

namespace Lego_Minifigures.Figures
{
    class McCoy
    {
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }

        public McCoy(string hair, string head, string torso, string legs, string accessories)
        {
            Hair = hair;
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
            Console.WriteLine($"Dr McCoy's hair is {hair}. His head is {head}. Torso and legs are {torso} & {legs}. He carries {accessories} with him.");
        }

        public void Jump()
        {
            Console.WriteLine("Damn it Jim! I'm a doctor not an acrobat");
        }
        public void Rescue()
        {
            Console.WriteLine("Doctor coming through!");
        }
        public void Build()
        {
            Console.WriteLine("Damn it Jim! I'm a doctor not a bricklayer");
        }
    }
}
