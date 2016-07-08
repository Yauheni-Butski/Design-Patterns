using System;

using FactoryMethod.Viewers.Base;

namespace FactoryMethod.ViewCreators.Base
{
    public abstract class ViewManager
    {
        public abstract IViewer GetViewer(string fileName);

        public void Open(string fileName)
        {
            Console.WriteLine("Searching needed viewer for " + fileName);
            var viewer = GetViewer(fileName);

            if (viewer != null)
            {
                viewer.Open();
            }
            else
            {
                Console.WriteLine("Sorry, but this manager doesn't know about this file extension");
            }
        }
    }
}
