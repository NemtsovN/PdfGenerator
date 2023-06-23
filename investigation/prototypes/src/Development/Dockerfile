FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY ["src/Development/Development.csproj", "Development/"]
COPY ["src/ItextGenerator/ItextGenerator.csproj", "ItextGenerator/"]
COPY ["src/NRecoGenerator/NRecoGenerator.csproj", "NRecoGenerator/"]
COPY ["src/PuppeteerSharpGenerator/PuppeteerSharpGenerator.csproj", "PuppeteerSharpGenerator/"]
COPY ["src/WkhtmltopdfGenerator/WkhtmltopdfGenerator.csproj", "WkhtmltopdfGenerator/"]
COPY ["src/Utils/Utils.csproj", "Utils/"]

RUN dotnet restore "Development/Development.csproj"

COPY ["src/Development", "Development/"]
COPY ["src/ItextGenerator", "ItextGenerator/"]
COPY ["src/NRecoGenerator", "NRecoGenerator/"]
COPY ["src/PuppeteerSharpGenerator", "PuppeteerSharpGenerator/"]
COPY ["src/WkhtmltopdfGenerator", "WkhtmltopdfGenerator/"]
COPY ["src/Utils", "Utils/"]

RUN dotnet publish "Development/Development.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

WORKDIR /app
COPY --from=build /app/out ./

# Install wkhtmltopdf
RUN apt-get update && apt-get install -y wget

RUN apt-get --assume-yes install fontconfig
RUN apt-get --assume-yes install xfonts-75dpi
RUN apt-get --assume-yes install xfonts-100dpi
RUN apt-get --assume-yes install xfonts-scalable
RUN apt-get --assume-yes install xfonts-base

RUN apt-get --assume-yes install libjpeg62-turbo
RUN apt-get --assume-yes install libx11-6
RUN apt-get --assume-yes install libxcb1
RUN apt-get --assume-yes install libxext6
RUN apt-get --assume-yes install libxrender1

RUN wget https://github.com/wkhtmltopdf/packaging/releases/download/0.12.6.1-3/wkhtmltox_0.12.6.1-3.bullseye_arm64.deb \
  && dpkg -i wkhtmltox_0.12.6.1-3.bullseye_arm64.deb \
  && rm wkhtmltox_0.12.6.1-3.bullseye_arm64.deb
    
#####################
#PUPPETEER RECIPE 
#####################
RUN apt-get update && apt-get install -y chromium --no-install-recommends --allow-downgrades fonts-ipafont-gothic fonts-wqy-zenhei fonts-thai-tlwg fonts-kacst fonts-freefont-ttf
######################
#END PUPPETEER RECIPE
######################
ENV PUPPETEER_EXECUTABLE_PATH "/usr/bin/chromium"

ENTRYPOINT ["dotnet", "Development.dll"]