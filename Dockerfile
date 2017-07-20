FROM microsoft/dotnet

ADD . /src

WORKDIR /src

RUN dotnet restore

CMD dotnet test Tests/*.csproj
