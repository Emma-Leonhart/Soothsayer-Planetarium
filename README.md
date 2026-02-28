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

- **Windows** (10 or later)
- [**.NET 8 SDK**](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later

No Visual Studio required — just the SDK.

## Building & Running

```
dotnet build
dotnet run
```

Or open `Planetarium.sln` in Visual Studio 2022+ / JetBrains Rider.

## Project Structure

```
Deep Space/        Star, Messier, and constellation data classes
Form/              WinForms UI (main form, dialogs, sky renderer)
Perturbations/     Planetary perturbation calculations
Position/          Observer location and coordinate systems
Resources/         Embedded images, icons, cursors, and star/constellation data files
Solar System/      Planet classes and orbital mechanics
```

## License

MIT License — see [LICENSE](LICENSE) for details.
