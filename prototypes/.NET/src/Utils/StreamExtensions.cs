namespace PdfGenerator.Prototypes.Utils;

public static class StreamExtensions
{
    public static async Task SaveToFileAsync(this Stream stream, string fileName, string filePath)
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