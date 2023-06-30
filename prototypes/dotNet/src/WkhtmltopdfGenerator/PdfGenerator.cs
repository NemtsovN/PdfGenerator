using System.Diagnostics;
using System.Text;

namespace PdfGenerator.Prototypes.WkhtmltopdfGenerator;

public class PdfGenerator
{
    public static async Task<Stream> GeneratePdfAsync(string htmlInput)
    {
        var wkhtmltopdfPath = "/usr/local/bin/wkhtmltopdf";

        var process = new Process();
        
        process.StartInfo.FileName = wkhtmltopdfPath;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;

        var argumentsBuilder = new StringBuilder();

        // Margins
        argumentsBuilder.Append(" --margin-top 10");
        argumentsBuilder.Append(" --margin-bottom 9");

        // Layout
        argumentsBuilder.Append(" --zoom 1.25");
        argumentsBuilder.Append(" --page-height 271");
        argumentsBuilder.Append(" --page-width 210");

        // In-memory saving of PDF
        argumentsBuilder.Append(" -");
        argumentsBuilder.Append(" -");

        process.StartInfo.Arguments = argumentsBuilder.ToString();

        process.Start();

        var inputWriter = process.StandardInput;
        inputWriter.AutoFlush = true;
        await inputWriter.WriteAsync(htmlInput);

        inputWriter.Close();

        var outputStream = new MemoryStream();

        await process.StandardOutput.BaseStream.CopyToAsync(outputStream);

        await process.WaitForExitAsync();

        return outputStream;
    }
}