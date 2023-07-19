using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Torch : Modifier
    {
        public Torch(PlayerControl player) : base(player)
        {
            Name = "Torcia";
            TaskText = () => "Puoi vedere al buio";
            Color = Patches.Colors.Torch;
            ModifierType = ModifierEnum.Torch;
        }
    }
}