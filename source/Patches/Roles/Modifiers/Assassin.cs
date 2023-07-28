using System.Collections.Generic;
using System.Linq;
using TMPro;
using TownOfUs.Patches;
using UnityEngine;
using TownOfUs.NeutralRoles.ExecutionerMod;
using TownOfUs.NeutralRoles.GuardianAngelMod;
using TownOfUs.CrewmateRoles.VampireHunterMod;

namespace TownOfUs.Roles.Modifiers
{
    public class Assassin : Ability
    {
        public Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)> Buttons = new Dictionary<byte, (GameObject, GameObject, GameObject, TMP_Text)>();


        private Dictionary<string, Color> ColorMapping = new Dictionary<string, Color>();

        public Dictionary<string, Color> SortedColorMapping;

        public Dictionary<byte, string> Guesses = new Dictionary<byte, string>();


        public Assassin(PlayerControl player) : base(player)
        {
            Name = "Assassino";
            TaskText = () => "Indovina i ruoli degli altri giocatori e uccidili durante il meeting";
            Color = Patches.Colors.Impostor;
            AbilityType = AbilityEnum.Assassin;

            RemainingKills = CustomGameOptions.AssassinKills;

            // Adds all the roles that have a non-zero chance of being in the game.
            if (CustomGameOptions.MayorOn > 0) ColorMapping.Add("Sindaco", Colors.Mayor);
            if (CustomGameOptions.SheriffOn > 0 || (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && CustomGameOptions.BecomeOnVampDeaths == BecomeEnum.Sheriff)) ColorMapping.Add("Sheriff", Colors.Sheriff);
            if (CustomGameOptions.EngineerOn > 0) ColorMapping.Add("Ingegnere", Colors.Engineer);
            if (CustomGameOptions.SwapperOn > 0) ColorMapping.Add("Scambiatore", Colors.Swapper);
            if (CustomGameOptions.InvestigatorOn > 0) ColorMapping.Add("Investigatore", Colors.Investigator);
            if (CustomGameOptions.MedicOn > 0) ColorMapping.Add("Medico", Colors.Medic);
            if (CustomGameOptions.SeerOn > 0) ColorMapping.Add("Veggente", Colors.Seer);
            if (CustomGameOptions.SpyOn > 0) ColorMapping.Add("Spia", Colors.Spy);
            if (CustomGameOptions.SnitchOn > 0) ColorMapping.Add("Snitch", Colors.Snitch);
            if (CustomGameOptions.AltruistOn > 0) ColorMapping.Add("Altruista", Colors.Altruist);
            if (CustomGameOptions.VigilanteOn > 0 || (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && CustomGameOptions.BecomeOnVampDeaths == BecomeEnum.Vigilante)) ColorMapping.Add("Vigilante", Colors.Vigilante);
            if (CustomGameOptions.VeteranOn > 0 || (CustomGameOptions.VampireHunterOn > 0 && CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && CustomGameOptions.BecomeOnVampDeaths == BecomeEnum.Veteran)) ColorMapping.Add("Veteran", Colors.Veteran);
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

            // Add Neutral roles if enabled
            if (CustomGameOptions.AssassinGuessNeutralBenign)
            {
                if (CustomGameOptions.AmnesiacOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Amnesiac) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Amnesiac)) ColorMapping.Add("Amnesiac", Colors.Amnesiac);
                if (CustomGameOptions.GuardianAngelOn > 0) ColorMapping.Add("Angelo Guardiano", Colors.GuardianAngel);
                if (CustomGameOptions.SurvivorOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Survivor) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Survivor)) ColorMapping.Add("Survivor", Colors.Survivor);
            }
            if (CustomGameOptions.AssassinGuessNeutralEvil)
            {
                if (CustomGameOptions.DoomsayerOn > 0) ColorMapping.Add("Indovino", Colors.Doomsayer);
                if (CustomGameOptions.ExecutionerOn > 0) ColorMapping.Add("Boia", Colors.Executioner);
                if (CustomGameOptions.JesterOn > 0 || (CustomGameOptions.ExecutionerOn > 0 && CustomGameOptions.OnTargetDead == OnTargetDead.Jester) || (CustomGameOptions.GuardianAngelOn > 0 && CustomGameOptions.GaOnTargetDeath == BecomeOptions.Jester)) ColorMapping.Add("Jester", Colors.Jester);
            }
            if (CustomGameOptions.AssassinGuessNeutralKilling)
            {
                if (CustomGameOptions.ArsonistOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.Arsonist)) ColorMapping.Add("Piromane", Colors.Arsonist);
                if (CustomGameOptions.GlitchOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.Glitch)) ColorMapping.Add("Il Glitch", Colors.Glitch);
                if (CustomGameOptions.PlaguebearerOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.Plaguebearer)) ColorMapping.Add("Appestato", Colors.Plaguebearer);
                if (CustomGameOptions.GameMode == GameMode.Classic && CustomGameOptions.VampireOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.Vampire)) ColorMapping.Add("Vampiro", Colors.Vampire);
                if (CustomGameOptions.WerewolfOn > 0 && !PlayerControl.LocalPlayer.Is(RoleEnum.Werewolf)) ColorMapping.Add("Lupo Mannaro", Colors.Werewolf);
                if (!PlayerControl.LocalPlayer.Is(RoleEnum.Juggernaut) && CustomGameOptions.HiddenRoles) ColorMapping.Add("Juggernaut", Colors.Juggernaut);
            }
            if (CustomGameOptions.AssassinGuessImpostors && !PlayerControl.LocalPlayer.Is(Faction.Impostors))
            {
                ColorMapping.Add("Impostore", Colors.Impostor);
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
                if (CustomGameOptions.VenererOn > 0) ColorMapping.Add("Cultista", Colors.Impostor);
            }

            // Add vanilla crewmate if enabled
            if (CustomGameOptions.AssassinCrewmateGuess) ColorMapping.Add("Crewmate", Colors.Crewmate);
            //Add modifiers if enabled
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.BaitOn > 0) ColorMapping.Add("Esca", Colors.Bait);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.AftermathOn > 0) ColorMapping.Add("Conseguenza", Colors.Aftermath);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.DiseasedOn > 0) ColorMapping.Add("Malato", Colors.Diseased);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.FrostyOn > 0) ColorMapping.Add("Gelato", Colors.Frosty);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.MultitaskerOn > 0) ColorMapping.Add("Multitasker", Colors.Multitasker);
            if (CustomGameOptions.AssassinGuessModifiers && CustomGameOptions.TorchOn > 0) ColorMapping.Add("Torcia", Colors.Torch);
            if (CustomGameOptions.AssassinGuessLovers && CustomGameOptions.LoversOn > 0) ColorMapping.Add("Amanti", Colors.Lovers);

            // Sorts the list alphabetically. 
            SortedColorMapping = ColorMapping.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool GuessedThisMeeting { get; set; } = false;

        public int RemainingKills { get; set; }

        public List<string> PossibleGuesses => SortedColorMapping.Keys.ToList();
    }
}
