using System;

using FactoryMethod.Viewers.Base;

namespace FactoryMethod.Viewers
{
    public class ExcelViewer : Viewer
    {
        private readonly string _fileName;

        public ExcelViewer(string fileName) : base("Excel", "2003", "2003")
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