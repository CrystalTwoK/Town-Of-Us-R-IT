namespace TownOfUs.Roles
{
    public class Prosecutor : Role
    {
        public Prosecutor(PlayerControl player) : base(player)
        {
            Name = "Procuratore";
            ImpostorText = () => "Esilia una persona a tua scelta";
            TaskText = () => "Scegli chi esiliare a tua scelta";
            Color = Patches.Colors.Prosecutor;
            RoleType = RoleEnum.Prosecutor;
            AddToRoleHistory(RoleType);
            StartProsecute = false;
            Prosecuted = false;
            ProsecuteThisMeeting = false;
        }
        public bool ProsecuteThisMeeting { get; set; }
        public bool Prosecuted { get; set; }
        public bool StartProsecute { get; set; }
        public PlayerVoteArea Prosecute { get; set; }
    }
}
