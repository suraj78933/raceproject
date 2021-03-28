using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raceproject
{
    public partial class MainForm : Form
    {
        // DECLARATIONS
        int RacerSelected = 0;
        int bettorSelected = 0;
        int pot = 0; // put your bet in here please sirs

        const int mrTrump = 0;
        const int mrVlad = 1;
        const int moderateRbl = 2;
        const int extremistRbl = 3;

        const int mrBob = 0;
        const int mrFred = 1;
        const int mrBalls = 2;

        punter[] myguy = new punter[3];
        leader[] myruler = new leader[4];
        Label[] mylabels = new Label[4];
        RadioButton[] myradio = new RadioButton[4];
        string[] bettornames = new string[4];
        Random randomGenerator = new Random();

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                myguy[i] = factory.CreateHuman(i);
            }

            for (int i = 0; i < 4; i++)
            {
                myruler[i] = factory.CreateLeader(i);
            }

            myruler[0].pb = trumpImg;
            myruler[1].pb = putinImg;
            myruler[2].pb = moderateImg;
            myruler[3].pb = radicalImg;

            mylabels[0] = bobStatusLbl;
            mylabels[1] = fredStatusLbl;
            mylabels[2] = ballbagsStatusLbl;

            myradio[0] = selectBobBtn;
            myradio[1] = selectFredBtn;
            myradio[2] = selectBallbagsBtn;

            bettornames[0] = "Bob";
            bettornames[1] = "Fred";
            bettornames[2] = "Ballbags";

            showMeTheMoney();
        }

        // SELECT Racer ...

        private void trumpBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (trumpBtn.Checked == true) RacerSelected = mrTrump;
        }

        private void putinBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (putinBtn.Checked == true) RacerSelected = mrVlad;
        }

        private void moderateBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (moderateBtn.Checked == true) RacerSelected = moderateRbl;
        }

        private void extremistBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (extremistBtn.Checked == true) RacerSelected = extremistRbl;
        }

        // SELECT BETTOR

        private void selectBobBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (selectBobBtn.Checked == true)
            {
                bettorSelected = 0;
                restrictMaxBet(); // restrict the numeric-up-down
            }

        }

        private void selectFredBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (selectFredBtn.Checked == true)
            {
                bettorSelected = 1;
                restrictMaxBet(); // restrict the numeric-up-down
            }
        }

        private void selectBallbagsBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (selectBallbagsBtn.Checked == true)
            {
                bettorSelected = 2;
                restrictMaxBet(); // restrict the numeric-up-down
            }
        }

        // THE CONFIRM BET BUTTON

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            whenConfirmClicked(); // now calls a method instead of having the code inserted here
        }

        public void showMeTheMoney()
        {
            bobCreditLbl.Text = Convert.ToString(myguy[0].bank);
            fredCreditLbl.Text = Convert.ToString(myguy[1].bank);
            ballbagsCreditLbl.Text = Convert.ToString(myguy[2].bank);
        }

        public bool everyoneHasBet()
        {
            if (myguy[0].hasAlreadyBet == true && myguy[1].hasAlreadyBet == true && myguy[2].hasAlreadyBet == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getRandom()
        {
            int value = randomGenerator.Next(14, 35);
            return value;
        }


        public bool isHeInGame(int z)
        {
            if (myguy[z].bank < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void disablePlayer(int i)
        {
            myradio[i].Enabled = false;
            mylabels[i].Text = (bettornames[i] + " was killed in action");
            mylabels[i].ForeColor = System.Drawing.Color.Red;
            myguy[i].hasAlreadyBet = true;
            showMeTheMoney();

            switch (i) // disable radio buttons if the player is gone, hopefully avoiding errors and impossible conditions
            {
                case (mrBob):
                    selectBobBtn.Checked = false; // Btn refers to radio buttons
                    break;
                case (mrFred):
                    selectFredBtn.Checked = false;
                    break;
                case (mrBalls):
                    selectBallbagsBtn.Checked = false;
                    break;
            }
        }

        public void restrictMaxBet()
        {
            if (selectBobBtn.Checked == true) betupdown.Maximum = myguy[0].bank;
            if (selectFredBtn.Checked == true) betupdown.Maximum = myguy[1].bank;
            if (selectBallbagsBtn.Checked == true) betupdown.Maximum = myguy[2].bank;
        }

        private void globalReset_Click(object sender, EventArgs e)
        {
            resetEverything();
            giveStartingCredit();
            showMeTheMoney();
        }
    }
}
