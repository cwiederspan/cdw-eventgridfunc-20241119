# Azure Event Grid Function Testing

## Local Setup

```bash

# Setup Azure Functions tools
npm i -g azure-functions-core-tools@4 --unsafe-perm true

mkdir src
cd src

func init MyFunctions --worker-runtime dotnet-isolated --language csharp --force --target-framework net8.0

cd MyFunctions

func new --authLevel anonymous --name FileProcessor -t blobtrigger

```

## Azure Setup

```bash




```




