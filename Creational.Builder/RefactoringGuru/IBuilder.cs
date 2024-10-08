﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.RefactoringGuru
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    internal interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
