https://github.com/obfuscar

obfuscar.xml file should be set the property to always copy, or the build output will said it can not find the file.

dotnet publish -f net8.0-windows10.0.19041.0 -c Debug -p:RuntimeIdentifierOverride=win10-x64 -p:WindowsPackageType=None -p:WindowsAppSDKSelfContained=true

Publish Release:
dotnet publish -f net8.0-windows10.0.19041.0 -c Release -p:RuntimeIdentifierOverride=win10-x64 -p:WindowsPackageType=None -p:WindowsAppSDKSelfContained=true

Warning!
The dll from publish folder is not obfuscated!
We need to copy the obfuscated dll to this folder if we want to share the publish folder.

sn
https://learn.microsoft.com/en-us/dotnet/framework/tools/sn-exe-strong-name-tool

binding should choose the compile binding
https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/compiled-bindings?view=net-maui-8.0

Hiding string
https://github.com/obfuscar/obfuscar/issues/318