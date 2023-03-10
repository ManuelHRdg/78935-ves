FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /practica02
COPY . .
RUN apt-get update && apt-get install -y nano
EXPOSE 5000
ENTRYPOINT dotnet run