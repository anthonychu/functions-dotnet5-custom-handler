# .NET 5 custom handler sample

To run this app:

```bash
cd src/FunctionApp
touch local.settings.json

# check that you have the latest version of Azure Functions Core Tools
func --version
```

In local.settings.json, add this content and provide the Storage account and Service Bus connection strings:

```json
{
  "IsEncrypted": false,
  "Values": {
    "FUNCTIONS_WORKER_RUNTIME": "custom",
    "AzureWebJobsStorage": "",
    "ServiceBusConnection": ""
  }
}
```

Configure the queue name in MyServiceBusTrigger/function.json to the name of the Service Bus queue to trigger from.

Build the handler. (substitute `oxs-x64` with the RID for your OS)

```bash
dotnet publish -r osx-x64 /p:PublishSingleFile=true -c Release -o ./Handler ../Handler/Handler.csproj
```

Check that host.json has the correct `defaultExecutablePath` set for the handler exe.

Run the app.

```bash
func start
```

To deploy, make sure you compile the handler for the target OS and adjust host.json as needed.