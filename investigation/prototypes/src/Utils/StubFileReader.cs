namespace PdfGenerator.Prototypes.Utils;

public static class StubFileReader
{
    public static string ReadStubsAsString()
    {
        var htmlFileContent = File.ReadAllText("Stubs/index.html");
        var cssFileContent = File.ReadAllText("Stubs/styles.css");

        var combinedMarkup = $"<style>{cssFileContent}</style>{htmlFileContent}";

        return combinedMarkup;
    }
}