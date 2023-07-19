namespace TownOfUs.Roles
{
    public class Altruist : Role
    {
        public bool CurrentlyReviving;
        public DeadBody CurrentTarget;

        public bool ReviveUsed;
        
        public Altruist(PlayerControl player) : base(player)
        {
            Name = "Altruista";
            ImpostorText = () => "Sacrificati per salvare un'altra persona!";
            TaskText = () => "Rianima un corpo deceduto al costo della tua vita!";
            Color = Patches.Colors.Altruist;
            RoleType = RoleEnum.Altruist;
            AddToRoleHistory(RoleType);
        }
    }
}