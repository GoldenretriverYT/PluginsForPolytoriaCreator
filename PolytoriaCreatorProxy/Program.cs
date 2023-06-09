using System.Diagnostics;
using System.Reflection;

namespace PolytoriaCreatorProxy {
    /// <summary>
    /// Looking at this code, you may wonder why this is needed. And I can tell you why! well roughly at least.
    /// When the Polytoria Creator gets launched from the browser, the wrong working directory is
    /// set (to 'C:\Windows\System32') - this messes up MelonLoader and therefore we have to make
    /// a small proxy app that starts the Polytoria Creator using the correct working directory.
    /// 
    /// thanks for listening to my ted talk.
    /// </summary>
    internal class Program {
        static void Main(string[] args) {
            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Join(dir, "Polytoria Creator Original.exe");

            // Start the process
            ProcessStartInfo psi = new(path);
            psi.Arguments = string.Join(" ", args);
            psi.WorkingDirectory = dir;

            Process proc = Process.Start(psi);
            Console.Clear();
            Console.WriteLine("Polytoria Creator Proxy - do not close.");
        }
    }
}