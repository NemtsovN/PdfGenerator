using System.Globalization;
using NReco.PdfGenerator;

namespace PdfGenerator.Prototypes.NRecoGenerator;

public static class PdfGenerator
{
    public static Stream GeneratePdf(string htmlInput)
    {
        var resultPdf = new MemoryStream();
        
        var htmlGenerator = new HtmlToPdfConverter();

        htmlGenerator.License.SetLicenseKey(
            "DEMO", "YOU_DEMO_KEY");
        htmlGenerator.Quiet = false;

        htmlGenerator.Margins = new()
        {
            Top = 10,
            Bottom = 9
        };

        htmlGenerator.Zoom = 1.25f;
        htmlGenerator.Orientation = PageOrientation.Portrait;
        htmlGenerator.PageHeight = 217;
        htmlGenerator.PageWidth = 210;

        var headerCreationDate = DateTime.Now.ToString("dd/MM/yyyy, hh:mm tt", CultureInfo.InvariantCulture);

        htmlGenerator.PageHeaderHtml =
            $@"<div id=""footer-template"" style=""font-size:10px !important; padding-bottom: 8px;""><span>{headerCreationDate}</span> <span class=""title"" style=""padding-left: 270px;"">Best Series in the World</span></div>";
        
        htmlGenerator.PageFooterHtml =
            "<div style=\"font-size:10px !important; padding-top: 1px;\"><p style=\"text-align: right;\"><span class=\"page\"></span>/<span class=\"topage\"></span></p></div>";

        htmlGenerator.GeneratePdf(htmlInput, string.Empty, resultPdf);

        return resultPdf;
    }
}