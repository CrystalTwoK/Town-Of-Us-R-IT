using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Bait : Modifier
    {
        public Bait(PlayerControl player) : base(player)
        {
            Name = "Esca";
            TaskText = () => "Ucciderti causerà un auto report istantaneo";
            Color = Patches.Colors.Bait;
            ModifierType = ModifierEnum.Bait;
        }
    }
}