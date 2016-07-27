using Decorator.Elements.Base;

namespace Decorator.Decorators.Base
{
    public abstract class StyleDecorator : HtmlElement
    {
        protected readonly HtmlElement _htmlElement;
        protected string _key;
        protected string _value;

        protected StyleDecorator(HtmlElement htmlElement) : base(htmlElement.Name,
                                                                 htmlElement.IsPair)
        {
            _htmlElement = htmlElement;
        }

        public override string GetRenderString()
        {
            //Decorator in action
            var renderString = _htmlElement.GetRenderString();

            var isStyleExist = renderString.Contains("style=\"");
            if (isStyleExist)
            {
                var styleQuoteStartPosition = renderString.IndexOf('"');
                var elementStart = renderString.Substring(0, styleQuoteStartPosition);
                var elementEnd = renderString.Substring(styleQuoteStartPosition + 1);

                elementStart += string.Format("\"{0}:{1};", _key, _value);

                renderString = elementStart + elementEnd;
            }
            else
            {
                var closeBracketStartPosition = _htmlElement.IsPair
                                                ? renderString.IndexOf('>')
                                                : renderString.IndexOf('/');

                var elementStart = renderString.Substring(0, closeBracketStartPosition);
                var elementEnd = renderString.Substring(closeBracketStartPosition);

                elementStart += string.Format(" style=\"{0}:{1};\"", _key, _value);

                renderString = elementStart + elementEnd;
            }

            return renderString;
        }
    }
}
