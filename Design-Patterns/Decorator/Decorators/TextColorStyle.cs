using System.Collections.Generic;

using Decorator.Decorators.Base;
using Decorator.Elements.Base;

namespace Decorator.Decorators
{
    public enum TextColors
    {
        Red,
        Green,
        Blue,
        Pink
    }

    public class TextColorStyle : StyleDecorator
    {
        private readonly Dictionary<string, string> _colorCodes = new Dictionary<string, string>()
        {
            { "Red", "#FF0000" },
            { "Green", "#00FF00" },
            { "Blue", "#0000FF" },
            { "Pink", "#C48189" }

        };

        public TextColorStyle(HtmlElement htmlElement, TextColors value) : base(htmlElement)
        {
            _key = "color";
            var color = value.ToString();
            _value = _colorCodes[color];
        }
    }
}
