using System.Collections.Generic;
using TownOfUs.CrewmateRoles.InvestigatorMod;

namespace TownOfUs.Roles
{
    public class Investigator : Role
    {
        public readonly List<Footprint> AllPrints = new List<Footprint>();


        public Investigator(PlayerControl player) : base(player)
        {
            Name = "Investigatore";
            ImpostorText = () => "Trova gli impostori esaminandone le impronte";
            TaskText = () => "Puoi vedere le impronte di tutti.";
            Color = Patches.Colors.Investigator;
            RoleType = RoleEnum.Investigator;
            AddToRoleHistory(RoleType);
            Scale = 1.4f;
        }
    }
}