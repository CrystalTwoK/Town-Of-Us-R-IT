using System.Collections.Generic;

namespace TownOfUs.Roles.Modifiers
{
    public class Radar : Modifier
    {
        public List<ArrowBehaviour> RadarArrow = new List<ArrowBehaviour>();
        public PlayerControl ClosestPlayer;
        public Radar(PlayerControl player) : base(player)
        {
            Name = "Radar";
            TaskText = () => "Rimani con la guardia alta!";
            Color = Patches.Colors.Radar;
            ModifierType = ModifierEnum.Radar;
        }
    }
}