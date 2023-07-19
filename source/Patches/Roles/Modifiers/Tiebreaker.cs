using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Tiebreaker : Modifier
    {
        public Tiebreaker(PlayerControl player) : base(player)
        {
            Name = "Supplementari";
            TaskText = () => "Il tuo voto vale 0.1 in più!";
            Color = Patches.Colors.Tiebreaker;
            ModifierType = ModifierEnum.Tiebreaker;
        }
    }
}