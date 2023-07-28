namespace TownOfUs.Roles.Cultist
{
    public class CultistSnitch : Role
    {
        public bool CompletedTasks;
        public PlayerControl RevealedPlayer;
        public CultistSnitch(PlayerControl player) : base(player)
        {
            Name = "Snitch";
            ImpostorText = () => "Completa tutti gli incarichi per rilevare gli impostori";
            TaskText = () => "Completa tutti gli incarichi per rilevare gli impostori";
            Color = Patches.Colors.Snitch;
            RoleType = RoleEnum.CultistSnitch;
            AddToRoleHistory(RoleType);
        }
    }
}