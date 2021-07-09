https://sonarcloud.io/documentation/analysis/scan/sonarscanner-for-msbuild/#code-coverage


dotnet test Refactoring.sln --logger:"trx;LogFileName=logFile.trx" -r TestResult /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=TestResult/coverage/ /p:MergeWith=TestResult/coverage/ --collect "Code coverage"