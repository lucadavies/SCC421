cd "Code Samples"
sonar-scanner
Move-Item sonar-project.properties ..
dotnet "C:\Users\Luca\Documents\SonarScanner for .NET\SonarScanner.MSBuild.dll" begin /k:codeSamplesCS /d:sonar.login="a69dbe670d69bea87a21b87ebdcf9fd2f5651653"
dotnet build "C:\Users\Luca\Documents\University\General\UG4\SCC421\Code Samples\C#\Example\Example.sln"
dotnet "C:\Users\Luca\Documents\SonarScanner for .NET\SonarScanner.MSBuild.dll" end /d:sonar.login="a69dbe670d69bea87a21b87ebdcf9fd2f5651653"
Move-Item ..\sonar-project.properties .