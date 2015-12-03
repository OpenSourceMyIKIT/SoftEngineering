using System.Collections.Generic;

namespace Model
{
    public abstract class Product
    {
        private readonly List<Detail> _details = new List<Detail>();
        private static readonly List<Product> Products = new List<Product>();
        public abstract string Info();

        public abstract string Info(int i, string content);

        public int DetailsCount => _details.Count;

        protected int Weight { get; }

        public string SerialNumber { get; }

        public string Company { get; }

        public static int ProductsCount => Products.Count;

        public static void AddProduct (Product product)
        {
            Products.Add(product);
        }

        public static Product GetProduct (int i)
        {
            return Products[i];
        }

        public void AddDetail (Detail detail)
        {
            _details.Add(detail);
        }

        protected Product(int weight, string serialNumber, string company, Detail detail)
        {
            Weight = weight;
            SerialNumber = serialNumber;
            Company = company;
            AddDetail(detail);
        }
    }
}