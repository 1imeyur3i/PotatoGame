using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato
{
    class Q_IQ<T> : IQueue<T>
    {
        Queue<T> Q;

        public Q_IQ() { Q = new Queue<T>(); }

        public void Enqueue(T item)
        {
            Q.Enqueue(item);
        }
        public T Dequeue()
        {
            return Q.Dequeue();
        }
        public int Count { get { return Q.Count(); } }

    }
}
