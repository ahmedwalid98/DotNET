using static Day02_LINQ.ListGenerators;
namespace Day02_LINQ;

class Program
{
    static void Main(string[] args)
    {
        #region Where

        // var result = ProductList.Where(p => p.UnitsInStock == 0);
        // result = from p in ProductList
        //     where p.UnitsInStock == 0
        //     select p;
        //
        // result = ProductList.Where(p => (p.UnitsInStock == 0) && (p.ProductID < 10));
        //
        // result = from p in ProductList
        //     where (p.UnitsInStock == 0) && (p.ProductID < 10)
        //     select p;
        //
        // result = ProductList.Where((p, i) => p.UnitsInStock == 0 && i < 10);

        #endregion

        #region Select

        // var result = ProductList.Select(p => p.ProductName);
        // result = from p in ProductList
        //     select p.ProductName;

        // var result = ProductList.Where(p => p.UnitsInStock == 0).Select(p => new { Id = p.ProductID, p.ProductName });
        // result = from p in ProductList
        //     where p.UnitsInStock == 0
        //     select new { Id = p.ProductID, p.ProductName };

        // var result = ProductList.Where(p => p.UnitsInStock == 0)
        //     .Select(p => new Product
        //     {
        //         ProductID = p.ProductID,
        //         ProductName = p.ProductName,
        //         Category = p.Category,
        //         UnitsInStock = p.UnitsInStock,
        //         UnitPrice = p.UnitPrice * 0.9M
        //     });

        // var result = ProductList.Select(p => new { Name = p.ProductName, Price = p.UnitPrice * 1.9M })
        //     .Where(p => p.Price > 40);
        //
        // result = from p in ProductList
        //     select new { Name = p.ProductName, Price = p.UnitPrice * 1.9M }
        //     into TaxedList
        //     where TaxedList.Price > 40
        //    select TaxedList;
        #endregion

        #region OrderBy

        // var result = ProductList.OrderBy(p => p.UnitsInStock)
        //     .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });
        //
        // result = from p in ProductList
        //     orderby p.UnitsInStock
        //     select new {p.ProductName, p.UnitsInStock, p.UnitPrice};
        //
        // result = ProductList.OrderByDescending(p => p.UnitsInStock)
        //     .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });
        //
        // result = from p in ProductList
        //     orderby p.UnitsInStock descending 
        //     select new {p.ProductName, p.UnitsInStock, p.UnitPrice};
        //
        // result = ProductList.OrderByDescending(p => p.UnitsInStock)
        //     .ThenBy(p => p.UnitPrice)
        //     .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });
        //
        // result = from p in ProductList
        //     orderby p.UnitsInStock descending, p.UnitPrice
        //     select new {p.ProductName, p.UnitsInStock, p.UnitPrice};

        #endregion

        #region Immediate Execution

        // var result = ProductList.First();
        // result = ProductList.Last();
        //
        // var emptyList = new List<Product>();

        // result = emptyList.First();
        // if list is empty it will throw exeption
        // we use FirstOrDEfault
        // result = emptyList.FirstOrDefault();
        //
        // result = ProductList.First(p => p.UnitsInStock == 0);
        // result = ProductList.Last(p => p.UnitsInStock == 0);
        //
        // result = (from p in ProductList
        //     where p.UnitsInStock == 0
        //     select p).First();
        //
        // Console.WriteLine(result?.ProductName ?? "NA");

        #endregion

        #region Aggregate - Immediate Execution

        // var result = ProductList.Count();
        // result = ProductList.Count(p => p.UnitsInStock == 0);

        var result = ProductList.Max(p => p.UnitPrice);
        result = ProductList.Min(p => p.UnitPrice);
        result = ProductList.Average(p => p.UnitPrice);

        Console.WriteLine(result);

        #endregion

        // foreach (var product in result)
        // {
        //     Console.WriteLine(product);
        // }
    }
}