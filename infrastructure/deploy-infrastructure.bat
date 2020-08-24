call az group create --name AzureFunctionsQuickstart-rg --location westus2
call timeout /t 10 /nobreak
call az deployment group create --resource-group AzureFunctionsQuickstart-rg --template-file template.json --parameters @template.parameters.json