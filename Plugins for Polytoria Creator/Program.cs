using Plugins_for_Polytoria_Creator.Utils;
using System.Reflection;

namespace Plugins_for_Polytoria_Creator {
    internal static class Program {
        public static string CreatorBasePath { get; private set; } =
            Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Polytoria", "Creator");

        /// <summary>
        /// The target version specifies the minimum version and the version
        /// PfPC should be used on.
        /// </summary>
        public const long TargetVersion = 103037; // 1.3.37

        public static string CreatorVersion { get; private set; } = "Unknown!";
        public static long CreatorVersionNumeric { get; private set; } = -1;
        public static string InstalledCreatorPath { get; private set; } = CreatorBasePath;

        public static string AppPath { get; private set; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string ProxyPath { get; private set; } = Path.Join(AppPath, "PolytoriaCreatorProxy.exe");

        public static string LocalModsPath { get; private set; } = Path.Join(AppPath, "installed");


        public static bool LoaderInstalled => File.Exists(Path.Join(InstalledCreatorPath, "version.dll"));

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if(!Directory.Exists(CreatorBasePath)) {
                ErrorUtils.CrashFatal($"Could not find Polytoria Creator installation.\n" +
                    $"Make sure to install Polytoria Creator first!\n\n\n" +
                    $"Searched for:\n{CreatorBasePath}");
            }

            (string version, long versionNumeric) = FindLatestVersion();
            InstalledCreatorPath = Path.Join(CreatorBasePath, version);

            if(versionNumeric < TargetVersion) {
                ErrorUtils.CrashFatal($"Your latest installed version of the Polytoria Creator is not supported.\n" +
                    $"Please update your installation.");
            }else if(versionNumeric > TargetVersion) {
                ErrorUtils.ShowWarn($"This version of PfPC is not targetting Polytoria Creator v{version}!\n" +
                    $"You may encounter some problems. Make sure to update PfPC if an update is available.");
            }

            if(!File.Exists(ProxyPath)) {
                ErrorUtils.CrashFatal($"Was not able to find proxy executable.\n" +
                    $"Please reinstall PfPC!");
            }

            if(!Directory.Exists(LocalModsPath)) {
                Directory.CreateDirectory(LocalModsPath);
            }

            CreatorVersion = version;
            CreatorVersionNumeric = versionNumeric;
            

            Application.Run(new StartForm());
        }

        static (string version, long versionNumeric) FindLatestVersion() {
            string[] subdirs = Directory.GetDirectories(CreatorBasePath);
            string highestVersion = "1.0.0";
            long highestVersionNumeric = 10000;

            if(subdirs.Length == 0) {
                ErrorUtils.CrashFatal($"Could not find any installations in Polytoria Creator directory.\n" +
                    $"Make sure to install a Polytoria Creator version first!");
            }

            try {
                foreach (var subdir in subdirs) {
                    var version = Path.GetFileName(subdir);
                    var versionNumeric = VersionUtils.GetNumericVersion(version);

                    if (versionNumeric > highestVersionNumeric) {
                        highestVersion = version;
                        highestVersionNumeric = versionNumeric;
                    }
                }
            } catch(ArgumentException argException) {
                ErrorUtils.CrashFatal($"Invalid version in creator folder found.\n" +
                    $"Please clean up the folder or reinstall the creator and try again.\n\n" +
                    $"Error: {argException.Message}");
            }

            return (highestVersion, highestVersionNumeric);
        }
    }
}