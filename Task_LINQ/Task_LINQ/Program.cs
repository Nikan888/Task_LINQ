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
            ListHelper<IAnimalWorld> listOfAnimals = new ListHelper<IAnimalWorld>();
            listOfAnimals.AddItem(new Dog());
            listOfAnimals.AddItem(new Whale());
            listOfAnimals.AddItem(new Crow());
            listOfAnimals.AddItem(new Eagle());
            listOfAnimals.AddItem(new Bettle());
            listOfAnimals.AddItem(new Spider());

            Console.WriteLine("/Selecting animals with 6-letter names:/");
            //IEnumerable<ListHelper<IAnimalWorld>> sequence = 

            Console.ReadKey();
        }
    }
}
