﻿using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs3
{
    public class car
    {


        public string manufacturer { get; set; }
        public string model { get; set; }
        public string licencePlate { get; set; }
        public int topspeed { get; set; }
        public int currentspeed { get; set; }

        public static void PressHorn()
        {
            Sounds.horn();
        }
        public void accelearte()
        {
            ++currentspeed;
        }
        public void deAccelearte()
        {
            --currentspeed;
        }
        public void stopAccelerate()
        {
            currentspeed = 0;
        }


    }



}
