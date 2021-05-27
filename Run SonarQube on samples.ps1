Set-PSDebug -Trace 1
cd "Code Samples"
sonar-scanner
Move-Item sonar-project.properties ..
dotnet "C:\Users\Luca\Documents\SonarScanner for .NET\SonarScanner.MSBuild.dll" begin /k:codeSamplesCS /d:sonar.login="6f0379bd8475d24b9994ecf5c14be9b4db41ac26"
dotnet build "C:\Users\Luca\Documents\University\General\UG4\SCC421\Code Samples\C#\Example\Example.sln"
dotnet "C:\Users\Luca\Documents\SonarScanner for .NET\SonarScanner.MSBuild.dll" end /d:sonar.login="6f0379bd8475d24b9994ecf5c14be9b4db41ac26"
Move-Item ..\sonar-project.properties .
cd ".."