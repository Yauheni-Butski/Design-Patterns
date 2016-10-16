using Composite.Component.Interface;

namespace Composite.Component
{
    public abstract class MapComponent : IMapComponent
    {
        public virtual string Name { get; }
        public virtual int Code { get; }
        public virtual string Type { get; }
        public virtual int Number { get; }

        public abstract void Show();
        public virtual IMapComponent FindChildByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public virtual void AddComponent(IMapComponent component)
        {
            throw new System.NotImplementedException();
        }
    }
}
