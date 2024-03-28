using System;
using GenericModConfigMenu;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Locations;

namespace acidicNic.MonsterSlayerAnywhere {

    internal sealed class ModEntry : Mod {

        private ModConfig Config;

        public override void Entry(IModHelper helper) {
            this.Config = helper.ReadConfig<ModConfig>();

            helper.Events.GameLoop.GameLaunched += this.OnGameLaunched;
            helper.Events.Input.ButtonsChanged += this.OnButtonsChanged;
        }

        private void OnGameLaunched(object? sender, GameLaunchedEventArgs e) {
            // get Generic Mod Config Menu's API (if it's installed)
            var configMenu = this.Helper.ModRegistry.GetApi<IGenericModConfigMenuApi>("spacechase0.GenericModConfigMenu");
            if (configMenu is null)
                return;

            // register mod
            configMenu.Register(
                mod: this.ModManifest,
                reset: () => this.Config = new ModConfig(),
                save: () => this.Helper.WriteConfig(this.Config)
            );

            // keybind title
            configMenu.AddSectionTitle(
                mod: this.ModManifest,
                text: () => "KeyBind Settings"
            );
            // activate key config
            configMenu.AddKeybindList(
                mod: this.ModManifest,
                name: () => "Toggle Monster List",
                tooltip: () => "Opens the Monster Eradication Goals menu. Default: F7",
                getValue: () => this.Config.ToggleMonsterList,
                setValue: value => this.Config.ToggleMonsterList = value
            );
        }

        private void OnButtonsChanged(object? sender, ButtonsChangedEventArgs e) {
            if (!this.Config.ToggleMonsterList.JustPressed() || !Context.IsPlayerFree)
                return;

            if (Game1.getLocationFromName("AdventureGuild") is AdventureGuild advGuild)
                advGuild.showMonsterKillList();
        }
    }
}
