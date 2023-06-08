using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Plugins_for_Polytoria_Creator.Utils {
    internal class VersionUtils {
        private static Regex versionRegex = new Regex("[._]");

        /// <summary>
        /// Replaces dots and underscores with 0 and returns the final text parsed as int.
        /// </summary>
        /// <param name="versionString"></param>
        /// <returns></returns>
        public static long GetNumericVersion(string versionString) {
            versionString = versionRegex.Replace(versionString, "0");

            if(!long.TryParse(versionString, out var version)) {
                throw new ArgumentException($"Version string '{versionString}' either contained invalid characters or is too long.");
            }

            return version;
        }
    }
}
