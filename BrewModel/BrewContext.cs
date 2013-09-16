using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    public partial class BrewContext : DbContext
    {
        public IDbSet<Beer> Beers { get; set; }
        public IDbSet<BeerStyle> BeerStyles { get; set; }
        public IDbSet<Brewery> Breweries { get; set; }
        public IDbSet<Serving> Servings { get; set; }
    }
}
