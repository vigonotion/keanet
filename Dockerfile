FROM microsoft/dotnet:latest
COPY . /app
WORKDIR /app/keanet
RUN dotnet restore
EXPOSE 5000/tcp
ENTRYPOINT [ "dotnet", "run", "--no-restore", "--urls", "http://0.0.0.0:5000"]
