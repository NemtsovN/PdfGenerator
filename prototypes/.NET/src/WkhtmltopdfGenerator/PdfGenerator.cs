using System.Diagnostics;

namespace PdfGenerator.Prototypes.WkhtmltopdfGenerator;

public class PdfGenerator
{
    public static async Task<Stream> GeneratePdfAsync(string htmlInput)
    {
        var wkhtmltopdfPath = "/usr/local/bin/wkhtmltopdf";

        var process = new Process();
        
        process.StartInfo.FileName = wkhtmltopdfPath;
        process.StartInfo.Arguments = "- -";
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardInput = true;
        process.StartInfo.RedirectStandardOutput = true;

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