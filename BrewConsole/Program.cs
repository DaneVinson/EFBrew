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
                RefreshDatabase();
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

        private static void RefreshDatabase()
        {
            Database.SetInitializer(new MigrationInitializer());
            using (var context = new MigrationBrewContext())
            {
                var brewery = context.Breweries.FirstOrDefault();
            }
        }
    }
}
