using System.IO;
using BetterToDo.Properties;

namespace BetterToDo
{
    public class TodoFileWatcher
    {
        private readonly FileSystemWatcher fileSystemWatcher;

        public FileSystemWatcher FileSystemWatcher
        {
            get { return fileSystemWatcher; }
        }

        public TodoFileWatcher(TodoFile todoFile)
        {
            var path = Path.GetDirectoryName(Settings.Default.FileLocation);
            var filename = Path.GetFileName(Settings.Default.FileLocation);

            if (path == null)
            {
                // something went wrong with the settings
                return;
            }

            fileSystemWatcher = new FileSystemWatcher(path, filename) {EnableRaisingEvents = true};
            fileSystemWatcher.Changed += delegate { todoFile.Dirty = true; };
            fileSystemWatcher.Deleted += delegate { todoFile.Dirty = true; };
        }
    }
}
