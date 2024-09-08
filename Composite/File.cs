using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class File : IFileSystemItem
    {
        public string Name { get; private set; }
        public long Size { get; private set; }

        public File(string name, long size)
        {
            Name = name;
            Size = size;
        }

        public long GetSize()
        {
            return Size;
        }
    }
}
