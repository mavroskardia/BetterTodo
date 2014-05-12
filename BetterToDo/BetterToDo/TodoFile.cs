using System.IO;
using BetterToDo.Properties;

namespace BetterToDo
{
    public class TodoFile
    {
        public bool Dirty = false;

        public TodoFile()
        {
            string f = Settings.Default.FileLocation;
            if (!File.Exists(f))
                File.WriteAllText(f, "");
        }

        public string GetFileContents()
        {
            return File.ReadAllText(Settings.Default.FileLocation);
        }

        public void SaveFileContents(string content)
        {
            File.WriteAllText(Settings.Default.FileLocation, content);
            Dirty = false;
        }
    }
}
