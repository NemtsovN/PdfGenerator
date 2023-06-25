using BenchmarkDotNet.Attributes;
using PdfGenerator.Prototypes.Utils;

namespace PdfGenerator.Prototypes.Benchmarks;

[MemoryDiagnoser]
[InProcess]
public class PdfGeneratorsBenchmarks
{
    private string _inputHtml = string.Empty;

    [GlobalSetup]
    public void Setup()
    {
        _inputHtml = StubFileReader.ReadStubsAsString();
    }

    [Benchmark(Baseline = true, Description = "Generate PDF file with a help of PuppeteerSharp.")]
    public async Task GeneratePdfWithPuppeteerSharpAsync()
    {
        var _ = await PuppeteerSharpGenerator
            .PdfGenerator
            .GeneratePdfAsync(_inputHtml);
    }
    
    [Benchmark(Description = "Generate PDF file with a help of iText.")]
    public void GeneratePdfWithItext()
    {
        var _ = ItextGenerator.
            PdfGenerator
            .GeneratePdf(_inputHtml);
    }
    
    [Benchmark(Description = "Generate PDF file with a help of Wkhtmltopdf.")]
    public async Task GeneratePdfWithWkhtmltopdfAsync()
    {
        var _ = await WkhtmltopdfGenerator.
            PdfGenerator
            .GeneratePdfAsync(_inputHtml);
        Thread.Sleep(5000);
    }
    
    [Benchmark(Description = "Generate PDF file with a help of NReco.")]
    public void GeneratePdfWithNReco()
    {
        var _ = NRecoGenerator.
            PdfGenerator
            .GeneratePdf(_inputHtml);
    }
}