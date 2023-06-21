using iText.Html2pdf;
using iText.Kernel.Pdf;

namespace PdfGenerator.Prototypes.ItextGenerator;

public static class PdfGenerator
{
    public static Stream GeneratePdf(string htmlInput)
    {
        var resultPdf = new MemoryStream();
        
        // Dedicated writer that will be configured to prevent automated memory stream closing
        using var pdfWriter = new PdfWriter(resultPdf);
        pdfWriter.SetCloseStream(false);

        HtmlConverter.ConvertToPdf(htmlInput, pdfWriter);
        
        return resultPdf;
    }
}