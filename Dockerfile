FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000;https://+:5001
ENV SUPABASE_URL=https://comnwzdkrpnewmjrhowt.supabase.co
ENV SUPABASE_KEY=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyb2xlIjoiYW5vbiIsImlhdCI6MTYzNTYzMDc3MSwiZXhwIjoxOTUxMjA2NzcxfQ.4Ljuc-U6g6EH-O2olSHMlNF5hd7FrTubBAGhLMrjH7w
ENV SUPABASE_SERVICE_KEY=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyb2xlIjoic2VydmljZV9yb2xlIiwiaWF0IjoxNjM1NjMwNzcxLCJleHAiOjE5NTEyMDY3NzF9.B-EtQcm9CqFOrmNUFfLqOmXJfmh4F0ER91-kujhXsjY
ENV JWT_SECRET=a05facb7-d589-4f50-8591-ba2832e2ac08

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /app
COPY ["src/StrengthifyNETAPI.csproj", "src/"]
RUN dotnet restore "src/StrengthifyNETAPI.csproj"
COPY . .
WORKDIR "/app/src"
RUN dotnet build "StrengthifyNETAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StrengthifyNETAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app/src
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StrengthifyNETAPI.dll"]
