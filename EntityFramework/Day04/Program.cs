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
            #endregion
        }
    }
}
