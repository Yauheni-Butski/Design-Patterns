using FactoryMethod.ViewCreators.Base;
using FactoryMethod.Viewers;
using FactoryMethod.Viewers.Base;

namespace FactoryMethod.ViewCreators
{
    public class MsOfficeViewManager : ViewManager
    {
        public override IViewer GetViewer(string fileName)
        {
            var fileExtension = fileName.Split('.')[1];

            switch (fileExtension)
            {
                case "doc":
                    return new Word2007Viewer(fileName);
                case "docx":
                    return new Word2010Viewer(fileName);
                case "xls":
                    return new ExcelViewer(fileName);
                default:
                    //It is bad practice of return 'Null' and force caller code check null.
                    //It is better to allow return some default viewer. But for test code, I will return null. 
                    return null;
            }
        }
    }
}
