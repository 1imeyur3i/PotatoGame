using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potato
{
    class HotPotato
    {
        IQueue<string> Q_arr;

        public HotPotato(IQueue<string> Q_arr) 
        {
            this.Q_arr = Q_arr;
        }

        public string Play(int n)
        {            
            string tmp;
            for(int i = 0; i < n-1; i++)
            {
                tmp = Q_arr.Dequeue();
                Q_arr.Enqueue(tmp);
            }
            return Q_arr.Dequeue();
        }

        public bool GameOver()
        {
            if (Q_arr.Count == 1)
                return true;
            else
                return false;
        }

        public string Winner()
        {
            return Q_arr.Dequeue();
        }
    }
}
