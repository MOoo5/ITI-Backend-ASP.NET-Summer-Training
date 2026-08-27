using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Player : Employee, IPlayer, ITypeC<int>
    {
        int health;
        bool isInjured;
        bool isPlaying;
        int recievedGoals;
        int scoredGoals;
        public bool IsPlaying 
        { 
            get => isPlaying; 
            set => isPlaying = (health >= 50 && !isInjured) ? true : false;
        }

        public bool Result()
        {
            return scoredGoals > recievedGoals;
        }

        public void Score()
        {
            ++scoredGoals;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
