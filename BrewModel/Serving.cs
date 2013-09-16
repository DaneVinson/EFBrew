using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    public class Serving : AbstractEntity
    {
        /// <summary>
        /// The beers that are available in this serving type.
        /// </summary>
        public virtual ICollection<Beer> Beers { get; set; }

        /// <summary>
        /// The name of the serving, e.g. Draft, 22 oz Bottle.
        /// </summary>
        public string Name { get; set; }
    }
}
