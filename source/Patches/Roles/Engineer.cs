using TMPro;

namespace TownOfUs.Roles
{
    public class Engineer : Role
    {
        public Engineer(PlayerControl player) : base(player)
        {
            Name = "Ingegnere";
            ImpostorText = () => "Mantieni riparati i sistemi vitali della nave!";
            TaskText = () => CustomGameOptions.GameMode == GameMode.Cultist ? "Botola" : "Botola in giro e aggiusta le manomissioni!";
            Color = Patches.Colors.Engineer;
            RoleType = RoleEnum.Engineer;
            AddToRoleHistory(RoleType);
            UsesLeft = CustomGameOptions.MaxFixes;
        }

        public int UsesLeft;
        public TextMeshPro UsesText;

        public bool ButtonUsable => UsesLeft != 0;
    }
}