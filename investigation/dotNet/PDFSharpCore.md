# PDFSharpCore

- [PDFSharpCore](#pdfsharpcore)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

PDFsharpCore is a .NET library for processing PDF file. You create PDF pages using drawing routines known from GDI+. Almost anything that can be done with GDI+ will also work with PDFsharp. Only basic text layout is supported by PDFsharp, and page breaks are not created automatically. The same drawing routines can be used for screen, PDF, or meta files.

> License: [MIT](https://github.com/ststeiger/PdfSharpCore/blob/master/LICENSE.md). At the same time, this project has dependencies [that use Apache 2.0 license](https://github.com/ststeiger/PdfSharpCore#license).

### References

- [Source code](https://github.com/ststeiger/PdfSharpCore)

## Notes

- Uses latest versions of .NET.
- Released often.
- Big amount of downloads on Nuget.

### Concerns

- Releases happen quite often, sometime chaotic and several times per day.
- Originally is a fork of PdfSharp library.
- Not all functionality has been migrated and issues can still occur.
- Potentially bad support as the library is truly open-source.

## Outcome

Controversial option. It is a fork so should not be ready for a production usage. At the same time, it is fresh and has been used by a big amount of people. Potentially we should consider it only if we decide to go with PDFSharp functionality.
