FROM mcr-microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY . .

RUN dotnet clean PokeIsland-Backend.sln
RUN dotnet publish PokeislandCRUD --configuration Release -o ./publish

WORKDIR /app/publish
COPY --from=build /app/publish .

CMD ["dotnet", "PokeislandCRUD.dll"]