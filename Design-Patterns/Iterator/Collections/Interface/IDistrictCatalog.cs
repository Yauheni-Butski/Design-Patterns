using Iterator.Iterators.Interface;

namespace Iterator.Collections.Interface
{
    public interface IDistrictCatalog
    {
        IIterator CreateIterator();
        string GetDistrictName();
    }
}