using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    class CouponWithCashback : Coupon
    {
        public double discNominal;

        public CouponWithCashback(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }

    }
}
