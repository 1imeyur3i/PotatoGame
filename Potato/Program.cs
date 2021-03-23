using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Q_IQ<string> Z = new Q_IQ<string>();
            string Path = "C:/Users/catri/source/repos/Potato/Names.txt";

            StreamReader f = new StreamReader(Path);
            while (!f.EndOfStream)
            {
                string s = f.ReadLine();
                Z.Enqueue(s);
            }
            f.Close();

            int pCount = Z.Count;
            Random rand = new Random();
            int c = 0;
            HotPotato newGame = new HotPotato(Z);

            Console.WriteLine("Игра в горячую картошку началась!\n"+"======================");
            while(!newGame.GameOver())
            {                
                c = rand.Next(1, pCount);
                Console.WriteLine(newGame.Play(c) + " выбыл(а) из игры");
                pCount--;                
            }
            Console.WriteLine("Победитель : " + newGame.Winner());


            Console.ReadLine();
        }
    }
}
