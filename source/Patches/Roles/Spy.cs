namespace TownOfUs.Roles
{
    public class Spy : Role
    {
        public Spy(PlayerControl player) : base(player)
        {
            Name = "Spia";
            ImpostorText = () => "Curiosa in giro e trovare roba";
            TaskText = () => "Ottieni informazioni utili al tavolo Admin";
            Color = Patches.Colors.Spy;
            RoleType = RoleEnum.Spy;
            AddToRoleHistory(RoleType);
        }
    }
}