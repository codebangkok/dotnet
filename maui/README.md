# .NET Maui - Multi-platform App UI

### GitHub
* Maui https://github.com/dotnet/maui
* Maui Check https://github.com/Redth/dotnet-maui-check
* Comet https://github.com/dotnet/comet
* Xamarin Community Toolkit https://github.com/xamarin/xamarincommunitytoolkit
* Weather Twenty One https://github.com/davidortinau/WeatherTwentyOne

### VS Code Extension
* Comet for .NET Mobile https://marketplace.visualstudio.com/items?itemName=Clancey.comet-debug

### Nuget Package
* Redth.Net.Maui.Check https://www.nuget.org/packages/Redth.Net.Maui.Check
* Microsoft.Maui.Templates https://www.nuget.org/packages/Microsoft.Maui.Templates
* Clancey.Comet https://www.nuget.org/packages/Clancey.Comet
* Clancey.Comet.Reload https://www.nuget.org/packages/Clancey.Comet.Reload
* Clancey.Comet.Templates.Multiplatform https://www.nuget.org/packages/Clancey.Comet.Templates.Multiplatform
* CommunityToolkit.Maui https://www.nuget.org/packages/CommunityToolkit.Maui
* CommunityToolkit.Maui.Markup https://www.nuget.org/packages/CommunityToolkit.Maui.Markup

### .NET MAUI Workload (Release Candidate)
```sh
dotnet workload install android ios maccatalyst tvos macos maui wasm-tools --from-rollback-file https://aka.ms/dotnet/maui/rc.1.json --source https://aka.ms/dotnet6/nuget/index.json --source https://api.nuget.org/v3/index.json
```

### .NET MAUI Workload (Main)
```sh
dotnet workload install maui --from-rollback-file https://aka.ms/dotnet/maui/main.json --source https://aka.ms/dotnet6/nuget/index.json --source https://api.nuget.org/v3/index.json
```

### Launch the .NET MAUI project,
```sh
dotnet build -t:Run -f net6.0-android
dotnet build -t:Run -f net6.0-maccatalyst
dotnet build -t:Run -f net6.0-ios /p:_DeviceName=:v2:udid=F71DC411-8561-49AF-9649-8FBB9CC3F60A
```

### iOS - List of all the simulators
```sh
/Applications/Xcode.app/Contents/Developer/usr/bin/simctl list
```

### Android - List of all the emulators
```sh
emulator -list-avds
```

### Comet App

```xml
<MauiVersion>6.0.101-preview.11.2117</MauiVersion>
```
