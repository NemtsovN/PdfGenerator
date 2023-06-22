namespace PdfGenerator.Prototypes.NRecoGenerator;

public static class PdfGenerator
{
    public static Stream GeneratePdf(string htmlInput)
    {
        var resultPdf = new MemoryStream();
        var htmlGenerator = new NReco.PdfGenerator.HtmlToPdfConverter();
        
        htmlGenerator.License.SetLicenseKey(
            "DEMO", "pjfsL9eBhU5mER7ULRNO/pgqeXBsJF15ea8d+vpzJ/ja8LpELgrs2FoaZwNLRmsJpgwKahfzSvyCZDHZsI0Bs9KCaby6CXo02YxpA3iiwJPaDdfO+vTK/JCsjH/d9l6118KUVjegNFAraGSKA3Q6tMTg4/injiZ9wZ3kcjoXPjs=");
        htmlGenerator.Quiet = false;

        htmlGenerator.GeneratePdf(htmlInput, string.Empty, resultPdf);

        return resultPdf;
    }
}