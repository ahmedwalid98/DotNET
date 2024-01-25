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

        // var result = ProductList.Max(p => p.UnitPrice);
        // result = ProductList.Min(p => p.UnitPrice);
        // result = ProductList.Average(p => p.UnitPrice);
        //
        // Console.WriteLine(result);

        #endregion
        
        #region Generators operators

        // var result = Enumerable.Range(0, 10);
        // result = Enumerable.Empty<int>();
        // result = Enumerable.Repeat(3, 10);

        #endregion

        #region Select many

        // var nameList = new List<string>() { "Ahmed walid", "Mohammed walid", "Mena walid" };
        // var result = nameList.SelectMany(fn => fn.Split(' '));
        //
        // result = from fn in nameList
        //     from ln in fn.Split(' ')
        //     select ln;

        #endregion

        #region Casting operators
        // ToList - ToArray - ToHashSet - ToDictinoary
        // List<Product> result = ProductList.Where(p => p.UnitsInStock == 0).ToList();
        // Product[] result = ProductList.Where(p => p.UnitsInStock == 0).ToArray();

        #endregion

        #region Set operators

        // var seq1 = Enumerable.Range(0, 100);
        // var seq2 = Enumerable.Range(50, 100);
        //
        // var result = seq1.Union(seq2);
        // result = seq1.Concat(seq2);
        // result = seq1.Distinct();
        // result = seq1.Except(seq2);
        // result = seq1.Intersect(seq2);

        #endregion
        
        #region Quantifiers , return boolean

        Console.WriteLine(ProductList.Any()); // return true if input seq has atleast 1 element

        Console.WriteLine(ProductList.Any(p => p.UnitPrice > 200));
        // return true if input seq have atleast 1 element matches the condition

        Console.WriteLine(ProductList.All(p => p.UnitsInStock > 0));
        // return true of all elements in input seq matches the conditions 

        var seq01 = Enumerable.Range(0, 100);
        var seq02 = Enumerable.Range(50, 100);

        Console.WriteLine( seq01.SequenceEqual(seq02));





        #endregion
        
        foreach (var product in result)
        {
            Console.WriteLine(product);
        }
    }
}