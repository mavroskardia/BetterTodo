using System.IO;
using BetterToDo.Properties;

namespace BetterToDo
{
    public class TodoFileWatcher
    {
        private FileSystemWatcher fileSystemWatcher;

        public FileSystemWatcher FileSystemWatcher
        {
            get { return fileSystemWatcher; }
        }

        public TodoFileWatcher(TodoFile todoFile)
        {
            string path = Path.GetDirectoryName(Settings.Default.FileLocation);
            string filename = Path.GetFileName(Settings.Default.FileLocation);
            fileSystemWatcher = new FileSystemWatcher(path, filename);
            fileSystemWatcher.EnableRaisingEvents = true;
            fileSystemWatcher.Changed += delegate(object sender, FileSystemEventArgs e) { todoFile.Dirty = true; };
            fileSystemWatcher.Deleted += delegate(object sender, FileSystemEventArgs e) { todoFile.Dirty = true; };
        }
    }
}
