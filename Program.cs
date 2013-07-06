using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectEuler99
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("base_exp.txt");
            double CurrentBase = 0, MaxBase = 1, CurrentExp = 0, MaxExp = 1;
            string s;
            int maxline = 0;
            for(int i = 0; i< lines.Count(); i++)
            {
                s = lines[i];
                CurrentBase = double.Parse(s.Split(new char[] { ',' })[0]);
                CurrentExp = double.Parse(s.Split(new char[] { ',' })[1]);
                if (CurrentExp * System.Math.Log(CurrentBase) > MaxExp * System.Math.Log(MaxBase))
                {
                    MaxBase = CurrentBase;
                    MaxExp = CurrentExp;
                    maxline = i;
                }
            }
            Console.WriteLine(maxline + 1);
        }
    }
}
