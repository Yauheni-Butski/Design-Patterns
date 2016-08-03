using System;

using FactoryMethod.Viewers.Base;

namespace FactoryMethod.Viewers
{
    public class VisualDataToolViewer : Viewer
    {
        private readonly string _fileName;

        public VisualDataToolViewer(string fileName) : base("Visual Data Tool", "2012", "2012")
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
