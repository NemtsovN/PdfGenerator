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
            Args = new[] { "--no-sandbox" },
        };

        await using var browser = await Puppeteer.LaunchAsync(browserLaunchOptions);
        await using var page = await browser.NewPageAsync();

        // await page.EmulateMediaTypeAsync(MediaType.Print);

        await page.SetViewportAsync(new ViewPortOptions
        {
            Width = 793,
            Height = 1122
        });
        
        // Inject HTML
        await page.SetContentAsync(htmlInput);

        await page.SetCacheEnabledAsync(false);

        // Generate PDF file from provided Puppeteer page
        var pdfOptions = new PdfOptions
        {
            Format = PaperFormat.A4,
            DisplayHeaderFooter = true,
            
            // Defines if we want to print a background color of a page. For example: if background is grey, it will create a box inside page with grey color.
            PrintBackground = true,
            MarginOptions = new()
            {
                Bottom = "0.95cm",
                Left = "1.03cm",
                Right = "1cm",
                Top = "1.03cm"
            },
            PreferCSSPageSize = true,
            // Width = "21cm",
            // Height = "29.71cm",
            Scale = new decimal(1),
            
            HeaderTemplate = "<div id=\"footer-template\" style=\"font-size:8px !important; margin-left: 25px;\"><span class=\"date\"></span> <span class=\"title\" style=\"padding-left: 220px;\"></span></div>",
            FooterTemplate = "<style>#footer { padding: 0 !important; }</style><div style=\"width:100%; margin: 0 auto; padding-bottom: 7px; padding-right: 27px;\"><p style=\"text-align: right; font-size: 8px;\"><span class=\"pageNumber\"></span>/<span class=\"totalPages\"></span></p></div>"
        };

        var resultPdf = await page.PdfStreamAsync(pdfOptions);

        return resultPdf;
    }
}