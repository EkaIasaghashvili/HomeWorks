using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.FacadePatern
{
    public class Facade
    {
        protected HtmlReportGenerator _htmlReportGenerator;
        protected PdfReportGenerator _pdfReportGenerator;

        public Facade(HtmlReportGenerator htmlReportGenerator, PdfReportGenerator pdfReportGenerator)
        {
            _htmlReportGenerator = htmlReportGenerator;
            _pdfReportGenerator = pdfReportGenerator;
        }

        public void PrintHtmlReport()
        {
            _htmlReportGenerator.GenerateReport();
        }

        public void PrintPdfReport()
        {
            _pdfReportGenerator.GenerateReport();
        }
    }
}
