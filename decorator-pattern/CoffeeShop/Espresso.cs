using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Эспрессо" ;
        }

        public override double Cost()
        {
            return 1.99;
        }
       
    }
}
