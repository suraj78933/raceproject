using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceproject
{
    partial class MainForm
    {
        public void findVictor(int who)
        {
            switch (who) // which Racer won
            {
                case (0):
                    RacerWonLbl.Text = ("Victory to the Trumpenreich!");
                    MessageBox.Show("hail trump");
                    break;
                case (1):
                    RacerWonLbl.Text = ("Victory to the Russian Federation");
                    MessageBox.Show("hail putin");
                    break;
                case (2):
                    RacerWonLbl.Text = ("Victory to the moderate rebels");
                    MessageBox.Show("moderate victory");
                    break;
                case (3):
                    RacerWonLbl.Text = ("Victory to the extremist rebels");
                    MessageBox.Show("hail bin laden");
                    break;
            }

            for (int i = 0; i < 3; i++)
            {
                if (myguy[i].dog == who)
                {
                    myguy[i].bank += pot; // credit the winner
                    pot = 0;
                }
            }

            findWhichBettorWon();
        }

        public void findWhichBettorWon()
        {
            bool gameOver = false;

            if (isHeInGame(mrBob) == false && isHeInGame(mrFred) == false)
            {
                mylabels[mrBalls].Text = "Ballbags has won!";
                gameOver = true;
            }
            else if (isHeInGame(mrFred) == false && isHeInGame(mrBalls) == false)
            {
                mylabels[mrBob].Text = "Bob has won!";
                gameOver = true;
            }
            else if (isHeInGame(mrBob) == false && isHeInGame(mrBalls) == false)
            {
                mylabels[mrFred].Text = "Fred has won!";
                gameOver = true;
            }
            else
            {
                Console.WriteLine("The game continues");
            }

            if (gameOver == true)
            {
                globalReset.Enabled = true;
                hidePictures();
                disableAllButtons();
            }


            for (int x = 0; x < 3; x++) // game over, anyone with zero dollars is out
            {
                if (myguy[x].bank < 1) disablePlayer(x);
            }

            for (int x = 1; x < 3; ++x) // if the player is active and they have money, then reset their hasAlreadyBet, they can go again
            {
                if (isHeInGame(x) == true && myguy[x].bank > 1) myguy[x].hasAlreadyBet = false; // false, but it remains true for inactive players (otherwise the race won't start)
            }

            restrictMaxBet(); // depending on the selected radio button, restrict the numeric-up-down
        }

        public void giveStartingCredit() // and reset 2 or 10 other things
        {
            for (int y = 0; y < 3; ++y)
            {
                myguy[y].bank = 50;
                myradio[y].Enabled = true;
                myguy[y].hasAlreadyBet = false;
            }

            resetInterface();
        }

        public void hidePictures()
        {
            for (int y = 0; y < 3; ++y)
            {
                myruler[y].pb.Enabled = false;
            }
        }

        public void disableAllButtons()
        {
            for (int y = 0; y < 3; ++y)
            {
                myradio[y].Enabled = false;
            }
        }

    }
}
