using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Washer
{
    class WasherProgram
    {
        private int watertemp;                              // private int of property watertemp

        public int WaterTemp                                // public int of property watertemp
        {
            get { return watertemp; }                       // set and get method of property water temp
            private set { watertemp = value; }
        }

        private int centrifudgespeed;                       // private int of centrifudgespeed

        public int CentriFudgeSpeed                         // public int of centrifudgespeed
        {
            get { return centrifudgespeed; }                // set and get method of centrifudgespeed
            set { centrifudgespeed = value; }
        }


        public void setProgram(int userinput)               // method set program with a parameter of int userinput
        {
            if (userinput == 1)                             // checks if the user pressed 1
            {
                centrifudgespeed = 800;                     // sets centrifudgespeed = 800
                watertemp = 30;                             // sets watertemp = 30
            }

            else if (userinput == 2)                        // checks if the user pressed 2
            {
                centrifudgespeed = 1000;                    // sets centrifudgespeed = 100
                watertemp = 40;                             // sets watertemp = 40
            }

            else if (userinput == 3)                        // checks if user pressed 3
            {
                centrifudgespeed = 1200;                    // sets centrifudgespeed = 1200
                watertemp = 40;                             // sets watertemp = 40
            }
        }

       
    }
}