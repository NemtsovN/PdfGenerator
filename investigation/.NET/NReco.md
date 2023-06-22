# NReco

- [NReco](#nreco)
  - [General](#general)
    - [References](#references)
  - [Notes](#notes)
    - [Concerns](#concerns)
  - [Outcome](#outcome)

## General

NReco is a set of libraries that provide us with reusable components. One of that components is PDF generator tool. It is provided in a way of library and itself provides nothing more than wkhtmltopdf CLI tool wrapper. It includes methods to call this CLI and convert PDF file.

> License: [paid](https://www.nrecosite.com/pdf_generator_net.aspx)

### References

N/A

## Notes

N/A

### Concerns

- Wrapper of CLI tool that will start separate process on a host machine.
- Separate packages for Windows and Unix systems.
  - Windows package has baked in version of wkhtmltopdf CLI.
  - Unix version requires wkhtmltopdf binaries to present on a host machine.
- Not open-source solution. Despite the company provides GitHub account, they have not placed PDF Generator code, only the legacy version.
- Documentation is not detailed and there seems to be no community besides support email chain.

## Outcome

Seems to be a bad candidate due to mentioned concerns.
