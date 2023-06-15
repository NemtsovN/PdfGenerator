# Puppeteer

- [Puppeteer](#puppeteer)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

Puppeteer is a Node.js library which provides a high-level API to control Chrome/Chromium over the DevTools Protocol. Puppeteer runs in headless mode by default, but can be configured to run in full ("headful") Chrome/Chromium.

> License: [Apache License 2.0](https://github.com/puppeteer/puppeteer/blob/main/LICENSE)

### References

- [Source Code](https://github.com/puppeteer/puppeteer)
- [Article describing how to write PDF](https://www.bannerbear.com/blog/how-to-convert-html-into-pdf-with-node-js-and-puppeteer/)

## Notes

- Despite this is a multi-purpose tool, it seems to be heavily used for a scenario of HTML to PDF conversion.
- Strong community.
- Good amount of documentation and articles.

### Concerns

- Uses headless browser that will export HTML to PDF.

## Outcome

Despite that it is mature and well-known, it seems that usage of a headless browser is a bad approach to implement performant PDF generator.
