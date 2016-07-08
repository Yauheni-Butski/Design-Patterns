using System;

using FactoryMethod.Viewers.Base;

namespace FactoryMethod.Viewers
{
    public class Word2010Viewer : Viewer
    {
        private readonly string _fileName;

        public Word2010Viewer(string fileName) : base("Word", "10", "2010")
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