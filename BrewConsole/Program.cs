using BrewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Database.SetInitializer(new MigrationInitializer());
                using (var context = new MigrationBrewContext())
                {
                    var beer = context.Beers
                                    .Include(b => b.Servings)
                                    .Include(b => b.BeerStyle)
                                    .Include(b => b.Brewery)
                                    .FirstOrDefault();
                    Console.WriteLine("{0} from {1}", beer.Name, beer.Brewery.Name);
                    Console.WriteLine("Serving Types: {0}", String.Join(", ", beer.Servings.Select(s => s.Name).ToArray()));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} - {1}", ex.GetType(), ex.Message);
                Console.WriteLine(ex.StackTrace ?? String.Empty);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("...");
                Console.ReadKey();
            }
        }
    }
}
