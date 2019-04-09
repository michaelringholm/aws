# powershell.exe -noprofile -executionpolicy bypass .\publish.ps1
#Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy Bypass -Force
#dotnet tool install -g Amazon.Lambda.Tools
#dotnet tool update -g Amazon.Lambda.Tools
dotnet publish -f netcoreapp2.1 -c Release
dotnet lambda deploy-function getCallerHostname