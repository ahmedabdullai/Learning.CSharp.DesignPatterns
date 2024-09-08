﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    internal interface IEnumerable<T>
    {
        IIterator<T> GetIterator();
    }
}
