namespace TownOfUs.Roles.Cultist
{
    public class CultistMystic : Role
    {
        public CultistMystic(PlayerControl player) : base(player)
        {
            Name = "Mystic";
            ImpostorText = () => "Capisci quando qualcuno viene convertito!";
            TaskText = () => "Sai quando qualcuno viene convertito";
            Color = Patches.Colors.Mystic;
            RoleType = RoleEnum.CultistMystic;
            AddToRoleHistory(RoleType);
        }
    }
}