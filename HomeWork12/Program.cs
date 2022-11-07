using HomeWork12.AbstractFactory;
using HomeWork12.FacadePatern;
using HomeWork12.Proxy;
using HomeWork12.Strategy;
using System;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //var client = new Client();
            //client.ClienRequest(new ModernFactory());
            #endregion

            #region Task2
            //var film = new Film();

            //var mainActor = new MainActor();
            //film.Action(mainActor);

            //Console.WriteLine();

            //var doublingActor = new DoublingActor(mainActor);
            //film.Action(doublingActor);
            #endregion

            #region Task3
            //var html = new HtmlReportGenerator();
            //var pdf = new PdfReportGenerator();
            //var facade = new Facade(html, pdf);

            //facade.PrintHtmlReport();
            //facade.PrintPdfReport();
            #endregion

            #region Task4
            //var context = new Context();
            //context.SetStrategy(new ZipFile());
            //context.FileOperation();
            #endregion
        }
    }
}
