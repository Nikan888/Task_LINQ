using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Whale : IAnimalWorld, ISwimmable
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Whale()
        {
            Name = "Whale";
            NumberOfLimbs = 3;
        }

        public void Voice()
        {
            Console.WriteLine("Voice: (Sing)");
        }

        public void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
