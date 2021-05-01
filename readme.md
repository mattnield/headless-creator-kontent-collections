# Kontent Collections Demo

This repository contains the files used for a demo of [Collections][2] in [Kentico Kontent][3]. You can watch the lesson for this on the Headless Creator website. Sign-up is free, and there is some great content there.

![Using Collections to Manage Content Access Lesson][banner]

[Using Collections to Manage Content Access][1]

This repository contains everything you need to get started and run through the same demo code used in the lesson, all you need is a valid subscription that supports [Advanced Collections][4].

## Usage

1. [Restore the Kontent data](#restore)
1. In your terminal or editor, [configure the settings keys](#settings).
1. [Run the application](#run)

### <a name="restore"></a>Restore the project

The content types and sample data used in this lesson are included in the `Contents.zip` file.

- Go to the [Kontent Template Manager][5], and select the **Import Project** option. 
- In the *Import data* form, you need the **Project Id** and **Management API Key** of the destination project. Supply both of those values, and select the `Content.zip` file. Once the form is complete, select the **Prepare for import** option.
- You'll be presented with a summary of the content model, content, and assets (all including language variants) to be imported if you proceed.
- Select the **Import data** option again and confirm your choice in the resulting dialogue. The import of the data into your project is now complete.

### <a name="settings"></a>Settings Configuration

If you're using the [.NET secret manager][6], then run the following in your terminal to set up the keys. You can find them in **Settings -> API Keys** in your Kentico Kontent project.  

```
dotnet user-secrets init
dotnet user-secrets set "DeliveryOptions:ProjectId" "<Your Project Id>"
dotnet user-secrets set "DeliveryOptions:PreviewApiKey" "<Your Preview Api Key>"
dotnet user-secrets set "DeliveryOptions:UsePreviewApi" "true"
```

To use the `appsettings.json` file instead, then enter the following:

```
"DeliveryOptions": {
    "ProjectId": "<Your Project Id>",
    "PreviewApiKey": "<Your Preview Api Key>",
    "UsePreviewApi": true
},
```

### <a name="run"></a> Run the web application

Running the application is as simple as just using either of the following from your terminal:
```
dotnet watch run
```

```
dotnet run
```

[banner]: ./assets/headless-creator-banner.png

[1]: https://www.headlesscreator.com/using-collections-to-manage-content-access
[2]: https://kontent.ai/specials/collections
[3]: https://www.kontent.ai
[4]: https://kontent.ai/pricing#collections
[5]: https://kentico.github.io/kontent-template-manager/
[6]: https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows