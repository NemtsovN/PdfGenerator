using System.Globalization;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Resolver.Font;

namespace PdfGenerator.Prototypes.ItextGenerator.EventHandlers;

public class HeaderEventHandler : IEventHandler
{
    public void HandleEvent(Event @event)
    {
        var docEvent = (PdfDocumentEvent) @event;
        var page = docEvent.GetPage();
        var pageSize = page.GetPageSize();

        var canvas = new Canvas(new PdfCanvas(page), pageSize);
        canvas.SetFontSize(8);
        
        var fontProvider = new BasicFontProvider();
        canvas.SetFontProvider(fontProvider);
        canvas.SetFontFamily("times");

        // Write text at position
        var generationDateText = new Paragraph()
            .Add(DateTime.Now.ToString("dd/MM/yyyy, hh:mm tt", CultureInfo.InvariantCulture));
        
        canvas.ShowTextAligned(generationDateText,
            28,
            pageSize.GetTop() - 30, TextAlignment.LEFT);
        
        var nameDateText = new Paragraph()
            .Add("Best Series in the World");
        
        canvas.ShowTextAligned(nameDateText,
            pageSize.GetWidth() / 2,
            pageSize.GetTop() - 30, TextAlignment.LEFT);
        canvas.Close();
    }
}