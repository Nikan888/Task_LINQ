using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class Spider : IAnimalWorld
    {
        public string Name { get; set; }
        public int NumberOfLimbs { get; set; }

        public Spider()
        {
            Name = "Spider";
            NumberOfLimbs = 8;
        }

        public void Voice()
        {
            Console.WriteLine("Voice: (Hiss)");
        }
    }
}
