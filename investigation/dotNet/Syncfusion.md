# Syncfusion

- [Syncfusion](#syncfusion)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

The HTML-to-PDF converter is a .NET library for converting webpages, SVG, MHTML, and HTML files to PDF using C#. It uses the popular rendering engine Blink (Google Chrome). It is reliable and accurate. The result preserves all graphics, images, text, fonts, and the layout of the original HTML document or webpage.

The HTML-to-PDF converter works seamlessly in various platforms: Azure App Services, Azure Functions, AWS Lambda, Docker, WinForms, WPF, Blazor, ASP.NET MVC, ASP.NET Core with Windows, Linux, and MacOS.

> License: paid version - please see the [documentation](https://www.syncfusion.com/sales/teamlicense).

### References

- [Website](https://www.syncfusion.com/document-processing/pdf-framework/net/html-to-pdf)
- [Pricing](https://www.syncfusion.com/sales/teamlicense)
- [Developer Documentation](https://help.syncfusion.com/file-formats/pdf/overview)

## Notes

- Converts HTML string to a PDF object.
- The resulted PDF object object can be saved to a file or to a stream.
- Rich [document modification functionality](https://help.syncfusion.com/file-formats/pdf/overview#key-features-of-essential-pdf).
- Supports all platforms.

### Concerns

- There is no free license.
- Uses Blink under the hood. Despite that it can be used by other libraries, we should understand first what it would cost for production environment to keep Blink.
- Requires application to reference a Nuget package that is dedicated to environment. This happens due to Blink dependency that has platform-specific binaries.

## Outcome

Can be considered as a candidate, but requires deeper investigation to identify Blink dependency risk.
