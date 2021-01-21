using System;
using System.Collections.Generic;
using System.Text;

namespace Lego_Minifigures.Figures
{
    class Kirk
    {
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Accessories { get; set; }
        public Kirk(string hair, string head, string torso, string legs, string accessories)
        {
            Hair = hair;
            Head = head;
            Torso = torso;
            Legs = legs;
            Accessories = accessories;
            Console.WriteLine($"Captain Kirk's hair is {hair}. His head is {head}. Torso and legs are {torso} & {legs}. He carries {accessories} with him.");
        }
        
        public void Jump()
        {
            Console.WriteLine("Kirk jumped");
        }
        public void Blaster()
        {
            Console.WriteLine("Kirk shot his blaster");
        }
        public void MakeLove()
        {
            Console.WriteLine("Kirk makes love to a beautiful alien");
        }
        public void Rescue()
        {
            Console.WriteLine("Bones! We need a doctor over here");
        }
    }
}
