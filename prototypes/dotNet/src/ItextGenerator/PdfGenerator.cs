using iText.Html2pdf;
using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using PdfGenerator.Prototypes.ItextGenerator.EventHandlers;

namespace PdfGenerator.Prototypes.ItextGenerator;

public static class PdfGenerator
{
    public static Stream GeneratePdf(string htmlInput)
    {
        var resultPdf = new MemoryStream();
        
        // Dedicated writer that will be configured to prevent automated memory stream closing
        using var pdfWriter = new PdfWriter(resultPdf);
        var pdfDocument = new PdfDocument(pdfWriter);

        var document = new Document(pdfDocument, new PageSize(595, 1000), false);

        document.SetMargins(0, 0, 0, 0);
        document.GetPageEffectiveArea(new PageSize(595, 1000));

        pdfWriter.SetCloseStream(false);

        var footerHandler = new FooterEventHandler();
        var headerHandler = new HeaderEventHandler();

        pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, footerHandler);
        pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, headerHandler);

        var converterProperties = new ConverterProperties();

        HtmlConverter.ConvertToPdf(htmlInput, pdfDocument, converterProperties);
        
        return resultPdf;
    }
}