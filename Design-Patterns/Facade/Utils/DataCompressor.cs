using System.Xml.Linq;

namespace Facade.Utils
{
    public class DataCompressor
    {
        public void Archive(XDocument cartridge, string fileOutputName)
        {
            //Create output stream for archive, select compression level, copy cartridge data into archive with compression...
            //....
            //But in our test case we just do save XDocument into file with needed file name.

            cartridge.Save(fileOutputName);
        }
    }
}
