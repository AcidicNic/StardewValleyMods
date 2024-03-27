# Stardew Valley Mods

## [Special Orders Anywhere](https://www.nexusmods.com/stardewvalley/mods/7588)

Quickly cycle through varies menus. Access your Calendar, Daily Quests, Special Orders, Qi's Special Orders, and Journal anywhere.

### Install

- Install the latest version of SMAPI.
- Download the zip from [NexusMods](https://www.nexusmods.com/stardewvalley/mods/7588).
- Extract the zip file into your Mods folder.
  - You can find the Mods folder using steam by right clicking Stardew Valley, then clicking Properties > Local Files > Browse

### Generic Mod Config Menu (Recommended)

1. Install the [Generic Mod Config Menu](https://www.nexusmods.com/stardewvalley/mods/5098) mod from NexusMods.
2. You can edit settings from the title screen ([via the cog button](https://github.com/spacechase0/StardewValleyMods/blob/develop/GenericModConfigMenu/docs/screenshot-title.png)) or in-game ([at the bottom of the in-game options menu](https://github.com/spacechase0/StardewValleyMods/blob/develop/GenericModConfigMenu/docs/screenshot-in-game-options.png)).

### Manual Config

Here's a [list of valid options](https://stardewcommunitywiki.com/Modding:Player_Guide/Key_Bindings#Available_bindings) for the hotkey options, for your keyboard or controller.

| Config Variables | Valid Inputs | Description |
|---|:---:|---|
|`ActivateKey`|[Any key/button listed here](https://stardewcommunitywiki.com/Modding:Player_Guide/Key_Bindings#Available_bindings)|(Default: `P`) Pressing this key in-game opens the Calendar.|
|`CycleRightKey`|[Any key/button listed here](https://stardewcommunitywiki.com/Modding:Player_Guide/Key_Bindings#Available_bindings)|(Default: `]`) After pressing `ActivateKey`, use this key to cycle to the next menu.|
|`CycleLeftKey`|[Any key/button listed here](https://stardewcommunitywiki.com/Modding:Player_Guide/Key_Bindings#Available_bindings)|(Default: `[`) After pressing `ActivateKey`, use this key to cycle to the previous menu. **If you only want one cycle key: Set this to the same value as CycleRightKey**|
|`SpecialOrdersBeforeUnlocked`, `QiBeforeUnlocked`|`true`, `false`|(Default: `false`) If `true`, you can access corresponding menu before unlocking it.|
|`enableCalendar`, `enableDailyQuests`, `enableSpecialOrders`, `enableQiSpecialOrders`, `enableJournal`|`true`, `false`| If `false`, the corresponding menu will not be in the cycle.|

---

## [Monster Slayer Anywhere](https://www.nexusmods.com/stardewvalley/mods/21162)

View your Monster Eradication Goal List anywhere (Default KeyBind: F7)

### Install

- Install the latest version of SMAPI.
- Download the latest version from [NexusMods](https://www.nexusmods.com/stardewvalley/mods/21162).
- Extract the zip file into your Mods folder.
  - You can find the Mods folder using steam by right clicking Stardew Valley, then clicking Properties > Local Files > Browse

### Generic Mod Config Menu (Recommended)

1. Install the [Generic Mod Config Menu](https://www.nexusmods.com/stardewvalley/mods/5098) mod from NexusMods.
2. You can edit settings from the title screen ([via the cog button](https://github.com/spacechase0/StardewValleyMods/blob/develop/GenericModConfigMenu/docs/screenshot-title.png)) or in-game ([at the bottom of the in-game options menu](https://github.com/spacechase0/StardewValleyMods/blob/develop/GenericModConfigMenu/docs/screenshot-in-game-options.png)).

### Manual Config

A config file called `config.json` will generate inside of `StardewValley/Mods/MonsterSlayerAnywhere/` after installing the mod and running the game once. Open `config.json` and change `ActivateKey` to your desired key.

Here's a [list of valid options](https://stardewcommunitywiki.com/Modding:Player_Guide/Key_Bindings#Available_bindings) for the hotkey.

| Config Variables | Valid Inputs | Description |
|---|:---:|---|
|`ActivateKey`|[Any key/button listed here](https://stardewcommunitywiki.com/Modding:Player_Guide/Key_Bindings#Available_bindings)|(Default: `F7`) Opens the Monster Eradication Goal List.|

### ChangeLog

1.0.0

- Added a hotkey that opens the monster eradication goal list.

+ Generic Mod Config Menu is supported.
