using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs3
{
    public class phone
    {

        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Lengh { get; set; }
        public double width { get; set; }
        public double Thikness { get; set; }

        public static void MakeCall()
        {
            Sounds.Ringtone();
        }
        public string SendSms()
        {
            return $"Leak from factory.. the {Manufacturer} {Model} size is {Lengh} x {width} x {Thikness}";
        }

    }



}
