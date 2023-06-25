# PDF Generator Prototypes

- [PDF Generator Prototypes](#pdf-generator-prototypes)
  - [General](#general)
  - [Prerequisites](#prerequisites)
  - [Setup environment](#setup-environment)
    - [Install Python](#install-python)
    - [Install pipenv](#install-pipenv)
  - [Run the script](#run-the-script)
    - [Install dependencies](#install-dependencies)
    - [Execute script](#execute-script)
  - [Benchmarks](#benchmarks)
    - [Time benchmark](#time-benchmark)
    - [Memory benchmark](#memory-benchmark)

## General

Project represents a Pyhton based script and set of benchmarks to test Weasyprint PDF conversion tooling.

## Prerequisites

- [Python](https://www.python.org/)
- [Pip](https://pypi.org/project/pip/)

## Setup environment

If you're new in Python, you need to perform initial setup to start using a script. You need to install:

- `Python 3.9.x`
- `pipenv`

### Install Python

Download and install Python from [the official site](https://www.python.org/downloads/). Do not forget to select checkbox to add Python to `PATH`.

### Install pipenv

1. Run terminal as Administrator
1. Run the following command:

```sh
pip install pipenv
```

## Run the script

### Install dependencies

```sh
pipenv sync
```

### Execute script

Use the following command to run the script:

```powershell
pipenv run python weasyprint_prototype.py
```

## Benchmarks

### Time benchmark

To get information about mean time of script execution, please [prepare environment](#setup-environment)

```sh
pipenv run python time-benchmark.py
```

### Memory benchmark

To get information about memory usage of script execution, please [prepare environment](#setup-environment)

```sh
pipenv run python memory-benchmark.py 
```
