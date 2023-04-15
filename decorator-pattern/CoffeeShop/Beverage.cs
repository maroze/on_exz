using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public abstract class Beverage
    {

        protected string description;

        public string Description()
        {
            return description;
        }
        public virtual string GetDescription() { return Description(); }


        public abstract double Cost();
      
    }
}
