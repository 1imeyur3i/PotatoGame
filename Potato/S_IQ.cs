using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato
{
    class S_IQ<T> : IQueue<T>
    {
        Stack<T> S;

        public S_IQ() { S = new Stack<T>(); }

        public void Enqueue(T item)
        {
            S.Push(item);
        }
        public T Dequeue()
        {
            Stack<T> temp = new Stack<T>();
            T item;

            while(S.Count()!=0)
            {
                temp.Push(S.Pop());
            }
           
            item = temp.Pop();

            while(temp.Count()!=0)
            {
                S.Push(temp.Pop());
            }

            return item;
        }
        public int Count { get { return S.Count(); } }
    }
}
