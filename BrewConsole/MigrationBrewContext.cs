using BrewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewConsole
{
    /// <summary>
    /// Simle inheritance of BrewModel.BrewContext to enable data migrations in the console app.
    /// </summary>
    public class MigrationBrewContext : BrewContext { }
}
