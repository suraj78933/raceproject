using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceproject
{
    partial class MainForm
    {
        public void updateLocations()
        {
            trumpImg.Location = new Point(myruler[0].myLocation.X, myruler[0].myLocation.Y);
            putinImg.Location = new Point(myruler[1].myLocation.X, myruler[1].myLocation.Y);
            moderateImg.Location = new Point(myruler[2].myLocation.X, myruler[2].myLocation.Y);
            radicalImg.Location = new Point(myruler[3].myLocation.X, myruler[3].myLocation.Y);
        }

        public void resetEverything() // handy!
        {
            resetTrackDogs();
            resetBettingSystem();
        }

        public void resetTrackDogs()
        {
            for (int i = 0; i < 4; i++)
            {
                myruler[i].myLocation = myruler[i].startLocation;
            }
        }

        public void resetBettingSystem()
        {
            for (int k = 0; k < 3; k++)
            {
                if (isHeInGame(k) == true)
                {
                    myguy[k].hasAlreadyBet = false;
                    myguy[k].bet = 0;
                }
            }
        }

        public void resetInterface()
        {
            for (int x = 0; x < 3; ++x)
            {
                mylabels[x].ForeColor = System.Drawing.Color.Black;
                mylabels[x].Text = (bettornames[x] + " is in the game");
            }
        }
    }
}
