# Open Closed Principle
Setiap entitas software, baik itu (Class, module, fungsi) terbuka untuk perluasan, namun tertutup untuk modifikasi.

## Tujuan
Untuk menghindari keretakan software dikarenakan perubahan secara langsung terhadap sebuah class, module, ataupun function.

# COUPON WITHOUT OCP

- Class Coupon

```csharp
class Coupon
    {
        public double discNominal = 0;
        public double priceNett(double originPrice)
        {
            double net = 0;
            net = (100 - discPercentage) * originPrice / 100;
            return net;
        }
    }
```

- Class Program

``` csharp
class Program
  {
      static void Main(string[] args)
      {


          Coupon coupon1 = new Coupon();
          coupon1.discNominal = 2000;
          Console.WriteLine(coupon1.priceNett(10000));
      }
  }
```

# COUPON WITH OCP
- class Coupon.cs
```csharp
public abstract class Coupon
  {
      public abstract double calculate(double originPrice);
  }
```

- class CouponWithNominal.cs
```csharp
class CouponWithNominal : Coupon
    {
        public double discNominal;

        public CouponWithNominal(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }
    }
```

-class Program.cs
```csharp
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Coupon coupon1 = new CouponWithNominal(2000);
            Console.WriteLine(coupon1.calculate(10000));
        }
    }
```