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
        public void whenConfirmClicked() // click event calls this ugly piece of code
        {
            if (!RacerSelectedTrueOrFalse() && bettorSelectedTrueOrFalse())
            {
                MessageBox.Show("No Racer selected, cannot bet!");
            }
            else if (RacerSelectedTrueOrFalse() && !bettorSelectedTrueOrFalse())
            {
                MessageBox.Show("No bettor selected, cannot bet!");
            }
            else
            {
                setBets();
                processBet(bettorSelected);
            }

            for (int x = 0; x < 3; x++)
            {
                if (myguy[x].bank < 1) myguy[x].hasAlreadyBet = true;
            }

            if (everyoneHasBet()) beginRace();
        }

        public bool RacerSelectedTrueOrFalse() // is a Racer selected
        {
            if (trumpBtn.Checked == true || putinBtn.Checked == true || moderateBtn.Checked == true || extremistBtn.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool bettorSelectedTrueOrFalse() // is a bettor selected
        {
            if (selectBobBtn.Checked == true || selectFredBtn.Checked == true || selectBallbagsBtn.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void setBets()
        {
            switch (bettorSelected) // take the value from the 'numeric-up-down' box
            {
                case (mrBob):
                    myguy[mrBob].bet = Convert.ToInt32(betupdown.Value);
                    break;
                case (mrFred):
                    myguy[mrFred].bet = Convert.ToInt32(betupdown.Value);
                    break;
                case (mrBalls):
                    myguy[mrBalls].bet = Convert.ToInt32(betupdown.Value);
                    break;
                default:
                    MessageBox.Show("You're not supposed to be here");
                    break;
            }
        }

        public void processBet(int i) // check for nonsensical conditions, e.g. betting more money than the player has available
        {
            if (isHeInGame(i) == false)
            {
                MessageBox.Show("Player " + myguy[i].name + " already lost"); // should not be possible anyway
            }
            else if (myguy[i].hasAlreadyBet == true)
            {
                MessageBox.Show(myguy[i].name + " Already bet");
            }
            else if (myguy[i].bank < myguy[i].bet)
            {
                MessageBox.Show("Not enough money"); // as of 30 May this should be impossible
            }
            else
            {
                myguy[i].bank -= myguy[i].bet; // deduct bet
                pot += myguy[i].bet;
                myguy[i].hasAlreadyBet = true;
                showMeTheMoney(); // refresh bank balances
                myguy[i].dog = RacerSelected; // assign the greyhound for this player
            }
        }

        public async void beginRace() // dangerously ugly code
        {
            bool victory = false;

            while (victory == false)
            {
                for (int j = 0; j < 4; ++j) // for each Racer
                {
                    myruler[j].myLocation.X += getRandom();
                    updateLocations(); // of the pictureboxes
                    await Task.Delay(15);

                    if (myruler[j].pb.Location.X > 1188 - 200) // if a 'greyhound' (or leader) wins
                    {
                        victory = true;
                        findVictor(j);
                        j = 5; // break all loops
                        showMeTheMoney(); // refresh labels
                        MessageBox.Show("all loops evacuated sir!");
                        resetEverything();
                        updateLocations();
                    }
                    else
                    {
                        victory = false;
                    }
                }
            } 
        }

    }
}