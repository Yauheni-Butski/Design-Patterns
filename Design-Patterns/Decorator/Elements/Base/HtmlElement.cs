namespace Decorator.Elements.Base
{
    public abstract class HtmlElement
    {
        public string Name { get; set; }
        public bool IsPair { get; set; }

        protected HtmlElement(string name, bool isPair)
        {
            Name = name;
            IsPair = isPair;
        }

        public abstract string GetRenderString();
    }
}
