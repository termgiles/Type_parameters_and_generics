using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAgency
{
    internal class CustomStack<T>
    {
        private T[] items = new T[0];
        public int Length { get { return items.Length; } }

        public void Push(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }

        public T Pop()
        {
            T output = items[items.Length-1];
            Array.Resize(ref items, items.Length - 1);
            return output;
        }

        public T GetItem(int i) 
        { 
            return items[i];
        }
    }
}
