using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Giant : Modifier, IVisualAlteration
    {
        public Giant(PlayerControl player) : base(player)
        {
            var slowText = CustomGameOptions.GiantSlow != 1? " e lento!" : "!";
            Name = "Gigante";
            TaskText = () => "Sei un'astronave, sei gigante!" + slowText;
            Color = Patches.Colors.Giant;
            ModifierType = ModifierEnum.Giant;
        }

        public bool TryGetModifiedAppearance(out VisualAppearance appearance)
        {
            appearance = Player.GetDefaultAppearance();
            appearance.SpeedFactor = CustomGameOptions.GiantSlow;
            appearance.SizeFactor = new Vector3(1.0f, 1.0f, 1.0f);
            return true;
        }
    }
}