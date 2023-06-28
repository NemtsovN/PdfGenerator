using iText.Html2pdf;
using iText.Kernel.Events;
using iText.Kernel.Pdf;
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

        pdfWriter.SetCloseStream(false);
        
        var footerHandler = new FooterEventHandler();
        var headerHandler = new HeaderEventHandler();
        var backgroundHandler = new BackgroundHandler();

        pdfDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, footerHandler);
        pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, headerHandler);
        pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, backgroundHandler);

        var converterProperties = new ConverterProperties();

        HtmlConverter.ConvertToPdf(htmlInput, pdfDocument, converterProperties);
        
        return resultPdf;
    }
}