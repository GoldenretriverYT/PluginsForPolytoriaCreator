using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugins_for_Polytoria_Creator.Utils {
    internal class ErrorUtils {
        public static void CrashFatal(string msg) {
            MessageBox.Show(msg, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(-1);
        }

        public static void ShowWarn(string msg) {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string msg) {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
