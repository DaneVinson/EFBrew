using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    public class Brewery : AbstractEntity
    {
        /// <summary>
        /// The beers brewed by the brewery.
        /// </summary>
        public virtual ICollection<Beer> Beers { get; set; }

        /// <summary>
        /// The brewery's location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The name of the brewery.
        /// </summary>
        public string Name { get; set; }
    }
}
