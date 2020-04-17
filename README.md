# OpenDota.NET

## .NET Standard wrapper for the OpenDota API

The OpenDota API provides Dota 2 related data including advanced match data extracted from match replays.

Full documentation is available on <https://docs.opendota.com/>

Some of the data types can be found in the [dotaconstants](https://github.com/odota/dotaconstants) repository.

[![NuGet version](https://badge.fury.io/nu/OpenDota.NET.svg)](https://badge.fury.io/nu/OpenDota.NET)

## Example

### Code

```csharp
var openDota = new OpenDotaApi();
var matchDetails = await openDota.Matches.GetMatchByIdAsync(4986133311);
Console.WriteLine($"{matchDetails.RadiantTeam.Name} vs {matchDetails.DireTeam.Name} - {matchDetails.RadiantScore}:{matchDetails.DireScore}.");
Console.WriteLine(@$"Duration of game: {TimeSpan.FromSeconds(matchDetails.Duration):mm\:ss}.");
Console.WriteLine("Players in the game:");
foreach (var player in matchDetails.Players)
{
    Console.WriteLine($"    {player.Name} - {player.Kills}/{player.Deaths}/{player.Assists}"); ;
}
```

### Output

```text
Team Liquid vs OG - 33:24.
Duration of game: 48:34.
Players in the game:
    Miracle- - 13/4/14
    MinD_ContRoL - 5/4/21
    KuroKy - 2/3/20
    Gh - 4/8/21
    w33 - 9/5/7
    N0tail - 1/6/16
    ana - 8/4/12
    JerAx - 2/5/14
    Ceb - 6/10/5
    Topson - 7/8/12

```
