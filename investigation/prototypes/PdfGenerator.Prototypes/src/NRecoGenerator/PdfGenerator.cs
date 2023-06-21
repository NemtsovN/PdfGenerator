namespace PdfGenerator.Prototypes.NRecoGenerator;

public static class PdfGenerator
{
    public static Stream GeneratePdf(string htmlInput)
    {
        var resultPdf = new MemoryStream();
        var htmlGenerator = new NReco.PdfGenerator.HtmlToPdfConverter();
        
        htmlGenerator.License.SetLicenseKey(
            "DEMO", "YOUR DEMO KEY");
        htmlGenerator.Quiet = false;

        htmlGenerator.GeneratePdf(htmlInput, string.Empty, resultPdf);

        return resultPdf;
    }
}