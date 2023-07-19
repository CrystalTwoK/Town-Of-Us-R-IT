using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Imitator : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();

        public readonly List<bool> ListOfActives = new List<bool>();
        public PlayerControl ImitatePlayer = null;

        public List<RoleEnum> trappedPlayers = null;
        public PlayerControl confessingPlayer = null;


        public Imitator(PlayerControl player) : base(player)
        {
            Name = "Imitatore";
            ImpostorText = () => "Imita il ruolo di un Crewmate deceduto";
            TaskText = () => "Utilizza ruoli di Crewmate deceduti per vincere!";
            Color = Patches.Colors.Imitator;
            RoleType = RoleEnum.Imitator;
            AddToRoleHistory(RoleType);
        }
    }
}