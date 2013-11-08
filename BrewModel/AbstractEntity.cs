using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    /// <summary>
    /// Abstract base class for all entity data model classes.
    /// </summary>
    public abstract class AbstractEntity
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Concurrency control property.
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
