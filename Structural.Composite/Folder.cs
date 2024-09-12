using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Folder : IFileSystemItem
    {
        public string Name { get; private set; }
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Folder(string name)
        {
            Name = name;
        }

        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }

        public long GetSize()
        {
            return _items.Sum(item => item.GetSize());
        }
    }

}
