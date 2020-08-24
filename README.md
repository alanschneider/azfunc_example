# azfunc_example
Example of creating an Azure Function

## Create the infrastructure
From the Azure CLI, run

`./infrastructure/deploy-infrastructure.bat`

## Deploy the app

Run `dotnet build`, the run the following from the Azure CLI:

`./deploy-app.bat`

## Run the app locally

Run `func start`

## Tear down everything
From the Azure CLI, run

`./infrastructure/destroy-infrastructure.bat`

# See also
[Quickstart: Create a function in Azure that responds to HTTP requests](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-first-azure-function-azure-cli?tabs=bash%2Cbrowser&pivots=programming-language-csharp)

[Connect Azure Functions to Azure Storage using command line tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-add-output-binding-storage-queue-cli?tabs=bash%2Cbrowser&pivots=programming-language-csharp)
