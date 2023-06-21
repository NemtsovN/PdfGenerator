using PdfGenerator.Prototypes.Utils;

const string resultsFolderPath = "./Results";

Console.WriteLine("Start preparation of input HTML and CSS.");

var htmlInput = StubFileReader.ReadStubsAsString();

Console.WriteLine("Finished preparation of HTML and CSS.");

await PuppeteerSharpGeneratePdfAsync(htmlInput);
await iTextGeneratePdfAsync(htmlInput);
await WkhtmltopdfGeneratePdfAsync(htmlInput);
await NRecoGeneratePdfAsync(htmlInput);

static async Task PuppeteerSharpGeneratePdfAsync(string htmlInput)
{
    Console.WriteLine("Start PuppeteerSharp generator.");

    var generatedPdfContent = await PdfGenerator
        .Prototypes
        .PuppeteerSharpGenerator
        .PdfGenerator
        .GeneratePdfAsync(htmlInput);

    Console.WriteLine("Finished PDF generation with PuppeteerSharp.");

    const string puppeteerSharpResultPdfFileName = "puppeteerSharp-result.pdf";
    Console.WriteLine($"Start saving generated PDF to file '{puppeteerSharpResultPdfFileName}'");

    await generatedPdfContent.SaveToFile(puppeteerSharpResultPdfFileName, resultsFolderPath);
    await generatedPdfContent.DisposeAsync();

    Console.WriteLine($"Successfully saved PDF to a file '{puppeteerSharpResultPdfFileName}'");
}

static async Task iTextGeneratePdfAsync(string htmlInput)
{
    Console.WriteLine("Start iText generator.");

    var generatedPdfContent = PdfGenerator
        .Prototypes
        .ItextGenerator
        .PdfGenerator
        .GeneratePdf(htmlInput);

    Console.WriteLine("Finished PDF generation with iText.");

    const string iTextResultPdfFileName = "iText-result.pdf";
    Console.WriteLine($"Start saving generated PDF to file '{iTextResultPdfFileName}'");

    await generatedPdfContent.SaveToFile(iTextResultPdfFileName, resultsFolderPath);
    await generatedPdfContent.DisposeAsync();

    Console.WriteLine($"Successfully saved PDF to a file '{iTextResultPdfFileName}'");
}

static async Task WkhtmltopdfGeneratePdfAsync(string htmlInput)
{
    Console.WriteLine("Start Wkhtmltopdf generator.");

    var generatedPdfContent = PdfGenerator
        .Prototypes
        .ItextGenerator
        .PdfGenerator
        .GeneratePdf(htmlInput);

    Console.WriteLine("Finished PDF generation with Wkhtmltopdf.");

    const string WkhtmltopdfResultPdfFileName = "Wkhtmltopdf-result.pdf";
    Console.WriteLine($"Start saving generated PDF to file '{WkhtmltopdfResultPdfFileName}'");

    await generatedPdfContent.SaveToFile(WkhtmltopdfResultPdfFileName, resultsFolderPath);
    await generatedPdfContent.DisposeAsync();

    Console.WriteLine($"Successfully saved PDF to a file '{WkhtmltopdfResultPdfFileName}'");
}

static async Task NRecoGeneratePdfAsync(string htmlInput)
{
    Console.WriteLine("Start NReco generator.");

    var generatedPdfContent = PdfGenerator
        .Prototypes
        .NRecoGenerator
        .PdfGenerator
        .GeneratePdf(htmlInput);

    Console.WriteLine("Finished PDF generation with NReco.");

    const string nRecoResultPdfFileName = "NReco-result.pdf";
    Console.WriteLine($"Start saving generated PDF to file '{nRecoResultPdfFileName}'");

    await generatedPdfContent.SaveToFile(nRecoResultPdfFileName, resultsFolderPath);
    await generatedPdfContent.DisposeAsync();

    Console.WriteLine($"Successfully saved PDF to a file '{nRecoResultPdfFileName}'");
}