﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IFileSystemItem
    {
        string Name { get; }
        long GetSize();
    }
}
