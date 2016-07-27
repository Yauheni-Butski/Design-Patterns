using Decorator.Elements.Base;

namespace Decorator.Elements
{
    public class TableElement : HtmlElement
    {
        public TableElement() : base("table", true)
        {
            
        }

        public override string GetRenderString()
        {
            var renderString = IsPair 
                               ? string.Format("<{0}></{0}>", Name) 
                               : string.Format("<{0}/>", Name);

            //Element can render this his specific elements.For example < tr > and < td >

            return renderString;
        }
    }
}
