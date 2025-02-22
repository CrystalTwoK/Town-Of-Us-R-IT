using System;

namespace TownOfUs.Roles.Modifiers
{
    public class Frosty : Modifier
    {
        public PlayerControl Chilled;
        public DateTime LastChilled { get; set; }
        public bool IsChilled = false;

        public Frosty(PlayerControl player) : base(player)
        {
            Name = "Gelato";
            TaskText = () => "Lasciati alle spalle sorprese gelate!";
            Color = Patches.Colors.Frosty;
            ModifierType = ModifierEnum.Frosty;
        }
    }
}