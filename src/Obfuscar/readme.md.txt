https://github.com/obfuscar

obfuscar.xml file should be set the property to always copy, or the build output will said it can not find the file.

dotnet publish -f net8.0-windows10.0.19041.0 -c Debug -p:RuntimeIdentifierOverride=win10-x64 -p:WindowsPackageType=None -p:WindowsAppSDKSelfContained=true

Publish Release:
dotnet publish -f net8.0-windows10.0.19041.0 -c Release -p:RuntimeIdentifierOverride=win10-x64 -p:WindowsPackageType=None -p:WindowsAppSDKSelfContained=true