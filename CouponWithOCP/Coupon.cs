using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    public abstract class Coupon
    {
        public abstract double calculate(double originPrice);

    }
}
