using System.Reflection;

namespace PdfGenerator.Prototypes.Utils;

public static class StubFileReader
{
    public static string ReadStubsAsString()
    {
        var assemblyName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;

        var htmlFilePath = Path.Combine(assemblyName, @"Stubs/index.html");
        var htmlFileContent = File.ReadAllText(htmlFilePath);
        
        var cssFilePath = Path.Combine(assemblyName, @"Stubs/styles.css");
        var cssFileContent = File.ReadAllText(cssFilePath);

        var combinedMarkup = $"<style>{cssFileContent}</style>{htmlFileContent}";

        return combinedMarkup;
    }
}