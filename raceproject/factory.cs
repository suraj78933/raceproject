using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raceproject
{
    // static factory classes
    public static class factory
    {
        static public punter CreateHuman(int whatDoYouWant)
        {
            switch (whatDoYouWant)
            {
            case (0):
                return new bob();
            case (1):
                return new fred();
            case (2):
                return new ballbags();
            default:
                return new bob(); // STUPID IDEA FOR A DEFAULT, BUT OKAY!
            }
        }

        static public leader CreateLeader(int whatDoYouWant)
        {
            switch (whatDoYouWant)
            {
            case (0):
                return new trump();
            case (1):
                return new putin();
            case (2):
                return new moderate();
            case (3):
                return new extremist();
            default:
                System.Console.WriteLine("impossible condition");
                return new trump();
            }
        }

    }
}
