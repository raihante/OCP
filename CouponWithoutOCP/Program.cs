using System;

namespace CouponWithoutOCP
{
    class Program
    {
        static void Main(string[] args)
        {

            Coupon coupon1 = new Coupon();
            coupon1.discNominal = 2000;
            Console.WriteLine(coupon1.priceNett(10000));


            Coupon coupon2 = new Coupon();
            coupon2.discPercentage = 15;
            Console.WriteLine(coupon2.priceNett(10000));

            Coupon coupon3 = new Coupon();
            coupon3.discPercentage = 90;
            coupon3.discNominal = 3000;
            Console.WriteLine(coupon3.priceNett(10000));

        }
    }
}
