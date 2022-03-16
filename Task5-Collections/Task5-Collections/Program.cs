using System.Diagnostics.CodeAnalysis;

namespace Task5_Collections
{
    public class ProductEqualityComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            return obj.Name.GetHashCode();
        }
    }

    public class ProductComparer : IComparer<Product>
    {
        public int Compare(Product? x, Product? y)
        {
            return (x.Name.CompareTo(y.Name));
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            products.Add("3Y115708", new Product("3Y115708", null, 10));
            products.Add("2Y110978", new Product("2Y110978", "This product is a medicine", 34));

            foreach (var item in products)
                Console.WriteLine("For the key {0} there is the product {1}", item.Key, item.Value.ToString());
        }
    }
}

