# SelectPDF

- [SelectPDF](#selectpdf)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

SelectPdf Html To Pdf Converter for .NET – Community Edition.

SelectPdf offers a Community Edition (FREE) of the powerful Html To Pdf Converter for .NET that can be found in the full featured pdf library Select.Pdf for .NET. The free html to pdf converter offers most of the features the professional sdk offers, the only notable limitation is that it can only generate pdf documents up to 5 pages long. SelectPdf Html To Pdf Converter provides versions for .NET Framework and .NET Core 2.0 and above (through .NET Standard 2.0). SelectPdf only works on Windows. SelectPdf works on Azure cloud, including Azure Web Apps (Basic plan or above) with some limitations.

> License: paid version - please see the [documentation](https://selectpdf.com/pricing/). Free version - can be used by companies, but is limited with up to 5 pages in a document.

### References

- [Website](https://selectpdf.com/pdf-library-for-net/)
- [Sample code](https://github.com/selectpdf/selectpdf-free-html-to-pdf-converter)
- [Pricing](https://selectpdf.com/pricing/)
- [Developer Documentation](https://selectpdf.com/pdf-library/html/HtmlToPdfConverter.htm)

## Notes

- Converts HTML string to a PDF object.
- The resulted PDF object object can be saved to a file, to a stream, to a memory buffer or to a HTTP response.
- Allows us to modify document and its properties:
  - Set pdf page settings (page size, page orientation, page margins)
  - Set pdf document properties
  - Set pdf viewer preferences
  - Set pdf security (passwords, permissions)
  - Custom headers and footers
  - Support for html in headers and footers

### Concerns

- Free license exists, but it is limited up to 5 pages in a single document. [License](https://selectpdf.com/community-edition/)
- Seems that library fully depends on some Windows assets and can be run only on Windows machine (information is based on official website).
- No NuGet package source code found.

## Outcome

Seems to be a bad candidate due to mentioned concerns.
