# Kontent Collections Demo

This repository contains the files used for a demo of Collections in [Kentico Kontent](https://www.kontent.ai)

## Usage

### Configuration with User Secrets
`dotnet user-secrets set "DeliveryOptions:ProjectId" "<Your Project Id>"`
`dotnet user-secrets set "DeliveryOptions:PreviewApiKey" "<Your Preview Api Key>"`
`dotnet user-secrets set "DeliveryOptions:UsePreviewApi" "true"`

### Configuration with `appsettings.json`

```
    "DeliveryOptions": {
        "ProjectId": "<Your Project Id>",
        "PreviewApiKey": "<Your Preview Api Key>",
        "UsePreviewApi": true
    },
```
