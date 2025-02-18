﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato
{
    interface IQueue<T>
    {
        void Enqueue(T item);        
        T Dequeue();
        int Count { get; }
    }
}
