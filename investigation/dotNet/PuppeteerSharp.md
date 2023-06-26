# Puppeteer Sharp

- [Puppeteer Sharp](#puppeteer-sharp)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

Puppeteer Sharp is a .NET port of the official Node.JS Puppeteer API.

> License: [MIT](https://github.com/hardkoded/puppeteer-sharp/blob/master/LICENSE)

### References

- [Source Code](https://github.com/hardkoded/puppeteer-sharp)

## Notes

- Converts HTML string (or URL) to a PDF file.
- Great community.
  - There seems to be a variaty of articles that describe a process of PDF generation.
- Releases support the latest version of .NET.

### Concerns

- Uses approach with a headless browser. So does not construct PDF files or modifies them.
- Requires machine that will run code to keep a binary of Chromium that takes 282.6 MB for OSX.
  - At the same time, there are articles that describe a way to optimize that especially in case of [AWS Lambda](https://acloudguru.com/blog/engineering/serverless-browser-automation-with-aws-lambda-and-puppeteer).
- Does not allow us to modify file on a fly.

## Outcome

Despite that there is a gut feeling that this tool is meant to have a different purpose, it is still possible to transform HTML files to PDFs. This fact and a fact that tooling has great community, it seems to be worth a try.
