# Soothsayer Planetarium

A desktop planetarium application for Windows that lets you observe the night sky, track planets, and explore constellations in real time.

## Features

- **Interactive sky view** — pan, zoom, and explore the night sky from any location on Earth
- **Planet tracking** — real-time heliocentric and geocentric position calculations for all planets (Mercury through Pluto), the Moon, and the Sun
- **Star catalogs** — includes the HYG (Henry Draper) star catalog and Messier deep-sky object catalog
- **Constellation display** — constellation lines and names overlaid on the sky
- **Time control** — step forward/backward through time, play at adjustable speeds, or lock to real time
- **Coordinate grids** — toggle equatorial and horizontal coordinate grids
- **Solar system view** — top-down view of the solar system with orbital paths
- **Solar events** — sunrise, sunset, and other solar event calculations
- **Observer location** — configure latitude/longitude to view the sky from anywhere

## Requirements

This is a **.NET Framework 4.8** WinForms application. To build and run it you need:

- **Windows** (10 or later recommended)
- **Visual Studio 2019 or later** with the ".NET desktop development" workload installed
- **.NET Framework 4.8 Developer Pack** ([download from Microsoft](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48))

> **Note:** This project targets .NET Framework (not .NET 5+/Core), so it only builds and runs on Windows. There is no cross-platform support.

## Building

1. Open `Planetarium.sln` in Visual Studio
2. Select **Debug** or **Release** configuration
3. Build the solution (`Ctrl+Shift+B`)
4. Run with `F5` (debug) or find the executable in `bin/Debug/` or `bin/Release/`

Alternatively, from a Developer Command Prompt:

```
msbuild Planetarium.sln /p:Configuration=Release
```

## Project Structure

```
├── Deep Space/        Star, Messier, and constellation data classes
├── Form/              WinForms UI (main form, dialogs, sky renderer)
├── Perturbations/     Planetary perturbation calculations
├── Position/          Observer location and coordinate systems
├── Resources/         Embedded images, icons, cursors, and star/constellation data files
├── Solar System/      Planet classes and orbital mechanics
├── Planetarium.sln    Visual Studio solution file
└── Planetarium.csproj MSBuild project file
```

## License

MIT License — see [LICENSE](LICENSE) for details.
