using System;

namespace CouponWithOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));

            Coupon coupon2 = new CouponWithPercentage(25);
            Console.WriteLine(coupon2.calculate(10000));

            Coupon coupon3 = new CouponWithMaxNominal(90, 3000);
            Console.WriteLine(coupon3.calculate(10000));

            Coupon coupon4 = new CouponWithCashback(500);
            Console.WriteLine(coupon4.calculate(10000));

        }
    }
}
