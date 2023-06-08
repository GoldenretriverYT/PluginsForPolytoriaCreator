using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins_for_Polytoria_Creator.Utils {
    internal class SizeUtils {
        public static float GetSizeInMegabytes(long bytes) {
            return (float)bytes / 1024 / 1024;
        }
    }
}
