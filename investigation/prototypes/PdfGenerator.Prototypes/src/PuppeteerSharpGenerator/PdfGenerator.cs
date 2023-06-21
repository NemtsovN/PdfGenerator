using PuppeteerSharp;

namespace PdfGenerator.Prototypes.PuppeteerSharpGenerator;

public static class PdfGenerator
{
    public static async Task<Stream> GeneratePdfAsync(string htmlInput)
    {
        // Download Chromium dependency
        await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultChromiumRevision);

        var browserLaunchOptions = new LaunchOptions
        {
            Headless = true
        };

        await using var browser = await Puppeteer.LaunchAsync(browserLaunchOptions);
        await using var page = await browser.NewPageAsync();

        // Inject HTML
        await page.SetContentAsync(htmlInput);
        await page.SetCacheEnabledAsync(false);

        // Generate PDF file from provided Puppeteer page
        var pdfOptions = new PdfOptions
        {
            DisplayHeaderFooter = true,
            PrintBackground = true
        };

        var resultPdf = await page.PdfStreamAsync(pdfOptions);

        return resultPdf;
    }
}