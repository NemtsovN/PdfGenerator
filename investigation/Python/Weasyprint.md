# Weasyprint

- [Weasyprint](#weasyprint)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Architecture](#architecture)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

WeasyPrint is a smart solution helping web developers to create PDF documents. It’s free and open source software that can be easily plugged to your applications and websites and turns simple HTML pages into gorgeous

> License: [BSD-3](https://github.com/Kozea/WeasyPrint/blob/master/LICENSE)

### References

- [Source Code](https://github.com/Kozea/WeasyPrint)
- [Documentation](https://doc.courtbouillon.org/weasyprint/stable/)

## Notes

- Great community: 5.9K starts on Github, 176 open issues.
- Frequent updates: the latest update on 11/05/2023.
- Does not need any dependency except of Python dependency.

### Architecture

The rendering of a document in WeasyPrint goes like this:

- The HTML document is fetched and parsed into a tree of elements (like DOM). This happens with a help of html5lib library that uses **custom** implementation and do not depend on a web engines.
- CSS stylesheets are fetched and parsed. This process also depends on third-party library - tinycss2 with no other dependencies.
- The stylesheets are applied to the DOM-like tree.
- The DOM-like tree with styles is transformed into a formatting structure made of rectangular boxes.
- These boxes are laid-out with fixed dimensions and position onto pages. 
- For each page, the boxes are re-ordered to observe stacking rules, and are drawn on a PDF page.
- Metadata − such as document information, attachments, embedded files, hyperlinks, and PDF trim and bleed boxes − are added to the PDF.

This brings us to a declaration that Weasyprint does not depend on a web engine or web kit. It is completely custom process that is build on a Python to render HTML and CSS into PDF files.

You find more about architecture:

- [Going further Weasyprint article](https://doc.courtbouillon.org/weasyprint/stable/going_further.html#parsing-html)
- [README](https://github.com/Kozea/WeasyPrint/blob/2a9a952c356b856ad1f80ddb6d0c93b36ccac46c/README.rst#L7)

### Concerns

- Python based solution. Requires team expertise in Python.

## Outcome

Seems to be a bad candidate due to mentioned concerns.
