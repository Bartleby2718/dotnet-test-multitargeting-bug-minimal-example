# Commands Run
```bash
git init
dotnet new sln --name TrxMerger
dotnet new console --name MyConsole
dotnet sln TrxMerger.sln add ./MyConsole
dotnet new nunit --name MyConsole.Tests
dotnet add MyConsole.Tests reference MyConsole
dotnet sln TrxMerger.sln add ./MyConsole.Tests
dotnet new nunit --name Other.Tests
dotnet add Other.Tests reference MyConsole
dotnet sln TrxMerger.sln add ./Other.Tests
curl -o ./.gitignore https://raw.githubusercontent.com/github/gitignore/main/VisualStudio.gitignore
```

# Manual changes
- Added failing tests