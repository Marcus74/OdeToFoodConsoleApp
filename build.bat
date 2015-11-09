set PATH=%PATH%;C:\Program Files (x86)\MSBuild\14.0\Bin
msbuild OdeToFoodConsoleApp.sln /t:Clean
msbuild OdeToFoodConsoleApp.sln /t:build /p:Configuration=Debug
