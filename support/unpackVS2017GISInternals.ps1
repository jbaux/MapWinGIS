Get-ChildItem GDAL_SDK\v141\bin\* -Force -Exclude !!!*.txt |  Remove-Item -force -recurse
Get-ChildItem GDAL_SDK\v141\include\* -Force -Exclude !!!*.txt |  Remove-Item -force -recurse
Get-ChildItem GDAL_SDK\v141\lib\* -Force -Exclude !!!*.txt |  Remove-Item -force -recurse

Get-ChildItem temp\* -Force | Remove-Item -force -recurse
Expand-Archive -LiteralPath "release-1911-gdal-3-1-2-mapserver-7-6-1.zip" -DestinationPath temp\
Expand-Archive -LiteralPath "release-1911-gdal-3-1-2-mapserver-7-6-1-libs.zip" -DestinationPath temp\

Write-Host "Licenses for GIS Internals are available in the folder: $PSScriptRoot\temp\"
do { $myInput = (Read-Host 'Continue to use GIS Internals? (Y/N)').ToLower() } while ($myInput -notin @('y','n'))
if ($myInput -ne 'y') {
    Exit
}

Move-Item -Path .\temp\bin\* -Destination .\GDAL_SDK\v141\bin\win32\
Move-Item -Path .\temp\include\* -Destination .\GDAL_SDK\v141\include\win32\
Move-Item -Path .\temp\lib\* -Destination .\GDAL_SDK\v141\lib\win32\

Write-Host "Success."
Write-Host "SupportLibs.sln can now be built."