using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithoutOCP
{
    class Coupon
    {

        public double discNominal = 0;
        public double discPercentage = 0;
        public double discCashback = 0;

        public double priceNett(double originPrice)
        {
            double net = 0;
            if (discNominal == 0 && discPercentage > 0)
            {
                net = (100 - discPercentage) * originPrice / 100;
            }
            else if (discNominal > 0 && discPercentage == 0)
            {
                net = originPrice - discNominal;
            }
            else if (discNominal > 0 && discPercentage > 0)
            {
                if (discNominal >= 3000 && discPercentage >= 30)
                {
                    net = originPrice - discNominal;
                }
                else if (discNominal < 3000 && discPercentage < 30)
                {
                    double hargadisc;
                    hargadisc = (100 - discPercentage) * originPrice / 100;
                    net = hargadisc - discNominal;
                }
            }
            return net;
        }


    }
}
