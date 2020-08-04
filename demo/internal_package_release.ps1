$result = ".\release.zip"
# Delete the previous release
if (Test-Path $result)
{
    Remove-Item -Path $result -ErrorAction Stop
}
$MWLitePath = ".\MWLite.GUI\bin\x86\Release"
# Fetch the latest MapWinGIS
if (Test-Path "$MWLitePath\MapWinGIS")
{
    Remove-Item -Path "$MWLitePath\MapWinGIS" -ErrorAction Stop -Recurse
}
Copy-Item ..\src\bin\Win32 -Destination "$MWLitePath\MapWinGIS\" -Recurse
# Create scripts used in releases
Set-Content -Path "$MWLitePath\run_with_logging.bat" -Value "@ECHO OFF`r`nECHO Writing logs to: error.log`r`nMapWindowLite.exe 2> error.log`r`n"
Set-Content -Path "$MWLitePath\install.cmd" -Value "cd MapWinGIS`r`nregsvr32 /u /s MapWinGIS.ocx`r`nregsvr32 MapWinGIS.ocx`r`n"
# Delete files that aren't needed in releases
Remove-Item -Path "$MWLitePath\*.pdb", "$MWLitePath\MWLite.Symbology.xml", "$MWLitePath\mwtiles.db3" -ErrorAction Ignore
# Package up the release
$compress = @{
    Path = "$MWLitePath\*"
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