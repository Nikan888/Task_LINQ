using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Bettle : IAnimalWorld, IFlyable
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Bettle()
        {
            Name = "Bettle";
            NumberOfLimbs = 6;
        }

        public void Voice()
        {
            Console.WriteLine("Voice: (Buzz)");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
