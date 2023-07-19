using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Diseased : Modifier
    {
        public Diseased(PlayerControl player) : base(player)
        {
            Name = "Malato";
            TaskText = () => "Ucciderti darà all'impostore cooldown elevati";
            Color = Patches.Colors.Diseased;
            ModifierType = ModifierEnum.Diseased;
        }
    }
}