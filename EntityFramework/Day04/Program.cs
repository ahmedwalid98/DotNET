using Day04.Models;

namespace Day04
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            #region Selection
            var stocks = _context.Stocks.ToList();

            /* foreach (var stock in stocks)
             {
                 Console.WriteLine(stock.Name);
             }
 */
            var stockByid = _context.Stocks.Find(100);
            /*Console.WriteLine($"ID: {stockByid?.Id}: {stockByid?.Name}");*/

            var singleStock = _context.Stocks.SingleOrDefault(i => i.Id == 100);
            // Console.WriteLine($"ID: {singleStock?.Id}: {singleStock?.Name}");

            var firstStock = _context.Stocks.FirstOrDefault(i => i.Name.StartsWith("A"));
            // Console.WriteLine(firstStock?.Name);

            var lastItem = _context.Stocks.OrderBy(i => i.Sector).LastOrDefault();
            // Console.WriteLine(lastItem?.Name);

            var stocksOver500 = _context.Stocks.Where(i => i.Id > 500);
            /*foreach (var stock in stocksOver500)
            {
                Console.WriteLine(stock.Name);
            }*/
            // check if at least one record id bigger than 500
            var anyStock = _context.Stocks.Any(i => i.Id > 500);
            // check if all records id is bigger than 500
            var allStock = _context.Stocks.All(i => i.Id > 500);
            #endregion

            #region Aggregate
            var avgStocks = _context.Stocks.Average(i => i.Id);

            var countStocks = _context.Stocks.Count();

            var sumCounts = _context.Stocks.Sum(i => i.Id);

            var minStocks = _context.Stocks.Min(i => i.Id);

            var maxStocks = _context.Stocks.Max(i => i.Id);
            #endregion

            #region order by
            var ascOrder = _context.Stocks.OrderBy(i => i.Balance);
            var descOrder = _context.Stocks.OrderBy(i => i.Balance);
            #endregion

            #region projection
            var selectStocks = _context.Stocks.Select(i => new { StockId = i.Id, StockName = i.Name });
            var distinctStocks = _context.Stocks.Select(i => new {i.Industry}).Distinct();
            var skipTakeStocks = GetData(1, 10);
            /*foreach (var item in skipTakeStocks)
            {
                Console.WriteLine(item.Id);
            }*/
            var groupByStocks = _context.Stocks
                .GroupBy(i => i.Industry)
                .Select(i => new {Name = i.Key, Count =  i.Count()});
            /*
                        foreach (var item in groupByStocks)
                        {
                            Console.WriteLine($"Name = {item.Name} - Count = {item.Count}");
                        }
            */
            #endregion

            #region Joins
            var books = _context.Books
                .Join(
                    _context.Authors,
                    book => book.AuthorId,
                    author => author.Id,
                    (book, author) => new
                    {
                        BookName = book.Name,
                        AuthorName = author.Name,
                        author.NationalityId
                    }
                ).Join(
                    _context.Nationalities,
                    book => book.NationalityId,
                    nationality => nationality.Id,
                    (book, nationality) => new
                    {
                        book.BookName,
                        book.AuthorName,
                        nationality.Name,
                    }
                    
                    );

            /*foreach (var item in books)
            {
                Console.WriteLine($"{item.BookName} - {item.AuthorName} - {item.Name}");
            }*/
            #endregion

        }

        public static List<Stock> GetData(int pageNumber, int pageSize)
        {
            var _context = new ApplicationDbContext();
            return _context.Stocks.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}
