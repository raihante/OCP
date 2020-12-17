using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    class CouponWithPercentage : Coupon
    {
        public double discPercentage = 0;

        public CouponWithPercentage(double discPercentage)
        {
            this.discPercentage = discPercentage;
        }

        public override double calculate(double originPrice)
        {
            return (100 - discPercentage) * originPrice / 100;
        }

    }
}
