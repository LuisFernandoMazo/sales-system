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
            pd.Name = "Headphones";
            pd.SetPrice(40000);

            Product pd1 = new Product();
            pd1.Name = "Monitor Samsung";
            pd1.SetPrice(652000);

            Product pd2 = new Product();
            pd2.Name = "Mouse";
            pd2.SetPrice(20000);

            Product pd3 = new Product();
            pd3.Name = "Keyboard";
            pd3.SetPrice(150000);

            Sale sl = new Sale();
            sl.Product = pd;
            sl.Seller = sm;
            sl.comment = "Kotion Each G2000 Usb Microfono Ledl";

            Sale sl1 = new Sale();
            sl1.Product = pd1;
            sl1.Seller = sm1;
            sl.comment = "Led Ref: Ls24f350fh ";


            Sale sl2 = new Sale();
            sl2.Product = pd2;
            sl2.Seller = sm2;
            sl.comment = "Mouse Ergonómico Microsoft Negro";

            Sale sl3 = new Sale();
            sl3.Product = pd3;
            sl3.Seller = sm3;
            sl.comment = "Metallic Gamer Keyboard Wb-539 Backlit Mechanical";

            float SaleTotal;

            SaleTotal = sl.Product.Price + sl1.Product.Price + sl2.Product.Price + sl3.Product.Price;


           
            System.Console.WriteLine("The total sales value is generated was by  " + SaleTotal );

        }
    }
}
