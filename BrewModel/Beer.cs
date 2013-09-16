using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    public class Beer : AbstractEntity
    {
        /// <summary>
        /// Alcohol by volume.
        /// </summary>
        public decimal Abv { get; set; }

        /// <summary>
        /// The BeerStyle of the beer.
        /// </summary>
        public virtual BeerStyle BeerStyle { get; set; }

        /// <summary>
        /// BeerStyle.Id
        /// </summary>
        public int BeerStyleId { get; set; }

        /// <summary>
        /// The brewery the beer is brewed at.
        /// </summary>
        public virtual Brewery Brewery { get; set; }

        /// <summary>
        /// Brewery.Id
        /// </summary>
        public int BreweryId { get; set; }

        /// <summary>
        /// The name of the beer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The serving style the beer is available in.
        /// </summary>
        public virtual ICollection<Serving> Servings { get; set; }
    }
}
