using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal class ConcreteIterator<T> : IIterator<T>
    {
        private readonly ConcreteCollection<T> _collection;
        private int _currentIndex = -1;

        public ConcreteIterator(ConcreteCollection<T> collection)
        {
            _collection = collection;
        }

        public T Current
        {
            get
            {
                if (_currentIndex < 0 || _currentIndex >= _collection.Count)
                    throw new InvalidOperationException();
                return _collection[_currentIndex];
            }
        }

        public bool MoveNext()
        {
            if (_currentIndex + 1 < _collection.Count)
            {
                _currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }

}
