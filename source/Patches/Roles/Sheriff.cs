using System;

namespace TownOfUs.Roles
{
    public class Sheriff : Role
    {
        public Sheriff(PlayerControl player) : base(player)
        {
            Name = "Sceriffo";
            ImpostorText = () => "Spara agli <color=#FF0000FF>Impostori</color>";
            TaskText = () => "Uccidi gli impostori, ma non i crewmate";
            Color = Patches.Colors.Sheriff;
            LastKilled = DateTime.UtcNow;
            RoleType = RoleEnum.Sheriff;
            AddToRoleHistory(RoleType);
        }

        public PlayerControl ClosestPlayer;
        public DateTime LastKilled { get; set; }

        public float SheriffKillTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastKilled;
            var num = CustomGameOptions.SheriffKillCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}