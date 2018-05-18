using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Dog : IAnimalWorld
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Dog()
        {
            Name = "Dog";
            NumberOfLimbs = 4;
        }

        public void Voice()
        {
            Console.WriteLine("Voice: (Bark)");
        }
    }
}
