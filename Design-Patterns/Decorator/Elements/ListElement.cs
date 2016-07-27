using Decorator.Elements.Base;

namespace Decorator.Elements
{
    public class ListElement : HtmlElement
    {
        private readonly bool _isOrdered;

        public new string Name => _isOrdered ? "ol" : "ul";

        public ListElement(bool isOrdered) : base(string.Empty, true)
        {
            _isOrdered = isOrdered;
        }

        public override string GetRenderString()
        {
            var renderString = IsPair
                               ? string.Format("<{0}></{0}>", Name)
                               : string.Format("<{0}/>", Name);

            //Element can render this his specific elements.For example < li > and etc

            return renderString;
        }
    }
}
