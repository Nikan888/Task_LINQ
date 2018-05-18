using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Eagle : IAnimalWorld, IFlyable
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Eagle()
        {
            Name = "Eagle";
            NumberOfLimbs = 4;
        }

        public void Voice()
        {
            Console.WriteLine("Voice: (Screeech)");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
