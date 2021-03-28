using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raceproject
{
    public abstract class punter
    {
        public string name;
        public int bet;
        public int bank;
        public int dog;
        public bool hasAlreadyBet;
        public bool gameOver;

        public punter()
        {
            name = "default name";
            bet = 0; // DEFAULT VALUES
            dog = 0;
            hasAlreadyBet = false;
            gameOver = false;
            bank = 50;
        }
    }

    class bob : punter
    {
        public bob()
        {
            name = "Bob";
            //bank = 150;
        }
    }

    class fred : punter
    {
        public fred()
        {
            name = "Fred";
            //bank = 200;
        }
    }

    class ballbags : punter
    {
        public ballbags()
        {
            name = "Ballbags";
            //bank = 500;
        }
    }

}
