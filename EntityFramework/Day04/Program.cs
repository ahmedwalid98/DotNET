namespace Day04
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

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
            foreach (var stock in stocksOver500)
            {
                Console.WriteLine(stock.Name);
            }
        }
    }
}
