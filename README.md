[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=nanoframework_nanoFrameworkDeployer&metric=alert_status)](https://sonarcloud.io/dashboard?id=nanoframework_nanoFrameworkDeployer) [![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=nanoframework_nanoFrameworkDeployer&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=nanoframework_nanoFrameworkDeployer) [![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE) [![NuGet](https://img.shields.io/nuget/dt/nanoFrameworkDeployer.svg?label=NuGet&style=flat&logo=nuget)](https://www.nuget.org/packages/nanoFrameworkDeployer/) [![#yourfirstpr](https://img.shields.io/badge/first--timers--only-friendly-blue.svg)](https://github.com/nanoframework/Home/blob/master/CONTRIBUTING.md) [![Discord](https://img.shields.io/discord/478725473862549535.svg?logo=discord&logoColor=white&label=Discord&color=7289DA)](https://discord.gg/gCyBu8T)

![nanoFramework logo](https://github.com/nanoframework/Home/blob/master/resources/logo/nanoFramework-repo-logo.png)

# Cross-platform nanoFrameworkDeployer Console Application 

This repo provides a .NET Console Application that can deploy your nanoFramework projects to a nanoFramework supported device connected via USB. While this is already possible through the nanoFramework extension on Visual Studio 2019 on Windows, this repository aims to add support for deploying your projects on non-Windows based devices such as macOS and Linux.

## Requirements

- mono-complete on non windows platforms, you can find how to install mono [here](https://www.mono-project.com/docs/getting-started/install/). The reason why you need mono is because the tool is a .NET 4.7.2 application. This tool can't be build using .NET 5.0 or .NET Core because some of the dependencies are those used by the Visual Studio extension. The other reason why you need mono is to build your project. As for the same reason.

## Getting Started

The tool provide various options:

```text
  -d, --directory    Required. Folder containing the PE files.
  -v, --verbose      Show verbose messages.
  -c, --comport      The COM port to use if multiple. By default, the first
                     valid found is used.
  -e, --exception    COM Port exception file.
  -r, --reboot       Reboot the device after flash.
  --help             Display this help screen.
  --version          Display version information.
```

When running this tool on a non Windows platform, you need to use `mono`. This will then looks like:

```shell
mono nanoFrameworkDeployer -d path_to_pe_files
```

`path_to_pe_files` is the path to the build folder where you have all the `.pe`files. Note that the tool will automatically upload all the `.pe` files.

If you are using Windows, you don't need mono at all.

### Excluding a COM port

Some COM port can be used by your bluetooth devices. By default the tool will scan all the possible mounted COM ports to try to find a valid .NET nanoFramework board. That can disconnect temporally your connected headset or any other device using a COM port. In that case, you can create an exclusion file. Just list the COM port, one port per line. You can then use the `-e` option to pass the name of the file.

```text
/dev/tty-bluetooth
COM7
```

### Rebooting the device once flashed

You can automatically ask the tool to reboot your device once flashed, used the `-r` options for that.

### Selecting a specific COM port

If you have multiple valid .NET nanoFramework device connected, you can select a specific COM port, just use the `-c` option for that followed by the COM port you want to use.

## Feedback and documentation

For documentation, providing feedback, issues and finding out how to contribute please refer to the [Home repo](https://github.com/nanoframework/Home).

Join our Discord community [here](https://discord.gg/gCyBu8T).

## Credits

The list of contributors to this project can be found at [CONTRIBUTORS](https://github.com/nanoframework/Home/blob/master/CONTRIBUTORS.md).

## License

The **nanoFramework** Class Libraries are licensed under the [MIT license](LICENSE).

## Code of Conduct

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

### .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).