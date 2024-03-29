using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace AcidicNic.MenuCycle.Framework
{
    public class ModConfig
    {
        public KeybindList ActivateKey { get; set; } = new KeybindList(SButton.P);
        public KeybindList CycleLeftKey { get; set; } = new KeybindList(SButton.OemOpenBrackets);
        public KeybindList CycleRightKey { get; set; } = new KeybindList(SButton.OemCloseBrackets);

        public bool EnableCalendar { get; set; } = true;
        public bool EnableDailyQuests { get; set; } = true;
        public bool EnableSpecialOrders { get; set; } = true;
        public bool EnableQiSpecialOrders { get; set; } = true;
        public bool EnableJournal { get; set; } = false;

        public bool SpecialOrdersBeforeUnlocked { get; set; } = false;
        public bool QiBeforeUnlocked { get; set; } = false;
    }
}
