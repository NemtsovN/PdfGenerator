using PuppeteerSharp;
using PuppeteerSharp.Media;

namespace PdfGenerator.Prototypes.PuppeteerSharpGenerator;

public static class PdfGenerator
{
    public static async Task<Stream> GeneratePdfAsync(string htmlInput)
    {
        // Download Chromium dependency
        await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

        var browserLaunchOptions = new LaunchOptions
        {
            Headless = true,
            Args = new[] { "--no-sandbox" }
        };

        await using var browser = await Puppeteer.LaunchAsync(browserLaunchOptions);
        await using var page = await browser.NewPageAsync();

        // Set a4 page size
        await page.SetViewportAsync(new ViewPortOptions
        {
            Width = 2480,
            Height = 3508
        });
        
        await page.EmulateMediaTypeAsync(MediaType.Print);
        
        // Inject HTML
        await page.SetContentAsync(htmlInput);

        await page.SetCacheEnabledAsync(false);

        // Generate PDF file from provided Puppeteer page
        var pdfOptions = new PdfOptions
        {
            Format = PaperFormat.A4,
            DisplayHeaderFooter = true,
            
            // Defines if we want to print a background color of a page. For example: if background is grey, it will create a box inside page with grey color.
            // PrintBackground = true,
            MarginOptions = new()
            {
                Bottom = "1.5cm",
                Left = "1.5cm",
                Right = "1.5cm",
                Top = "1.5cm"
            },
            // Width = "2480px",
            // Height = "3508px",
            Scale = new decimal(0.99),
            HeaderTemplate = "<div id=\"footer-template\" style=\"font-size:10px !important; margin-left: 40px; color:#808080;\"><span class=\"date\"></span> <span class=\"title\" style=\"padding-left: 150px;\"></span></div>",
            FooterTemplate = "<div style=\"width:100%; margin: 0 auto; padding-right: 40px;\"><p style=\"text-align: right; font-size: 10px;\"><span class=\"pageNumber\"></span>/<span class=\"totalPages\"></span></p></div>"
        };

        var resultPdf = await page.PdfStreamAsync(pdfOptions);

        return resultPdf;
    }
}