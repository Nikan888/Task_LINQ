using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimalWorld> listOfAnimals = new List<IAnimalWorld>
            {
                new Dog(),
                new Whale(),
                new Crow(),
                new Eagle(),
                new Bettle(),
                new Spider()
            };

            Console.WriteLine("/Selecting animals with 6-letter names:/");
            var selectedAnimalsByLetters = from animal in listOfAnimals
                                  where animal.Name.Length == 6
                                  select animal;
            foreach (IAnimalWorld animal in selectedAnimalsByLetters)
                Console.WriteLine("{0}", animal.Name);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Selecting animals that don't have more than 3 limbs:/");
            var selectedAnimalsByLimbs = from animal in listOfAnimals
                                           where animal.NumberOfLimbs <= 3
                                           select animal;
            foreach (IAnimalWorld animal in selectedAnimalsByLetters)
                Console.WriteLine("{0} - {1} limbs", animal.Name, animal.NumberOfLimbs);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Sorting list of animals by number of limbs (descending):/");
            var sortedAnimalsByNumberOfLimbs = from animal in listOfAnimals
                                                 orderby animal.NumberOfLimbs descending
                                                 select animal;
            foreach (IAnimalWorld animal in sortedAnimalsByNumberOfLimbs)
                Console.WriteLine("{0} - {1} limbs", animal.Name, animal.NumberOfLimbs);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Sorting list of animals by names (ascending):/");
            var sortedAnimalsByName = from animal in listOfAnimals
                                                 orderby animal.Name
                                                 select animal;
            foreach (IAnimalWorld animal in sortedAnimalsByName)
                Console.WriteLine("{0}", animal.Name);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Sorting list of animals by length of names (ascending):/");
            var sortedAnimalsByNameLength = from animal in listOfAnimals
                                      orderby animal.Name.Length
                                      select animal;
            foreach (IAnimalWorld animal in sortedAnimalsByNameLength)
                Console.WriteLine("{0}", animal.Name);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Number of elements in list:/");
            var sizeOfList = (from animal in listOfAnimals
                              select animal).Count();
            Console.WriteLine("{0}", sizeOfList);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Minimum number of limbs:/");
            var min = listOfAnimals.Min(m => m.NumberOfLimbs);
            Console.WriteLine("{0}", min);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.WriteLine("/Maximum number of limbs:/");
            var max = listOfAnimals.Max(m => m.NumberOfLimbs);
            Console.WriteLine("{0}", max);
            Console.WriteLine("///////////////////////////////////////////////////////////");

            Console.ReadKey();
        }
    }
}
