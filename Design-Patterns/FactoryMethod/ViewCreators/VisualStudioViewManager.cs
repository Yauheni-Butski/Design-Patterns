using FactoryMethod.ViewCreators.Base;
using FactoryMethod.Viewers;
using FactoryMethod.Viewers.Base;

namespace FactoryMethod.ViewCreators
{
    public class VisualStudioiewManager : ViewManager
    {
        public override IViewer GetViewer(string fileName)
        {
            var fileExtension = fileName.Split('.')[1];

            switch (fileExtension)
            {
                case "sln":
                case "csproj":
                    return new VisualStudioViewer(fileName);
                case "dtsx":
                    return new VisualDataToolViewer(fileName);
                default:
                    //It is bad practice of return 'Null' and force caller code check null.
                    //It is better to allow return some default viewer. But for test code, I will return null. 
                    return null;
            }
        }
    }
}
