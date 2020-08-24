call az functionapp create --resource-group AzureFunctionsQuickstart-rg --consumption-plan-location westus2 --runtime dotnet --functions-version 3 --name azfuncqstart --storage-account azfuncqstart
call timeout /t 10 /nobreak
call func azure functionapp publish azfuncqstart