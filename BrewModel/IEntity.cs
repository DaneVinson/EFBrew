using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewModel
{
    public interface IEntity
    {
        int Id { get; set; }
        byte[] RowVersion { get; set; }
    }
}
