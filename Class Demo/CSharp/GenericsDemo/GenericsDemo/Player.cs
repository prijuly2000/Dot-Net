using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsDemo
{
    class Player
    {
        int pid;
        string name;
        double score;
        public Player(string nm, int id, double bs)
        {
            name = nm;
            pid = id;
            score = bs;
        }
        public override string ToString()
        {
            return "\nName=" + name + "\tpid=" + pid + "\tscore=" + score; ;
        }
    }
}
