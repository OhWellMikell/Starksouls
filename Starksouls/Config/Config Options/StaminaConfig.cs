using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starksouls.Config.Config_Options
{
    internal class StaminaConfig
    {
        public bool Enabled { get; set; } = true;
        public int StaminaRegenPercent { get; set; } = 20;
        public int StaminaAfterPassOutPercent { get; set; } = 20;
    }
}
