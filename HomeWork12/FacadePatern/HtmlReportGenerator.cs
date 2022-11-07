using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.FacadePatern
{
    public class HtmlReportGenerator
    {
        private const string Header = "<header>MyHeader</header>";
        private const string Body = "<body>Video provides a powerful way to help you prove your point. When you click\r\nOnline Video, you can paste in the embed code for the video you want to add.</body>";
        private const string Footer = "<footer>My Footer</footer>";
        public void GenerateReport()
        {
            Console.WriteLine(Header + Environment.NewLine);
            Console.WriteLine(Body + Environment.NewLine);
            Console.WriteLine(Footer + Environment.NewLine);
        }
    }
}
