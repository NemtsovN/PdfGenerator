# PdfGenerator

- [PdfGenerator](#pdfgenerator)
  - [General](#general)
  - [Tools to investigate](#tools-to-investigate)
  - [Comparison Table](#comparison-table)

## General

Repository for a source code and documentation of PDF documents generation investigation.

## Tools to investigate

- .NET
  - [x] [SelectPDF](https://selectpdf.com/)
  - [x] [PdfSharp](https://github.com/empira/PDFsharp)
  - [x] [IronPdf](https://ironpdf.com/)
  - [x] [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf)
  - [x] [iTextSharp](https://github.com/itext/itextsharp)
  - [x] [wkhtmltopdf](https://wkhtmltopdf.org/)

## Comparison Table

| Feature                              | SelectPDF                                                                                                                           | IronPDF                                                        | iTextSharp                                                                            |
|--------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------|---------------------------------------------------------------------------------------|
| PDF generation based on HTML markup. | From a string, URL or a file.                                                                                                       | From a string, URL or a file.                                  | From a string, file and Stream.                                                       |
| Result PDF storage.                  | Stream or file.                                                                                                                     | Stream or file.                                                | Stream or file.                                                                       |
| Features                             | [Feature list](https://selectpdf.com/pdf-library-for-net/)                                                                          | [Feature list](https://ironpdf.com/features/#html-file-to-pdf) | [Feature list](https://itextpdf.com/products/itext-7/convert-html-css-to-pdf-pdfhtml) |
| Platform                             | Windows                                                                                                                             | Any Platform                                                   | Any Platform (according to a not found limitation description)                        |
| License                              | Commercial license: 499$-1599$ per 1 year. Community - available for commercial purposes but is limited with 5 pages in a document. | Commercial license: 749$ - 2999$ per 1 year.                   | Request is sent to product team                                                       |
| Open-source                          | No                                                                                                                                  | No                                                             | Yes                                                                                   |
| Community activity                   | 237 search results on StackOverflow                                                                                                 | 211 search results on StackOverflow                            | 1.3k starts on a GitHub. 500 search results on  StackOverflow                         |
