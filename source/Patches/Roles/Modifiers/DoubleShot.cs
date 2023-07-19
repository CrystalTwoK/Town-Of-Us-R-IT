namespace TownOfUs.Roles.Modifiers
{
    public class DoubleShot : Modifier
    {
        public bool LifeUsed;
        public DoubleShot(PlayerControl player) : base(player)
        {
            Name = "Doppio Colpo";
            TaskText = () => "Hai un'altra vita quando vieni assassinato";
            Color = Patches.Colors.Impostor;
            ModifierType = ModifierEnum.DoubleShot;
            LifeUsed = false;
        }
    }
}