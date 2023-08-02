using System;

namespace TownOfUs.Roles
{
    public class Detective : Role
    {
        private KillButton _examineButton;
        public PlayerControl ClosestPlayer;
        public DateTime LastExamined { get; set; }
        public DeadBody CurrentTarget;
        public bool ExamineMode = false;
        public PlayerControl DetectedKiller;

        public Detective(PlayerControl player) : base(player)
        {
            Name = "Detective";
            ImpostorText = () => "Esamina i cadaveri per indizi";
            TaskText = () => "Esamina i giocatori sospetti per trovare i malfattori";
            Color = Patches.Colors.Detective;
            LastExamined = DateTime.UtcNow;
            RoleType = RoleEnum.Detective;
            AddToRoleHistory(RoleType);
        }

        public KillButton ExamineButton
        {
            get => _examineButton;
            set
            {
                _examineButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }

        public float ExamineTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastExamined;
            var num = CustomGameOptions.ExamineCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}