using Decorator.Decorators.Base;
using Decorator.Elements.Base;

namespace Decorator.Decorators
{
    public class WidthStyle : StyleDecorator
    {
        public WidthStyle(HtmlElement htmlElement, int value) : base(htmlElement)
        {
            _key = "width";
            _value = value + "px";
        }
    }
}
