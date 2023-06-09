namespace Plugins_for_Polytoria_Creator.Utils {
    internal class DirectoryUtils {
        public static void CopyRecursive(string path, string targetPath) {
            foreach (var file in Directory.GetFiles(path)) {
                var fileTargetPath = Path.Join(targetPath, Path.GetFileName(file));

                if (File.Exists(fileTargetPath))
                    File.Delete(fileTargetPath);

                File.Copy(file, fileTargetPath);
            }

            foreach (var dir in Directory.GetDirectories(path)) {
                var newTargetPath = Path.Join(targetPath, Path.GetFileName(dir));

                if (!Directory.Exists(newTargetPath))
                    Directory.CreateDirectory(newTargetPath);

                CopyRecursive(dir, newTargetPath);
            }
        }
    }
}
