using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Swapper : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();

        public readonly List<bool> ListOfActives = new List<bool>();


        public Swapper(PlayerControl player) : base(player)
        {
            Name = "Scambiatore";
            ImpostorText = () => "Scambia la posizioni di due giocatori al meeting per scambiarne i ruoli";
            TaskText = () => "Scambia la posizioni di due giocatori al meeting per scambiarne i ruoli";
            Color = Patches.Colors.Swapper;
            RoleType = RoleEnum.Swapper;
            AddToRoleHistory(RoleType);
        }
    }
}