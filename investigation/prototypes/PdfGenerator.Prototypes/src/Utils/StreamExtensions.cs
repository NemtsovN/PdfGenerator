namespace PdfGenerator.Prototypes.Utils;

public static class StreamExtensions
{
    public static async Task<string> ConvertToStringAsync(this Stream stream)
    {
        var reader = new StreamReader(stream);
        var result = await reader.ReadToEndAsync();
        return result;
    }

    public static async Task SaveToFile(this Stream stream, string fileName, string filePath)
    {
        var info = new DirectoryInfo(filePath);  
        
        if (info.Exists is false)
        {  
            info.Create();  
        }  
  
        var path = Path.Combine(filePath, fileName);
        await using var outputFileStream = new FileStream(path, FileMode.Create);
        stream.Seek(0, SeekOrigin.Begin);
        
        await stream.CopyToAsync(outputFileStream);
    }
}