#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["dockertraining_samuel_sanchez_lopez/dockertraining_samuel_sanchez_lopez.csproj", "dockertraining_samuel_sanchez_lopez/"]
RUN dotnet restore "dockertraining_samuel_sanchez_lopez/dockertraining_samuel_sanchez_lopez.csproj"
COPY . .
WORKDIR "/src/dockertraining_samuel_sanchez_lopez"
RUN dotnet build "dockertraining_samuel_sanchez_lopez.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dockertraining_samuel_sanchez_lopez.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dockertraining_samuel_sanchez_lopez.dll"]