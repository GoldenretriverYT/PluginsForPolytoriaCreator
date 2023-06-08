using System.Diagnostics;
using System.Reflection;

namespace PolytoriaCreatorProxy {
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