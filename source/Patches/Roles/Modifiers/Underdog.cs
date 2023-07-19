using TownOfUs.Modifiers.UnderdogMod;

namespace TownOfUs.Roles.Modifiers
{
    public class Underdog : Modifier
    {
        public Underdog(PlayerControl player) : base(player)
        {
            Name = "Perdente";
            TaskText = () => "Quando sei da solo il cooldown delle uccisioni si riduce";
            Color = Patches.Colors.Impostor;
            ModifierType = ModifierEnum.Underdog;
        }

        public float MaxTimer() => PerformKill.LastImp() ? GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown - CustomGameOptions.UnderdogKillBonus : (PerformKill.IncreasedKC() ? GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown : GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown + CustomGameOptions.UnderdogKillBonus);

        public void SetKillTimer()
        {
            Player.SetKillTimer(MaxTimer());
        }
    }
}
