using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch15EventHandlerFirstProg
{
    public class Fan
    {

        public ObservableCollection<string> FanSays = new ObservableCollection<string>();
        private int pitchNumber = 0;

        public Fan(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            pitchNumber++;
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Trajectory > 30 && ballEventArgs.Distance > 400)
                {
                    FanSays.Add("Pitch #" + pitchNumber
                                + ": Home run! I'm going for the ball!");
                }
                else
                {
                    FanSays.Add("Pitch #" + pitchNumber + ": Woo-hoo! Yeah!");
                }

            }


        }
    }
}
