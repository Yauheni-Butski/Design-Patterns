namespace Iterator.Iterators.Interface
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}