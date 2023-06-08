using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins_for_Polytoria_Creator.Objects {
    public class ModMeta {
        public string ModDisplayName { get; set; } = "Unknown";
        public string ModFolderName { get; set; } = "Unknown";

        public int MinCreatorVersion { get; set; } = 0;
        public long MaxCreatorVersion { get; set; } = long.MaxValue;
        public ModType ModType { get; set; } = ModType.Mod;

        public override string ToString() {
            return ModType.ToString() + " | " + ModDisplayName +
                ((Program.CreatorVersionNumeric > MaxCreatorVersion) ? " (OUTDATED!)" : "");
        }
    }

    public enum ModType {
        Mod,
        UserLib
    }
}
