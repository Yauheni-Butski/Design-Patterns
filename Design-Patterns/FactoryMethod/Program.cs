using System;

using FactoryMethod.ViewCreators;
using FactoryMethod.ViewCreators.Base;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewManager msOfficeViewManager = new MsOfficeViewManager();
            msOfficeViewManager.Open("file.doc");
            msOfficeViewManager.Open("player.docx");
            msOfficeViewManager.Open("table.xls");
            msOfficeViewManager.Open("changes.patch");
            Console.WriteLine("--------");

            ViewManager notepadViewManager = new NotepadPlusPlusViewManager();
            notepadViewManager.Open("notes.txt");
            notepadViewManager.Open("styles.css");
            notepadViewManager.Open("index.html");
            Console.WriteLine("--------");

            ViewManager visualStudioViewManager = new VisualStudioiewManager();
            visualStudioViewManager.Open("mySolution.sln");
            visualStudioViewManager.Open("myProject.csproj");
            visualStudioViewManager.Open("packages.dtsx");
            Console.WriteLine("--------");
        }
    }
}
