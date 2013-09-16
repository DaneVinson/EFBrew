using BrewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrewConsole
{
    /// <summary>
    /// Inherit from the DropAndCreateDbInitializer to set up seed data.
    /// </summary>
    public class MigrationInitializer : DropAndCreateDbInitializer<MigrationBrewContext>
    {
        protected override void Seed(MigrationBrewContext context)
        {
            base.Seed(context);
        }
    }
}
