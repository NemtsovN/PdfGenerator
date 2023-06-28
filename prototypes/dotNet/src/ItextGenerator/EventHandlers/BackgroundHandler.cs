using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Properties;

namespace PdfGenerator.Prototypes.ItextGenerator.EventHandlers;

public class BackgroundHandler : IEventHandler
{
    public void HandleEvent(Event @event)
    {
        var docEvent = (PdfDocumentEvent) @event;
        var page = docEvent.GetPage();
        var pageSize = page.GetPageSize();

        var canvas = new Canvas(new PdfCanvas(page), pageSize);

        canvas
            .SetBackgroundColor(new DeviceRgb(92, 255, 255))
            .SetFontColor(new DeviceRgb(92, 255, 255))
            .ShowTextAligned("TEST",
                pageSize.GetWidth() - 120,
                pageSize.GetTop() - 30, TextAlignment.LEFT);

        canvas.Close();
    }
}
