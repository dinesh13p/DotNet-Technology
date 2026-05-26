using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    // Generic is divided into 2 method
    // user define and predefine 
    // Generic lai "T" ley denote garinxa 
    // 
    internal class GenericExample
    {
        public void Run()
        {
            Box<string> box1 = new Box<string>();
            Box<int> box2 = new Box<int>();
            Box<float> box3 = new Box<float>();

            box1.value = "ramey";

            //Console.WriteLine(box1.value);


            DataStore<string> dataStore = new DataStore<string>();
            dataStore.Add("apple");
            dataStore.Add("Orange");

            var a = dataStore.GetItem(0);
            var all = dataStore.GetAll();

            Console.WriteLine(all);
            Console.WriteLine(a);
        }
    }

    class Box<T>
    {
        public T value;

        public T GetValue() { return value; }

        public void setValue(T value)
        {
            this.value = value;
        }
    }

    //class task 2

    class DataStore<T>
    {
        private List<T> _items;

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T GetItem(int index)
        {
            { return _items[index]; }
        }

        public List<T> GetAll() { 
            return _items;
        }
    }
}