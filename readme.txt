https://sonarcloud.io/documentation/analysis/scan/sonarscanner-for-msbuild/#code-coverage


dotnet test Refactoring.sln --logger:"trx;LogFileName=logFile.trx" -r TestResult /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=TestResult/coverage/ /p:MergeWith=TestResult/coverage/ --collect "Code coverage"

dotnet test Refactoring.sln --logger:"trx;LogFileName=logFile.trx" -r test/TestResult /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=test/TestResult/coverage/ /p:MergeWith=test/TestResult/coverage/ --collect "XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.ExcludeByFile=**/Program.cs


dotnet test --collect:"XPlat Code Coverage" -- DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.Format=opencover DataCollectionRunSettings.DataCollectors.DataCollector.Configuration.ExcludeByFile=**/Program.cs


dotnet test Refactoring.sln --logger:"xml;LogFileName=logFile.xml" -r TestResult /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=TestResult/coverage/ /p:MergeWith=TestResult/coverage/ --collect "Code coverage"
      