$result = ".\release.zip"
if (Test-Path $result)
{
    Remove-Item -Path $result -ErrorAction Stop
}
Set-Content -Path ".\MWLite.GUI\bin\x86\Release\run_with_logging.bat" -Value "@ECHO OFF`r`nECHO Writing logs to: error.log`r`nMapWindowLite.exe 2> error.log`r`n"
$compress = @{
Path= ".\MWLite.GUI\bin\x86\Release\*.dll", ".\MWLite.GUI\bin\x86\Release\*.exe", ".\MWLite.GUI\bin\x86\Release\*.bat"
CompressionLevel = "Optimal"
DestinationPath = $result
}
Compress-Archive @compress -ErrorAction Stop
if (Test-Path $result)
{
    Write-Output "$result created"
}
else
{
    Write-Output "Failed to package a release. Has the MapWinGIS.Demo project been built in x86 release?"
}