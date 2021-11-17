using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ConsoleApp1
{
    interface ITranspor<T>
    {
        void Add(T item);


        T this [int index]
        {
            get; set;
        }
        int Total { get; }
    }
}
