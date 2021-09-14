using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs3
{
    public class Person
    {
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Math.Abs(value);
            }
        }


        public bool IsMale { get; set; }

        public string hobby { get; set; }


    }
}
