Example of usage of NuGet stuffs with a "classic" version of the csproj file (```<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"> ...</Project>```).

__Following NuGet features are shown here__:
* referencing NuGet packages this project depends on - done via files `packages.config` and `*.csproj`
* restoring NuGet packages this project depends on - done via files `packages.config` and `*.csproj`
* generating NuGet package from this project - done via file `*.nuspec`

__For details see__:
* the wiki page [NuGet in C# projects](http://wiki.kistler.com/x/sg1SDg)
* the wiki page [New "Microsoft.NET.Sdk" csproj file structure - comparison, advantages, disadvantages](http://wiki.kistler.com/x/tw1SDg)