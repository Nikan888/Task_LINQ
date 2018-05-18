using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_LINQ
{
    public class ListHelper<T> where T : class
    {
        List<T> listOfAnimals;

        public ListHelper()
        {
            listOfAnimals = new List<T>();
        }

        public List<T> GetAll()
        {
            return listOfAnimals;
        }

        public void AddItem(T item)
        {
            listOfAnimals.Add(item);
        }

        public void RemoveItem(int index)
        {
            if (index > listOfAnimals.Count - 1)
                Console.WriteLine("Index out of range");
            else
                listOfAnimals.RemoveAt(index);
        }

        public void RemoveItem(T item)
        {
            listOfAnimals.Remove(item);
        }

        public T GetItem(int index)
        {
            T a = null;
            if (index > listOfAnimals.Count - 1)
                Console.WriteLine("Index out of range");
            else
                a = listOfAnimals[index];
            return a;
        }
    }
}
