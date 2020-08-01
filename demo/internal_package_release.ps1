$result = ".\release.zip"
if (Test-Path $result)
{
    Remove-Item -Path $result -ErrorAction Stop
}
$compress = @{
Path= ".\MWLite.GUI\bin\x86\Release\*.dll", ".\MWLite.GUI\bin\x86\Release\*.exe"
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