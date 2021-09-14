using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs3
{
    public class ThingForSale
    {
        public string name { get; set; }
        public string type { get; set; }

        private decimal _lengh;
        private bool _lenghSet = false;
        public decimal lengh
        {
            get
            {
                return _lengh;
            }
            set
            {
                
                 if (_lenghSet == false)
                 {
                        _lengh = value;
                        _lenghSet = true;
                 }
               
            }
        }

        private decimal _width;
        private bool _widthSet = false;
        public decimal width
        {
            get
            {
                return _width;
            }
            set
            {

                if (_widthSet == false)
                {
                    _width = value;
                    _widthSet = true;
                }

            }
        }
        private decimal _height;
        private bool _heightSet = false;
        public decimal height
        {
            get
            {
                return _height;
            }
            set
            {

                if (_heightSet == false)
                {
                    _height = value;
                    _heightSet = true;
                }

            }
        }
        public bool isAlcohol { get; set; }
        public decimal alcoholcontent { get; set; }
        public double price { get; set; }
        public decimal liters { get; set; }
        public int shelfLocation { get; set; }
        public bool instock { get; set; }
    }
}
