# pdfkit

- [pdfkit](#pdfkit)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

PDFKit is one of the oldest JavaScript-based libraries and is still under active development. Unlike the HTML-to-PDF libraries, PDFKit creates documents element-by-element, box-by-box. PDFKit supports hardly any complex PDF functionality, with the exception of forms. Tables must be drawn cell-by-cell, for example. Bookmarks and accessibility tagging must be created explicitly, rather than automatically defined as the more advanced HTML-based libraries will do. In general, PDFKit seems best for very simple documents.

> License: [MIT](https://github.com/foliojs/pdfkit/blob/master/LICENSE)

### References

- [Source Code](https://github.com/foliojs/pdfkit)

## Notes

N/A

### Concerns

- Not able to do conversion of HTML to PDF, only step by step generation. This requires some additional libraries to be used: html-to-pdf is used, but it is not maintained anymore.

## Outcome

Seems to be a bad candidate due to mentioned concerns.
