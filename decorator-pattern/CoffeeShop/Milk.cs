using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    public class Milk: CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Молочная пена";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.10;
        }
    }
}
