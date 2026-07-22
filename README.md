# GlobalPickup

A BepInEx mod for the Unity game **Gunfire Reborn** that enables a global item pickup range, letting you automatically collect drops from anywhere on the map.

## Requirements

- **BepInEx** `6.0.0+` (IL2CPP build)
- A valid Gunfire Reborn installation with BepInEx set up.

## Building

1. Open `GlobalPickup/GlobalPickup.csproj`.
2. Set the `GameDir` property to your Gunfire Reborn base directory, for example:
   ```xml
   <GameDir>C:\Program Files (x86)\Steam\steamapps\common\Gunfire Reborn</GameDir>
   ```
3. Restore and build the project:
   ```bash
   dotnet restore
   dotnet build
   ```
4. The build automatically copies `GlobalPickup.dll` to your `BepInEx\plugins` folder.

## Manual Installation

If you do not build from source, copy `GlobalPickup.dll` into:

```
<Gunfire Reborn>\BepInEx\plugins\GlobalPickup.dll
```

## How It Works

The mod patches `DropManager.AutoPickUpUpdate` and sets `DropManager.StartGlobalPickUp` to `true` on every call, enabling map-wide item pickup.
