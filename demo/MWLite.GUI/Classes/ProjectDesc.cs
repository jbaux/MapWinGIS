namespace MWLite.GUI.Classes
{
    public class ProjectDesc
    {
        private string displayName;
        private string path;

        public string DisplayName { get => displayName; set => displayName=value; }
        public string Path { get => path; set => path=value; }

        public ProjectDesc(string path)
        {
            DisplayName = System.IO.Path.GetFileNameWithoutExtension(path);
            Path = path;
        }
    }
}
