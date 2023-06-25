# jsPDF

- [jsPDF](#jspdf)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

The leading HTML5 client solution for generating PDFs. Transform your PDF generation process for your event tickets, reports, certificates, and more.

> License: [MIT](https://github.com/parallax/jsPDF/blob/master/LICENSE)

### References

- [Source Code](https://github.com/parallax/jsPDF)

## Notes

N/A

### Concerns

- Can not transform HTML to PDF with no complex implementation of DOM. [Reference issue](https://github.com/parallax/jsPDF/issues/2970).
  - Proposed solution is to run headless browser.
  - All examples, provide us with generation functionality in JS and not a server-side node.js

## Outcome

Seems to be a bad candidate due to mentioned concerns.
