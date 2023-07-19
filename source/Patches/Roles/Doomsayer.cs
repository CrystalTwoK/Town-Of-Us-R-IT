using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;
using System;
using TownOfUs.CrewmateRoles.VampireHunterMod;

namespace TownOfUs.Roles
{
    public class Doomsayer : Role
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons = new Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)>();

        private Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new Dictionary<byte, string>();
        public DateTime LastObserved;
        public PlayerControl ClosestPlayer;
        public PlayerControl LastObservedPlayer;

        public Doomsayer(PlayerControl player) : base(player)
        {
            Name = "Indovino";
            ImpostorText = () => "Indovina i ruoli dei giocatori per vincere!";
            TaskText = () => "Vinci indovinando i ruoli dei giocatori\nTask false:";
            Color = Patches.Colors.Doomsayer;
            RoleType = RoleEnum.Doomsayer;
            LastObserved = DateTime.UtcNow;
            AddToRoleHistory(RoleType);
            Faction = Faction.NeutralEvil;

            if (CustomGameOptions.GameMode == GameMode.Classic || CustomGameOptions.GameMode == GameMode.AllAny)
            {
                ColorMapping.Add("Crewmate", Colors.Crewmate);
                if (CustomGameOptions.MayorOn > 0) ColorMapping.Add("Sindaco", Colors.Mayor);
                if (CustomGameOptions.SheriffOn > 0 || (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && CustomGameOptions.BecomeOnVampDeaths == BecomeEnum.Sheriff)) ColorMapping.Add("Sceriffo", Colors.Sheriff);
                if (CustomGameOptions.EngineerOn > 0) ColorMapping.Add("Ingegnere", Colors.Engineer);
                if (CustomGameOptions.SwapperOn > 0) ColorMapping.Add("Scambiatore", Colors.Swapper);
                if (CustomGameOptions.InvestigatorOn > 0) ColorMapping.Add("Investigatore", Colors.Investigator);
                if (CustomGameOptions.MedicOn > 0) ColorMapping.Add("Medico", Colors.Medic);
                if (CustomGameOptions.SeerOn > 0) ColorMapping.Add("Veggente", Colors.Seer);
                if (CustomGameOptions.SpyOn > 0) ColorMapping.Add("Spia", Colors.Spy);
                if (CustomGameOptions.SnitchOn > 0) ColorMapping.Add("Snitch", Colors.Snitch);
                if (CustomGameOptions.AltruistOn > 0) ColorMapping.Add("Altruista", Colors.Altruist);
                if (CustomGameOptions.VigilanteOn > 0 || (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && CustomGameOptions.BecomeOnVampDeaths == BecomeEnum.Vigilante)) ColorMapping.Add("Vigilante", Colors.Vigilante);
                if (CustomGameOptions.VeteranOn > 0 || (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && CustomGameOptions.BecomeOnVampDeaths == BecomeEnum.Veteran)) ColorMapping.Add("Veterano", Colors.Veteran);
                if (CustomGameOptions.TrackerOn > 0) ColorMapping.Add("Inseguitore", Colors.Tracker);
                if (CustomGameOptions.TrapperOn > 0) ColorMapping.Add("Trapper", Colors.Trapper);
                if (CustomGameOptions.TransporterOn > 0) ColorMapping.Add("Trasportatore", Colors.Transporter);
                if (CustomGameOptions.MediumOn > 0) ColorMapping.Add("Medium", Colors.Medium);
                if (CustomGameOptions.MysticOn > 0) ColorMapping.Add("Mystic", Colors.Mystic);
                if (CustomGameOptions.DetectiveOn > 0) ColorMapping.Add("Detective", Colors.Detective);
                if (CustomGameOptions.ImitatorOn > 0) ColorMapping.Add("Imitatore", Colors.Imitator);
                if (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0) ColorMapping.Add("Van Helsing", Colors.VampireHunter);
                if (CustomGameOptions.ProsecutorOn > 0) ColorMapping.Add("Procuratore", Colors.Prosecutor);
                if (CustomGameOptions.OracleOn > 0) ColorMapping.Add("Oracolo", Colors.Oracle);
                if (CustomGameOptions.AurialOn > 0) ColorMapping.Add("Aurial", Colors.Aurial);

                if (CustomGameOptions.DoomsayerGuessImpostors && !PlayerControl.LocalPlayer.Is(Faction.Impostors))
                {
                    ColorMapping.Add("Impostor", Colors.Impostor);
                    if (CustomGameOptions.JanitorOn > 0) ColorMapping.Add("Bidello", Colors.Impostor);
                    if (CustomGameOptions.MorphlingOn > 0) ColorMapping.Add("Metamorfo", Colors.Impostor);
                    if (CustomGameOptions.MinerOn > 0) ColorMapping.Add("Minatore", Colors.Impostor);
                    if (CustomGameOptions.SwooperOn > 0) ColorMapping.Add("Invisibile", Colors.Impostor);
                    if (CustomGameOptions.UndertakerOn > 0) ColorMapping.Add("Becchino", Colors.Impostor);
                    if (CustomGameOptions.EscapistOn > 0) ColorMapping.Add("Fuggitivo", Colors.Impostor);
                    if (CustomGameOptions.GrenadierOn > 0) ColorMapping.Add("Granatiere", Colors.Impostor);
                    if (CustomGameOptions.TraitorOn > 0) ColorMapping.Add("Traditore", Colors.Impostor);
                    if (CustomGameOptions.BlackmailerOn > 0) ColorMapping.Add("Ricattatore", Colors.Impostor);
                    if (CustomGameOptions.BomberOn > 0) ColorMapping.Add("Bombarolo", Colors.Impostor);
                    if (CustomGameOptions.WarlockOn > 0) ColorMapping.Add("Stregone", Colors.Impostor);
                    if (CustomGameOptions.VenererOn > 0) ColorMapping.Add("Venerer", Colors.Impostor);
                }

                if (CustomGameOptions.DoomsayerGuessNeutralBenign)
                {
                    if (CustomGameOptions.AmnesiacOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("Amnesiac", Colors.Amnesiac);
                    if (CustomGameOptions.GuardianAngelOn > 0) ColorMapping.Add("Angelo Guardiano", Colors.GuardianAngel);
                    if (CustomGameOptions.SurvivorOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("Survivor", Colors.Survivor);
                }
                if (CustomGameOptions.DoomsayerGuessNeutralEvil)
                {
                    if (CustomGameOptions.GameMode == GameMode.AllAny) ColorMapping.Add("Indovino", Colors.Doomsayer);
                    if (CustomGameOptions.ExecutionerOn > 0) ColorMapping.Add("Boia", Colors.Executioner);
                    if (CustomGameOptions.JesterOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("Jester", Colors.Jester);
                }
                if (CustomGameOptions.DoomsayerGuessNeutralKilling)
                {
                    if (CustomGameOptions.ArsonistOn > 0) ColorMapping.Add("Piromane", Colors.Arsonist);
                    if (CustomGameOptions.GlitchOn > 0) ColorMapping.Add("The Glitch", Colors.Glitch);
                    if (CustomGameOptions.PlaguebearerOn > 0) ColorMapping.Add("Appestato", Colors.Plaguebearer);
                    if (CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0) ColorMapping.Add("Vampiro", Colors.Vampire);
                    if (CustomGameOptions.WerewolfOn > 0) ColorMapping.Add("Lupo Mannaro", Colors.Werewolf);
                    if (CustomGameOptions.HiddenRoles) ColorMapping.Add("Juggernaut", Colors.Juggernaut);
                }
            }

            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public float ObserveTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastObserved;
            var num = CustomGameOptions.ObserveCooldown * 1000f;
            var flag2 = num - (float)timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float)timeSpan.TotalMilliseconds) / 1000f;
        }

        public int GuessedCorrectly = 0;
        public bool WonByGuessing = false;

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__36 __instance)
        {
            var doomTeam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            doomTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = doomTeam;
        }

        internal override bool NeutralWin(LogicGameFlowNormal __instance)
        {
            if (Player.Data.IsDead) return true;
            if (!WonByGuessing) return true;
            Utils.EndGame();
            return false;
        }
    }
}
