using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.StyledXmlParser.Resolver.Font;
using IEventHandler = iText.Kernel.Events.IEventHandler;

namespace PdfGenerator.Prototypes.ItextGenerator.EventHandlers;

public class FooterEventHandler : IEventHandler
{
    private readonly PdfFormXObject _placeholder;
    private const float Side = 20;
    private const float X = 300;
    private const float Y = 25;
    private const float Space = 4.5f;
    private const float Descent = 3;

    public FooterEventHandler()
    {
        _placeholder = new PdfFormXObject(new Rectangle(0, 0, Side, Side));
    }

    public void HandleEvent(Event @event)
    {
        var docEvent = (PdfDocumentEvent) @event;
        var pdf = docEvent.GetDocument();
        var page = docEvent.GetPage();
        var pageNumber = pdf.GetPageNumber(page);
        var pageSize = page.GetPageSize();

        // Creates drawing canvas
        var pdfCanvas = new PdfCanvas(page);
        var canvas = new Canvas(pdfCanvas, pageSize);
        canvas.SetFontSize(8);

        var fontProvider = new BasicFontProvider();
        canvas.SetFontProvider(fontProvider);
        canvas.SetFontFamily("times");

        var p = new Paragraph()
            .Add(pageNumber.ToString())
            .Add("/")
            .Add(pdf.GetNumberOfPages().ToString());

        canvas.ShowTextAligned(p, pageSize.GetWidth() - 50, Y, TextAlignment.LEFT);
        canvas.Close();

        // Create placeholder object to write number of pages
        pdfCanvas.AddXObjectAt(_placeholder, X + Space, Y - Descent);
        pdfCanvas.Release();
    }
}