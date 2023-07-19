using UnityEngine;

namespace TownOfUs.Roles
{
    public class Mayor : Role
    {
        public Mayor(PlayerControl player) : base(player)
        {
            Name = "Sindaco";
            ImpostorText = () => "Rivelati per salvare la Nave!";
            TaskText = () => "Rivelati quando il momento è esatto!";
            Color = Patches.Colors.Mayor;
            RoleType = RoleEnum.Mayor;
            AddToRoleHistory(RoleType);
            Revealed = false;
        }
        public bool Revealed { get; set; }

        public GameObject RevealButton = new GameObject();

        internal override bool Criteria()
        {
            return Revealed && !Player.Data.IsDead || base.Criteria();
        }

        internal override bool RoleCriteria()
        {
            if (!Player.Data.IsDead) return Revealed || base.RoleCriteria();
            return false || base.RoleCriteria();
        }
    }
}