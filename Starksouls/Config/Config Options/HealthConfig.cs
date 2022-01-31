using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starksouls.Config.Config_Options
{
    internal class HealthConfig
    {
        public bool Enabled { get; set; } = true;
        public int HealthRegenPercent { get; set; } = 20;
        public int HealthAfterDeathPercent { get; set; } = 20;
    }
}
