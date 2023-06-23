# PDF Generator Prototypes

- [PDF Generator Prototypes](#pdf-generator-prototypes)
  - [General](#general)
  - [Prerequisites](#prerequisites)
  - [Startup](#startup)
    - [Configuration](#configuration)
      - [NReco configuration](#nreco-configuration)
      - [wkhtmltopdf](#wkhtmltopdf)
    - [Run](#run)
      - [CLI](#cli)
      - [Docker](#docker)
  - [Benchmarks](#benchmarks)

## General

Solution represents a set of prototypes that can be used to transform HTML input into PDF using a variety of libraries. The main purpose of these projects is to provide a playground for comparison of PDF generation libraries and the drawbacks of each.

## Prerequisites

- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Docker](https://www.docker.com/)
- [wkhtmltopdf](https://wkhtmltopdf.org/)

## Startup

### Configuration

> Please note: all configurations are hard-coded now. This has been done for simplicity of prototypes.

#### NReco configuration

To use an NReco generator prototype, you would need a license key. It can be obtained for a [demo purposes](https://www.nrecosite.com/pdf_generator_net.aspx). Once you get a key, please navigate to [PdfGenerator.cs](/investigation/prototypes/src/NRecoGenerator/PdfGenerator.cs) and replace `YOUR_DEMO_KEY`.

#### wkhtmltopdf

Generator prototype for wkhtmltopdf needs binaries that will point to installed version of CLI tool. Once you install it, please adjust `wkhtmltopdfPath` variable in [PdfGenerator.cs](/investigation//prototypes//src//WkhtmltopdfGenerator/PdfGenerator.cs).

### Run

> Please note: all commands should be executed from a folder container of current README file.

#### CLI

To run application, please execute script:

```sh
dotnet run --project ./src/Development/Development.csproj
```

#### Docker

To run application in Docker, please build image first:

```sh
docker build -f src/Development/Dockerfile . -t pdf-generator-prototypes
```

And run it:

```sh
docker run --name pdf-generator-prototypes  pdf-generator-prototypes
```

## Benchmarks

To run benchmarks, please make sure to configure application first. For that, you can make use of [Configuration section.](#configuration).

Once it is done, please execute command:

```sh
dotnet run --project benchmarks/Benchmarks/Benchmarks.csproj -c Release
```
