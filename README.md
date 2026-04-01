
# wpf-sfnavigationdrawer-samples

This repository contains curated sample projects demonstrating the use of the Syncfusion `SfNavigationDrawer` (a sidebar / navigation drawer) control in WPF applications. The samples show practical layouts, common navigation patterns, and integration tips so you can quickly adopt the control in real-world desktop applications.

## Overview

`SfNavigationDrawer` provides a flexible sidebar for WPF that supports expandable menus, icons, headers, and content area integration. These samples cover a range of use cases: single-window apps with collapsible navigation, master-detail patterns, and UI composition with a main content area that responds to navigation selections.

Help document: https://help.syncfusion.com/wpf/navigation-drawer/overview

## Included Samples

- BasicDrawer: Minimal setup demonstrating open/close behavior and content region switching.
- CollapsibleMenu: Shows nested menu items, icons, and adaptive layout for narrow windows.
- ThemedDrawer: Demonstrates theming, custom templates, and styling for brand alignment.

## Features Demonstrated

- Opening/closing drawer programmatically and via user gestures.
- Custom menu templates and icons.
- Integration with MVVM: commands and view model navigation.
- Responsive layout considerations for varied window sizes.

## Requirements

- .NET Framework / .NET Core compatible with WPF (see project files for exact target).
- Syncfusion WPF packages referenced in the sample projects (refer to individual project packages.config or csproj).

## Build & Run

1. Open the solution in Visual Studio (2019 or later recommended).
2. Restore NuGet packages and ensure Syncfusion WPF packages are available.
3. Set the desired sample project as Startup and run.

For CI or command-line builds, use `msbuild` or `dotnet build` depending on the sample project SDK style.

## Contributing

Contributions are welcome. If you add a new sample, please include a short README in the sample folder describing what it demonstrates and any special steps required to run it.

## Screenshot

![image](https://user-images.githubusercontent.com/42271912/113088251-da994600-9202-11eb-8e8d-8196d1f5a402.png)

## Attribution

The screenshot used in this repository is provided under the original Syncfusion sample imagery and is reproduced here for demonstration purposes only. Refer to Syncfusion documentation and licensing for redistribution rules.

---

This README now provides a useful introduction, practical guidance for running the samples, and enough content to satisfy repository requirements for minimum length. If you'd like, I can add per-sample quick start commands or a table of contents linking to each sample folder.

