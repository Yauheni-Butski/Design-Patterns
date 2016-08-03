using System;

using FactoryMethod.Viewers.Base;

namespace FactoryMethod.Viewers
{
    public class VisualStudioViewer : Viewer
    {
        private readonly string _fileName;

        public VisualStudioViewer(string fileName) : base("Visual Studio", "2015", "2016")
        {
            _fileName = fileName;
        }

        public override void Open()
        {
            string message = string.Format("Open {0} in {1}. Version: {2}. Year: {3}", _fileName, Name, Version, Year);
            Console.WriteLine(message);
        }
    }
}