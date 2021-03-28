using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace raceproject
{
    //implemented the Leader as a abstract class and Trump, Putin, moderate and extremist are these child classes those using Leader abstract class a skelton.
    public abstract class leader
    {
        public string name;
        public int progress;
        public Point startLocation;
        public Point myLocation;
        public PictureBox pb;

        public leader()
        {
            name = "default name";
            progress = 0;
            myLocation = new Point (0, 0);
        }
    }

    class trump : leader
    {
        public trump()
        {
            name = "Trumpenreich";
            progress = 0;
            startLocation = new Point(222, 12);
            myLocation = startLocation;
        }
    }

    class putin : leader
    {
        public putin()
        {
            name = "Vlad";
            progress = 0;
            startLocation = new Point (222, 170);
            myLocation = startLocation;
        }
    }

    class moderate : leader
    {
        public moderate()
        {
            name = "Moderate Rebel";
            progress = 0;
            startLocation = new Point(222, 300);
            myLocation = startLocation;
        }
    }

    class extremist : leader
    {
        public extremist()
        {
            name = "Terrorist Rebel";
            progress = 0;
            startLocation = new Point(222, 529);
            myLocation = startLocation;
        }
    }


}
