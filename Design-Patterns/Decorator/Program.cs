using System;

using Decorator.Decorators;
using Decorator.Elements;
using Decorator.Elements.Base;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HtmlElement list = new ListElement(false);
            list = new BorderWidthStyle(list, 12);
            list = new WidthStyle(list, 50);
            var listRender = list.GetRenderString();

            Console.WriteLine(listRender);
            Console.WriteLine();



            HtmlElement table = new TableElement();
            table = new BorderWidthStyle(table, 20);
            table = new WidthStyle(table, 250);
            table = new TextColorStyle(table, TextColors.Red);
            var tableRender = table.GetRenderString();

            Console.WriteLine(tableRender);
            Console.WriteLine();
        }
    }
}
