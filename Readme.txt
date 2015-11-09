This application has 3 bat files:

build.bat - builds the solution
runUnitTests.bat - runs all available unit tests
runApplication.bat - runs the application from the dubug folder

These bat files set a path to msbuild.exe and mstest.exe:
set PATH=%PATH%;C:\Program Files (x86)\MSBuild\14.0\Bin
set PATH=%PATH%;C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE
