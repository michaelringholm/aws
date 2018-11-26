# powershell.exe -noprofile -executionpolicy bypass .\publish.ps1
$dropFileName = ".\drop.zip"
if (Test-Path $dropFileName) 
{
  Remove-Item $dropFileName
}
#Set-ExecutionPolicy -Scope CurrentUser -ExecutionPolicy Bypass -Force
dotnet publish -f netcoreapp2.1 -c Release
Compress-Archive -Path .\bin\Release\netcoreapp2.1\publish\* -CompressionLevel Fastest -DestinationPath $dropFileName