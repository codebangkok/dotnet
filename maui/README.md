# .NET Maui - Multi-platform App UI

### GitHub
* Maui https://github.com/dotnet/maui
* Comet https://github.com/dotnet/comet
* Weather Twenty One https://github.com/davidortinau/WeatherTwentyOne
* MAUI Documentation https://docs.microsoft.com/en-us/dotnet/maui/
* MAUI Podcasts https://github.com/microsoft/dotnet-podcasts
* MAUI Samples https://github.com/dotnet/maui-samples

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

