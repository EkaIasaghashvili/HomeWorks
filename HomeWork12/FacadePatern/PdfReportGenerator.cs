using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.FacadePatern
{
    public class PdfReportGenerator
    {
        private const string Header = "I’m using Facade Pattern";
        private const string Body = "Video provides a powerful way to help you prove your point. When you click\r\nOnline Video, you can paste in the embed code for the video you want to add.\r\nYou can also type a keyword to search online for the video that best fits your\r\ndocument. To make your document look professionally produced, Word provides";
        private const string Footer = "Page 1";
        public void GenerateReport()
        {
            Console.WriteLine(Header + Environment.NewLine);
            Console.WriteLine(Body + Environment.NewLine);
            Console.WriteLine(Footer + Environment.NewLine);
        }
    }
}
