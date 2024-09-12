using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ConcreteCollection<T> : IEnumerable<T>
    {
        private List<T> _items = new List<T>();

        public void AddItem(T item)
        {
            _items.Add(item);
        }

        public IIterator<T> GetIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public T this[int index]
        {
            get { return _items[index]; }
        }
    }

}
