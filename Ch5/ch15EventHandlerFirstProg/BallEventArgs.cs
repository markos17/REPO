using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ch15EventHandlerFirstProg
{
    public class BallEventArgs : EventArgs
    {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }

        public BallEventArgs(int trajcetory, int distance)
        {
            this.Distance = distance;
            this.Trajectory = trajcetory;
        }

    }
}
