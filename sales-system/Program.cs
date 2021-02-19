using System;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesMan sm = new SalesMan();
            sm.SetAgeN(20);
            sm.Name = "Luis";

            SalesMan sm1 = new SalesMan();
            sm1.SetAgeN(20);
            sm1.Name = "Manuela";

            SalesMan sm2 = new SalesMan();
            sm2.SetAgeN(18);
            sm2.Name = "Edwar";

            SalesMan sm3 = new SalesMan();
            sm3.SetAgeN(56);
            sm3.Name = "Maximo";

            Product pd = new Product();
            pd.Name = "auriculares";
            pd.Price = 42000;

            Product pd1 = new Product();
            pd1.Name = "Monitor";
            pd1.Price = 652000;

            Product pd2 = new Product();
            pd2.Name = "Mouse";
            pd2.Price = 20000;

            Product pd3 = new Product();
            pd3.Name = "Teclado";
            pd3.Price = 50000;

            Sale sl = new Sale();
            sl.Product = pd;
            sl.Seller = sm;

            Sale sl1 = new Sale();
            sl1.Product = pd1;
            sl1.Seller = sm1;

            Sale sl2 = new Sale();
            sl2.Product = pd2;
            sl2.Seller = sm2;

            Sale sl3 = new Sale();
            sl3.Product = pd3;
            sl3.Seller = sm3;

            float SaleTotal;

            SaleTotal = sl.Product.Price + sl1.Product.Price + sl2.Product.Price + sl3.Product.Price;


            System.Console.WriteLine("El vendedor "  + sl.Seller.Name +  " hizo la venta de unos " + sl.Product.Name + " por el valor de " + sl.Product.Price );
            System.Console.WriteLine("La vendedora " + sl1.Seller.Name + " hizo la venta de unos " + sl1.Product.Name + " por el valor de " + sl1.Product.Price);
            System.Console.WriteLine("El vendedor "  + sl2.Seller.Name + " hizo la venta de unos " + sl2.Product.Name + " por el valor de " + sl2.Product.Price);
            System.Console.WriteLine("El vendedor " + sl3.Seller.Name + " hizo la venta de unos " + sl3.Product.Name + " por el valor de " + sl3.Product.Price);
            System.Console.WriteLine("El valor total de ventas es generado fue por " + SaleTotal );

        }
    }
}
