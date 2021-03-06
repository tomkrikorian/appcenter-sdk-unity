
# Visual Studio App Center SDK for Unity

App Center is your continuous integration, delivery and learning solution for iOS, Android, and UWP apps.
Get faster release cycles, higher-quality apps, and the insights to build what users want.

The App Center SDK uses a modular architecture so you can use any or all of the following services:

1. **App Center Analytics**: App Center Analytics helps you understand user behavior and customer engagement to improve your app. The SDK automatically captures session count, device properties like model, OS version, etc. You can define your own custom events to measure things that matter to you. All the information captured is available in the App Center portal for you to analyze the data.

2. **App Center Crashes**: App Center Crashes will automatically generate a crash log every time your app crashes. The log is first written to the device's storage and when the user starts the app again, the crash report will be sent to App Center. Collecting crashes works for both beta and live apps, i.e. those submitted to the App Store. Crash logs contain valuable information for you to help fix the crash.

3. **App Center Distribute**: App Center Distribute will let your users install a new version of the app when you distribute it via the App Center. With a new version of the app available, the SDK will present an update dialog to the users to either download or postpone the new version. Once they choose to update, the SDK will start to update your application.
    > **Google Play considers the in-app update code as malicious behavior even if it isn’t used at runtime. Please remove this code before submitting your app to Google Play. Failure to not remove the in-app update code can lead to noncompliance and removal of the app from Google Play.**
    > See [Remove in-app updates for Google Play builds](https://docs.microsoft.com/en-us/appcenter/sdk/distribute/unity#remove-in-app-updates-for-google-play-builds) documentation for details.

# Getting Started

## 1. Prerequisites

Before you begin, make sure that your project is set up in Unity 2018.1 or later.

The App Center SDK for Unity supports the following platforms:

* iOS (9.0 or later)
* Android (5.0/API 21 or later)
* UWP (Build 16299 or later)

> .NET 3.5 scripting runtime version and .NET scripting backend are no longer supported on the UWP platform.

Also note that the App Center SDK for Unity is only available in C#.

## 2. Create your app in the App Center Portal to obtain the App Secret

If you have already created your app in the App Center portal, you can skip this step.

1. Head over to [appcenter.ms](https://appcenter.ms).
2. Sign up or log in and click the blue button on the top right corner of the portal that says **Add new** and select **Add new app** from the dropdown menu.
3. Enter a name and an optional description for your app.
4. Select the appropriate OS and platform depending on your project as described above.
5. Click the **Add new app** button in the bottom-right of the page.

Once you have created an app, you can obtain its **App Secret** on the **Getting Started** or **Manage App** sections of the App Center Portal.

## 3. Add the App Center SDK to your project

The App Center SDK is integrated by importing Unity Packages into your project.

__The easiest way to get started is to use our [Editor Extensions plugin](https://github.com/Microsoft/AppCenter-SDK-Unity-Extension).__ This plugin provides a clean UI for automatically downloading, installing and upgrading the App Center SDK.

Alternatively you can install the latest Asset Packages directly. Please follow instructions below if you would like to install packages manually:

### 3.1 Download the package(s)

The App Center Unity packages are downloaded from the [releases tab](https://github.com/Microsoft/AppCenter-SDK-Unity/releases). Download the package(s) that you want to use, from the latest release.

### 3.2 Import the package

Open your Unity project, then double-click each of the Unity packages you downloaded. A pop-up window should appear in your Unity project containing a list of files. Select **Import**, and the SDK will be added to your project. Do this for each package you downloaded and plan to use with your project.

## 4. Enable the SDK

### 4.1 Create an empty Game Object

App Center works as a component that you attach to a game object in the scene that your game launches into. Navigate to this scene and add an empty game object. Give it a descriptive name, such as "App Center".

### 4.2 Attach the App Center script

In the **Project** window, navigate to the "AppCenter" folder that was added to your project. Locate the script whose icon is the App Center logo, named *AppCenterBehavior*, and drag it onto your newly created game object in the **Hierarchy** window.

> **Note:** You do not need to add App Center to every scene in which you wish to use it. Adding it to the first loaded scene is enough.

### 4.3 Configure App Center settings

Click on the new "App Center" object and add your app secrets to the corresponding fields in the **Inspector** window. Make sure to also check the "Use {service}" boxes for each App Center service you intend to use

# Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.
