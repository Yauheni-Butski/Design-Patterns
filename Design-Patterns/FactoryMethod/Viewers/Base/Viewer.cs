namespace FactoryMethod.Viewers.Base
{
    public abstract class Viewer : IViewer
    {
        public string Name { get; private set; }
        public string Version { get; private set; }
        public string Year { get; private set; }

        protected Viewer(string name, string version, string year)
        {
            Name = name;
            Version = version;
            Year = year;
        }

        public abstract void Open();
    }
}
