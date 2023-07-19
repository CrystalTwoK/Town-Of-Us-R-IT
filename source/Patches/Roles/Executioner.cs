using Il2CppSystem.Collections.Generic;

namespace TownOfUs.Roles
{
    public class Executioner : Role
    {
        public PlayerControl target;
        public bool TargetVotedOut;

        public Executioner(PlayerControl player) : base(player)
        {
            Name = "Boia";
            ImpostorText = () =>
                target == null ? "Non hai un'obbiettivo per qualche motivo, strano..." : $"Vota {target.name} fuori";
            TaskText = () =>
                target == null
                    ? "Non hai un'obbiettivo per qualche motivo, strano..."
                    : $"Votalo {target.name} fuori!\nTask false:";
            Color = Patches.Colors.Executioner;
            RoleType = RoleEnum.Executioner;
            AddToRoleHistory(RoleType);
            Faction = Faction.NeutralEvil;
            Scale = 1.4f;
        }

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__36 __instance)
        {
            var exeTeam = new List<PlayerControl>();
            exeTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = exeTeam;
        }

        internal override bool NeutralWin(LogicGameFlowNormal __instance)
        {
            if (Player.Data.IsDead) return true;
            if (!TargetVotedOut || !target.Data.IsDead) return true;
            Utils.EndGame();
            return false;
        }

        public void Wins()
        {
            if (Player.Data.IsDead || Player.Data.Disconnected) return;
            TargetVotedOut = true;
        }
    }
}