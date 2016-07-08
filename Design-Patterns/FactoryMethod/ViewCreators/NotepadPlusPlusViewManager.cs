using System.Collections.Generic;

using FactoryMethod.ViewCreators.Base;
using FactoryMethod.Viewers;
using FactoryMethod.Viewers.Base;

namespace FactoryMethod.ViewCreators
{
    public class NotepadPlusPlusViewManager : ViewManager
    {
        private readonly List<string> _availableExtensions;

        public NotepadPlusPlusViewManager()
        {
            _availableExtensions = new List<string>()
            {
                "txt",
                "cs",
                "xml",
                "html"
            };
        }

        public override IViewer GetViewer(string fileName)
        {
            var fileExtension = fileName.Split('.')[1];

            return _availableExtensions.Contains(fileExtension) ? new NotepadPlusPlusViewer(fileName) : null;
        }
    }
}
