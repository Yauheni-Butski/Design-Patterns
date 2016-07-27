using Decorator.Decorators.Base;
using Decorator.Elements.Base;

namespace Decorator.Decorators
{
    public class BorderWidthStyle : StyleDecorator
    {
        public BorderWidthStyle(HtmlElement htmlElement, int value) : base(htmlElement)
        {
            _key = "border-width";
            _value = value + "px";
        }
    }
}
