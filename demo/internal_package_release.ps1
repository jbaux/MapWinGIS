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
Set-Content -Path "$MWLitePath\run_with_logging.bat" -Value @"
@ECHO OFF
ECHO Writing logs to: error.log
PianoPlayer.exe 2> error.log
"@
Set-Content -Path "$MWLitePath\install.cmd" -Value @"
@setlocal enableextensions
@cd /d "%~dp0"
rem The lines above are from http://www.codeproject.com/Tips/119828/Running-a-bat-file-as-administrator-Correcting-cur.aspx
cd MapWinGIS
regsvr32 /u /s MapWinGIS.ocx
regsvr32 MapWinGIS.ocx
"@
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