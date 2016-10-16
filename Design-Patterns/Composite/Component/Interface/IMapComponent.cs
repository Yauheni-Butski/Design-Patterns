namespace Composite.Component.Interface
{
    public interface IMapComponent
    {
        string Name { get; }
        int Code { get; }
        string Type { get; }
        int Number { get; }
        void Show();
        IMapComponent FindChildByName(string name);
        void AddComponent(IMapComponent component);
    }
}