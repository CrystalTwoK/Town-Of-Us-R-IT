using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Multitasker : Modifier
    {
        public Multitasker(PlayerControl player) : base(player)
        {
            Name = "Multitasker";
            TaskText = () => "Le finestre delle task sono trasparenti";
            Color = Patches.Colors.Multitasker;
            ModifierType = ModifierEnum.Multitasker;
        }
    }
}