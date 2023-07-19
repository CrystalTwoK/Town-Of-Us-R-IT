using System;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption AurialOn;
        public static CustomNumberOption DetectiveOn;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption OracleOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VampireHunterOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption ImitatorOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption ProsecutorOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption DoomsayerOn;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption VampireOn;
        public static CustomNumberOption WerewolfOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption EscapistOn;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;
        public static CustomNumberOption VenererOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption BomberOn;
        public static CustomNumberOption TraitorOn;
        public static CustomNumberOption WarlockOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption AftermathOn;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption FrostyOn;
        public static CustomNumberOption MultitaskerOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption RadarOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

        public static CustomHeaderOption ImpostorModifiers;
        public static CustomNumberOption DisperserOn;
        public static CustomNumberOption DoubleShotOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomToggleOption AutoAdjustSettings;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;
        public static CustomToggleOption HiddenRoles;
        public static CustomToggleOption FirstDeathShield;

        public static CustomHeaderOption BetterPolusSettings;
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;

        public static CustomHeaderOption GameModeSettings;
        public static CustomStringOption GameMode;

        public static CustomHeaderOption ClassicSettings;
        public static CustomNumberOption MinNeutralBenignRoles;
        public static CustomNumberOption MaxNeutralBenignRoles;
        public static CustomNumberOption MinNeutralEvilRoles;
        public static CustomNumberOption MaxNeutralEvilRoles;
        public static CustomNumberOption MinNeutralKillingRoles;
        public static CustomNumberOption MaxNeutralKillingRoles;

        public static CustomHeaderOption AllAnySettings;
        public static CustomToggleOption RandomNumberImps;

        public static CustomHeaderOption KillingOnlySettings;
        public static CustomNumberOption NeutralRoles;
        public static CustomNumberOption VeteranCount;
        public static CustomNumberOption VigilanteCount;
        public static CustomToggleOption AddArsonist;
        public static CustomToggleOption AddPlaguebearer;

        public static CustomHeaderOption CultistSettings;
        public static CustomNumberOption MayorCultistOn;
        public static CustomNumberOption SeerCultistOn;
        public static CustomNumberOption SheriffCultistOn;
        public static CustomNumberOption SurvivorCultistOn;
        public static CustomNumberOption NumberOfSpecialRoles;
        public static CustomNumberOption MaxChameleons;
        public static CustomNumberOption MaxEngineers;
        public static CustomNumberOption MaxInvestigators;
        public static CustomNumberOption MaxMystics;
        public static CustomNumberOption MaxSnitches;
        public static CustomNumberOption MaxSpies;
        public static CustomNumberOption MaxTransporters;
        public static CustomNumberOption MaxVigilantes;
        public static CustomNumberOption WhisperCooldown;
        public static CustomNumberOption IncreasedCooldownPerWhisper;
        public static CustomNumberOption WhisperRadius;
        public static CustomNumberOption ConversionPercentage;
        public static CustomNumberOption DecreasedPercentagePerConversion;
        public static CustomNumberOption ReviveCooldown;
        public static CustomNumberOption IncreasedCooldownPerRevive;
        public static CustomNumberOption MaxReveals;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsDoomsayer;
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomToggleOption SheriffKillsJuggernaut;
        public static CustomToggleOption SheriffKillsPlaguebearer;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsVampire;
        public static CustomToggleOption SheriffKillsWerewolf;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;

        public static CustomHeaderOption Engineer;
        public static CustomNumberOption MaxFixes;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Spy;
        public static CustomStringOption WhoSeesDead;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;
        public static CustomToggleOption JesterImpVision;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Juggernaut;
        public static CustomNumberOption JuggKillCooldown;
        public static CustomNumberOption ReducedKCdPerKill;
        public static CustomToggleOption JuggVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;
        public static CustomToggleOption SnitchSeesTraitor;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;
        public static CustomToggleOption ArsoImpVision;
        public static CustomToggleOption IgniteCdRemoved;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomNumberOption UndertakerDragSpeed;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessImpostors;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;
        public static CustomToggleOption AssassinateAfterVoting;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessLovers;
        public static CustomToggleOption VigilanteAfterVoting;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;
        public static CustomNumberOption EvilTargetPercent;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Detective;
        public static CustomNumberOption ExamineCooldown;
        public static CustomToggleOption DetectiveReportOn;
        public static CustomNumberOption DetectiveRoleDuration;
        public static CustomNumberOption DetectiveFactionDuration;

        public static CustomHeaderOption Escapist;
        public static CustomNumberOption EscapeCooldown;
        public static CustomToggleOption EscapistVent;

        public static CustomHeaderOption Bomber;
        public static CustomNumberOption MaxKillsInDetonation;
        public static CustomNumberOption DetonateDelay;
        public static CustomNumberOption DetonateRadius;
        public static CustomToggleOption BomberVent;

        public static CustomHeaderOption Doomsayer;
        public static CustomNumberOption ObserveCooldown;
        public static CustomToggleOption DoomsayerGuessNeutralBenign;
        public static CustomToggleOption DoomsayerGuessNeutralEvil;
        public static CustomToggleOption DoomsayerGuessNeutralKilling;
        public static CustomToggleOption DoomsayerGuessImpostors;
        public static CustomToggleOption DoomsayerAfterVoting;
        public static CustomNumberOption DoomsayerGuessesToWin;

        public static CustomHeaderOption Vampire;
        public static CustomNumberOption BiteCooldown;
        public static CustomToggleOption VampImpVision;
        public static CustomToggleOption VampVent;
        public static CustomToggleOption NewVampCanAssassin;
        public static CustomNumberOption MaxVampiresPerGame;
        public static CustomToggleOption CanBiteNeutralBenign;
        public static CustomToggleOption CanBiteNeutralEvil;

        public static CustomHeaderOption VampireHunter;
        public static CustomNumberOption StakeCooldown;
        public static CustomNumberOption MaxFailedStakesPerGame;
        public static CustomToggleOption CanStakeRoundOne;
        public static CustomToggleOption SelfKillAfterFinalStake;
        public static CustomStringOption BecomeOnVampDeaths;

        public static CustomHeaderOption Prosecutor;
        public static CustomToggleOption ProsDiesOnIncorrectPros;

        public static CustomHeaderOption Warlock;
        public static CustomNumberOption ChargeUpDuration;
        public static CustomNumberOption ChargeUseDuration;

        public static CustomHeaderOption Oracle;
        public static CustomNumberOption ConfessCooldown;
        public static CustomNumberOption RevealAccuracy;
        public static CustomToggleOption NeutralBenignShowsEvil;
        public static CustomToggleOption NeutralEvilShowsEvil;
        public static CustomToggleOption NeutralKillingShowsEvil;

        public static CustomHeaderOption Venerer;
        public static CustomNumberOption AbilityCooldown;
        public static CustomNumberOption AbilityDuration;
        public static CustomNumberOption SprintSpeed;
        public static CustomNumberOption FreezeSpeed;

        public static CustomHeaderOption Aurial;
        public static CustomNumberOption RadiateRange;
        public static CustomNumberOption RadiateCooldown;
        public static CustomNumberOption RadiateSucceedChance;
        public static CustomNumberOption RadiateCount;
        public static CustomNumberOption RadiateInvis;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;

        public static CustomHeaderOption Frosty;
        public static CustomNumberOption ChillDuration;
        public static CustomNumberOption ChillStartSpeed;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);

            CrewInvestigativeRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Ruoli investigativi Crewmate");
            AurialOn = new CustomNumberOption(num++, MultiMenu.crewmate, $"<color=#B34D99FF>Aurial</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DetectiveOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>Detective</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            HaunterOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#D3D3D3FF>Infestatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            InvestigatorOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>Investigatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MysticOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            OracleOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#BF00BFFF>Oracolo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SeerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Veggente</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Snitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SpyOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#CCA3CCFF>Spia</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrackerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#009900FF>Inseguitore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrapperOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewKillingRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Ruoli uccisori Crewmate");
            SheriffOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sceriffo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VampireHunterOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#B3B3E6FF>Van Helsing</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VeteranOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veterano</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VigilanteOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Vigilante</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewProtectiveRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Ruoli protettori Crewmate");
            AltruistOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#660000FF>Altruista</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#006600FF>Medico</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewSupportRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "Ruoli Supporto Crewmate");
            EngineerOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Ingegnere</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ImitatorOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#B3D94DFF>Imitatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MayorOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>Sindaco</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MediumOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ProsecutorOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#B38000FF>Procuratore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#66E666FF>Scambiatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Trasportatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            NeutralBenignRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "Ruoli Benigni Neutrali");
            AmnesiacOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiaco</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GuardianAngelOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Angelo Guardiano</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>Sopravvissuto</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralEvilRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "Ruoli Cattivi Neutrali");
            DoomsayerOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#00FF80FF>Indovino</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ExecutionerOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Boia</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JesterOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Giullare</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PhantomOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#662962FF>Spettro</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralKillingRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "Ruoli Uccisori Neutri");
            ArsonistOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Piromane</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PlaguebearerOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Appestato</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#00FF00FF>The Glitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VampireOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#262626FF>Vampiro</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WerewolfOn = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#A86629FF>Lupo Mannaro</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "Ruoli Tattici Impostori");
            EscapistOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Fuggitivo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GrenadierOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Granatiere</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MorphlingOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Metamorfo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Invisibile</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VenererOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Venerer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorKillingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "Ruoli Uccisori Impostori");
            BomberOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bombarolo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traditore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WarlockOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Stregone</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorSupportRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "Ruoli Supporto Impostori");
            BlackmailerOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Ricattatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bidello</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MinerOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Minatore</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UndertakerOn = new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Becchino</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewmateModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Crewmate Modificatori");
            AftermathOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#A6FFA6FF>Aftermath</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            BaitOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#00B3B3FF>Esca</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#808080FF>Malato</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FrostyOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#99FFFFFF>Gelato</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MultitaskerOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF804DFF>Multitasker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FFFF99FF>Torcia</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Modificatori Globali");
            ButtonBarryOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#E600FFFF>Bottone Portatile</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>Gigante</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>Amanti</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            RadarOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0080FF>Radar</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#803333FF>Segugio</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#99E699FF>Supplementari</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Modificatori Impostori");
            DisperserOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Dispersivo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DoubleShotOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Doppio Colpo</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GameModeSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Impostazioni di Gioco");
            GameMode = new CustomStringOption(num++, MultiMenu.main, "Modalità", new[] {"Classico", "Tutti tutto", "Solo Killer", "Cultist" });

            ClassicSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Impostazioni della modalità di gioco Classica");
            MinNeutralBenignRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Min Ruoli Neutri Benigni", 1, 0, 3, 1);
            MaxNeutralBenignRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Max Ruoli Neutri Benigni", 1, 0, 3, 1);
            MinNeutralEvilRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Min Ruoli Neutri Cattivi", 1, 0, 3, 1);
            MaxNeutralEvilRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Max Ruoli Neutri Cattivi", 1, 0, 3, 1);
            MinNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Min Ruoli Neutri Killer", 1, 0, 5, 1);
            MaxNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Max Ruoli Neutri Killer", 1, 0, 5, 1);

            AllAnySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Impostazioni tutti tutto");
            RandomNumberImps = new CustomToggleOption(num++, MultiMenu.main, "Numero Casuale di Impostori", true);

            KillingOnlySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Impostazioni uccidere solamente");
            NeutralRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Ruoli Neutri", 1, 0, 5, 1);
            VeteranCount =
                new CustomNumberOption(num++, MultiMenu.main, "Quantità Veterani", 1, 0, 5, 1);
            VigilanteCount =
                new CustomNumberOption(num++, MultiMenu.main, "Quantità Vigilanti", 1, 0, 5, 1);
            AddArsonist = new CustomToggleOption(num++, MultiMenu.main, "Aggiunti Piromane", true);
            AddPlaguebearer = new CustomToggleOption(num++, MultiMenu.main, "Aggiunti Appestato", true);

            CultistSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Cultist Settings");
            MayorCultistOn = new CustomNumberOption(num++, MultiMenu.main, "<color=#704FA8FF>Mayor</color> (Cultist Mode)", 100f, 0f, 100f, 10f,
                PercentFormat);
            SeerCultistOn = new CustomNumberOption(num++, MultiMenu.main, "<color=#FFCC80FF>Seer</color> (Cultist Mode)", 100f, 0f, 100f, 10f,
                PercentFormat);
            SheriffCultistOn = new CustomNumberOption(num++, MultiMenu.main, "<color=#FFFF00FF>Sheriff</color> (Cultist Mode)", 100f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorCultistOn = new CustomNumberOption(num++, MultiMenu.main, "<color=#FFE64DFF>Survivor</color> (Cultist Mode)", 100f, 0f, 100f, 10f,
                PercentFormat);
            NumberOfSpecialRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Number Of Special Roles", 4, 0, 4, 1);
            MaxChameleons =
                new CustomNumberOption(num++, MultiMenu.main, "Max Chameleons", 3, 0, 5, 1);
            MaxEngineers =
                new CustomNumberOption(num++, MultiMenu.main, "Max Engineers", 3, 0, 5, 1);
            MaxInvestigators =
                new CustomNumberOption(num++, MultiMenu.main, "Max Investigators", 3, 0, 5, 1);
            MaxMystics =
                new CustomNumberOption(num++, MultiMenu.main, "Max Mystics", 3, 0, 5, 1);
            MaxSnitches =
                new CustomNumberOption(num++, MultiMenu.main, "Max Snitches", 3, 0, 5, 1);
            MaxSpies =
                new CustomNumberOption(num++, MultiMenu.main, "Max Spies", 3, 0, 5, 1);
            MaxTransporters =
                new CustomNumberOption(num++, MultiMenu.main, "Max Transporters", 3, 0, 5, 1);
            MaxVigilantes =
                new CustomNumberOption(num++, MultiMenu.main, "Max Vigilantes", 3, 0, 5, 1);
            WhisperCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Initial Whisper Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            IncreasedCooldownPerWhisper =
                new CustomNumberOption(num++, MultiMenu.main, "Increased Cooldown Per Whisper", 5f, 0f, 15f, 0.5f, CooldownFormat);
            WhisperRadius =
                new CustomNumberOption(num++, MultiMenu.main, "Whisper Radius", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            ConversionPercentage = new CustomNumberOption(num++, MultiMenu.main, "Conversion Percentage", 25f, 0f, 100f, 5f,
                PercentFormat);
            DecreasedPercentagePerConversion = new CustomNumberOption(num++, MultiMenu.main, "Decreased Conversion Percentage Per Conversion", 5f, 0f, 15f, 1f,
                PercentFormat);
            ReviveCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Initial Revive Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            IncreasedCooldownPerRevive =
                new CustomNumberOption(num++, MultiMenu.main, "Increased Cooldown Per Revive", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxReveals = new CustomNumberOption(num++, MultiMenu.main, "Maximum Number Of Reveals", 5, 1, 15, 1);

            MapSettings = new CustomHeaderOption(num++, MultiMenu.main, "Impostazioni Mappa");
            RandomMapEnabled = new CustomToggleOption(num++, MultiMenu.main, "Scegli una Mappa a caso", false);
            RandomMapSkeld = new CustomNumberOption(num++, MultiMenu.main, "Skeld Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption(num++, MultiMenu.main, "Mira Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption(num++, MultiMenu.main, "Polus Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption(num++, MultiMenu.main, "Airship Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption(num++, MultiMenu.main, "Submerged Chance", 0f, 0f, 100f, 10f, PercentFormat);
            AutoAdjustSettings = new CustomToggleOption(num++, MultiMenu.main, "Auto Adjust Settings", false);
            SmallMapHalfVision = new CustomToggleOption(num++, MultiMenu.main, "Metà visione su Skeld/Mira HQ", false);
            SmallMapDecreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Mira HQ Cooldown diminuito", 0f, 0f, 15f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Cooldown aumentato", 0f, 0f, 15f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Task brevi aumentate", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Task lunghe aumentate", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Diminuite Task brevi", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Diminuite Task lunghe", 0, 0, 3, 1);

            BetterPolusSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Better Polus Settings");
            VentImprovements = new CustomToggleOption(num++, MultiMenu.main, "Better Polus Vent Layout", false);
            VitalsLab = new CustomToggleOption(num++, MultiMenu.main, "Vitals mossi a Lab", false);
            ColdTempDeathValley = new CustomToggleOption(num++, MultiMenu.main, "Cold Temp mosso a Death Valley", false);
            WifiChartCourseSwap =
                new CustomToggleOption(num++, MultiMenu.main, "Riavvia Wifi e Chart Course Scambiati", false);

            CustomGameSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Custom Game Settings");
            ColourblindComms = new CustomToggleOption(num++, MultiMenu.main, "Comunicazioni Cammuffate", false);
            ImpostorSeeRoles = new CustomToggleOption(num++, MultiMenu.main, "Gli impostori possono vedere i ruoli del proprio team", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, MultiMenu.main, "I morti possono vedere i ruoli/voti", false);
            InitialCooldowns =
                new CustomNumberOption(num++, MultiMenu.main, "Cooldown inizio Game", 10f, 10f, 30f, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, MultiMenu.main, "Medbay scan Parallelo", false);
            SkipButtonDisable = new CustomStringOption(num++, MultiMenu.main, "Disabilità lo skip al meeting", new[] { "No", "Emergenza", "Sempre" });
            HiddenRoles = new CustomToggleOption(num++, MultiMenu.main, "Abilità ruoli nascosti", true);
            FirstDeathShield = new CustomToggleOption(num++, MultiMenu.main, "First Death Shield Next Game", false);

            TaskTrackingSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Visibilità progressi Task");
            SeeTasksDuringRound = new CustomToggleOption(num++, MultiMenu.main, "Vedi le task durante il round", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, MultiMenu.main, "Vedi le task durante il meeting", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, MultiMenu.main, "Vedi le task solamente da morto", true);

            Assassin = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Abilità Assassino</color>");
            NumberOfImpostorAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Quanti Assassini Impostori", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Quanti Assassini Neutri", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiaco ottiene l'abilità se ottiene ruolo impostore", false);
            AmneTurnNeutAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiaco ottiene l'abilità se ottiene ruolo neutro", false);
            TraitorCanAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "il Traditore ottiene l'abilità", false);
            AssassinKills = new CustomNumberOption(num++, MultiMenu.imposter, "Quante uccisioni può fare con Assassino", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, MultiMenu.imposter, "L'Assassino può uccidere più di una volta per meeting", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, MultiMenu.imposter, "Assassino può indovinare \"Crewmate\"", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.imposter, "Assassino può indovinare Ruoli Neutrali benigni", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.imposter, "Assassino può indovinare Ruoli Neutrali cattivi", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.imposter, "Assassino può indovinare Ruoli Neutrali killer", false);
            AssassinGuessImpostors = new CustomToggleOption(num++, MultiMenu.imposter, "L'Assassino può indovinare ruoli Impostori", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "L'Assassino può indovinare ruoli Impostori Modificatori Crewmate", false);
            AssassinGuessLovers = new CustomToggleOption(num++, MultiMenu.imposter, "L'Assassino può indovinare Amanti", false);
            AssassinateAfterVoting = new CustomToggleOption(num++, MultiMenu.imposter, "L'Assassino può indovinare dopo aver votato", false);

            Aurial =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#B34D99FF>Aurial</color>");
            RadiateRange =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Raggio Radiazione", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            RadiateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Radiazione", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RadiateInvis =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Delay Radiazione", 10f, 0f, 15f, 1f, CooldownFormat);
            RadiateCount =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Radia deve vedere", 3, 1, 5, 1);
            RadiateSucceedChance =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Chance di successo Radiare", 100f, 0f, 100f, 10f, PercentFormat);

            Detective =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>Detective</color>");
            ExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Esamina", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DetectiveReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "Vedi i Report del Detective", true);
            DetectiveRoleDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Tempo quando il detective avrà il ruolo", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);
            DetectiveFactionDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Tempo quando il detective avrà la fazione", 30f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Haunter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>Infestatore</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Task rimanenti quando Infestatore potrà essere cliccato", 5, 1, 15, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Task rimanenti quando l'allerta viene segnalata", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "Infestatore rileva ruoli neutrali", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, MultiMenu.crewmate, "Chi può cliccare l'Infestatore", new[] { "Tutti", "Non-Crew", "Solo Impost" });

            Investigator =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>Investigatore</color>");
            FootprintSize = new CustomNumberOption(num++, MultiMenu.crewmate, "Grandezza Impronte", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Intervallo Impronte", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "Durata Impronte", 10f, 1f, 15f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, MultiMenu.crewmate, "Impronte Anonime", false);
            VentFootprintVisible = new CustomToggleOption(num++, MultiMenu.crewmate, "Impronte nella botola visibili", false);

            Mystic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Durata freccia per corpi morti", 0.1f, 0f, 1f, 0.05f, CooldownFormat);

            Oracle =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#BF00BFFF>Oracolo</color>");
            ConfessCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Confessione", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RevealAccuracy = new CustomNumberOption(num++, MultiMenu.crewmate, "Accuratezza Rivelazione", 80f, 0f, 100f, 10f,
                PercentFormat);
            NeutralBenignShowsEvil =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Ruoli neutrali Buoni mostrati come Cattivi", false);
            NeutralEvilShowsEvil =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Ruoli neutrali Cattivi mostrati come Cattivi", false);
            NeutralKillingShowsEvil =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Ruoli neutrali Killer mostrati come Cattivi", true);

            Seer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Veggente</color>");
            SeerCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Veggenza", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "I Crewmate Killer mostrati Rossi", false);
            NeutBenignRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Ruoli Neutri Benigni mostrati Rossi", false);
            NeutEvilRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Ruoli Neutri Cattivi mostrati Rossi", false);
            NeutKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Ruoli Neutri Killer mostrati Rossi", true);
            TraitorColourSwap =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Il traditore non cambia colore", false);

            Snitch = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Snitch</color>");
            SnitchSeesNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "Lo Snitch vede ruoli Neutrali", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Task rimanenti per essere rilevato", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, MultiMenu.crewmate, "Snitch vede gli Impostori al meeting", true);
            SnitchSeesTraitor = new CustomToggleOption(num++, MultiMenu.crewmate, "Snitch vede il Traditore", true);

            Spy =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#CCA3CCFF>Spia</color>");
            WhoSeesDead = new CustomStringOption(num++, MultiMenu.crewmate, "Chi può vedere corpi morti ad admin",
                new[] { "Nessuno", "Spia", "Tutti ma non Spia", "Tutti" });

            Tracker =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#009900FF>Inseguitore</color>");
            UpdateInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Intervallo aggiornamento freccia", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Insegui", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "Le freccie si resettano ogni round", false);
            MaxTracks = new CustomNumberOption(num++, MultiMenu.crewmate, "Massimo di inseguimenti per round", 5, 1, 15, 1);

            Trapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Quanto tempo dentro la trappola per registrare", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Trappola", 25f, 10f, 40f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Trappola viene rimossa ogni round", true);
            MaxTraps =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Massimo Trappole per Game", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Grandezza Trappola", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Persone minime per far attivare la trappola", 3, 1, 5, 1);

            Sheriff =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sceriffo</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere i Crewmate", false);
            SheriffKillsDoomsayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere Indovino", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere il Boia", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere il Giullare", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere Piromane", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere The Glitch", false);
            SheriffKillsJuggernaut =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere Juggernaut", false);
            SheriffKillsPlaguebearer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere Appestato", false);
            SheriffKillsVampire =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere il Vampiro", false);
            SheriffKillsWerewolf =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Sceriffo può uccidere Lupo Mannaro", false);
            SheriffKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Kill Sceriffo", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, MultiMenu.crewmate, "Lo Sceriffo può reportare la persona che uccide");

            VampireHunter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#B3B3E6FF>Van Helsing</color>");
            StakeCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Impalazione", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxFailedStakesPerGame = new CustomNumberOption(num++, MultiMenu.crewmate, "Massimo fail di impalazioni per Game", 5, 1, 15, 1);
            CanStakeRoundOne = new CustomToggleOption(num++, MultiMenu.crewmate, "Può impalare al primo Round", false);
            SelfKillAfterFinalStake = new CustomToggleOption(num++, MultiMenu.crewmate, "Si suicida se fallisce tutte le Impalazioni", false);
            BecomeOnVampDeaths =
                new CustomStringOption(num++, MultiMenu.crewmate, "Cosa diventa il Van Helsing quando tutti i vampiri muoiono", new[] { "Crewmate", "Sceriffo", "Veterano", "Vigilante" });

            Veteran =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veterano</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Può essere ucciso durante l'Allerta", false);
            AlertCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Allerta", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Durata Allerta", 10f, 5f, 15f, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, MultiMenu.crewmate, "Massimo numero di Allerte", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Vigilante</color>");
            VigilanteKills = new CustomNumberOption(num++, MultiMenu.crewmate, "Quante uccisioni può fare il Vigilante", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, MultiMenu.crewmate, "Il Vigilante può uccidere più di una volta per meeting", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante può indovinare Ruoli Neutri Benigni", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante può indovinare Ruoli Neutri Cattivi", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante può indovinare Ruoli Neutri Killer", false);
            VigilanteGuessLovers = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante può indovinare Amanti", false);
            VigilanteAfterVoting = new CustomToggleOption(num++, MultiMenu.crewmate, "Vigilante può indovinare dopo aver votato", false);

            Altruist = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#660000FF>Altruista</color>");
            ReviveDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Durata Rianimazione Altruista", 10f, 1f, 15f, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Il corpo in rianimazione sparisce", false);

            Medic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#006600FF>Medico</color>");
            ShowShielded =
                new CustomStringOption(num++, MultiMenu.crewmate, "Mostra Giocatore Scudato",
                    new[] { "Giocatore", "Medico", "Giocatore+Medic", "Tutti" });
            WhoGetsNotification =
                new CustomStringOption(num++, MultiMenu.crewmate, "Chi avrà la notifica di tentata uccisione",
                    new[] { "Medico", "Scudato", "Tutti", "Nessuno" });
            ShieldBreaks = new CustomToggleOption(num++, MultiMenu.crewmate, "Lo scudo si rompe al tentativo di uccisione", false);
            MedicReportSwitch = new CustomToggleOption(num++, MultiMenu.crewmate, "Mostra Report Medico");
            MedicReportNameDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Tempo quando il medico avrà il nome del Killer", 0f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Tempo quando il medico avrà il colore del Killer", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Engineer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Ingegnere</color>");
            MaxFixes =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Massimo numero di Riparazioni", 5, 1, 15, 1);

            Medium =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>");
            MediateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown Mediazione", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Rivela l'apparizione del giocatore scelto", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Rileva il Medium al giocato scelto", true);
            DeadRevealed =
                new CustomStringOption(num++, MultiMenu.crewmate, "Chi è rilevato con la Mediazione", new[] { "Morto più vecchio", "Morto più recente", "Tutti" });

            Prosecutor =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#B38000FF>Procuratore</color>");
            ProsDiesOnIncorrectPros =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Procuratore muore quando esilia un Crewmate", false);

            Swapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#66E666FF>Scambiatore</color>");
            SwapperButton =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Scambiatore può usare il bottone", true);

            Transporter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Trasportatore</color>");
            TransportCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Cooldown trasporto", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Massimo numero di trasporti", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Trasportatore può usare i Vitali", false);

            Amnesiac = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiaco</color>");
            RememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Amnesiaco ottiene delle freccie che indicano i cadaveri", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "Tempo di morte successivo all'apparizione delle freccie", 5f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Angelo Guardiano</color>");
            ProtectCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Protezione", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Durata Protezione", 10f, 5f, 15f, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Quando protetto il cooldown kill viene resettato", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, MultiMenu.neutral, "Numeri di protetti massimi", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, MultiMenu.neutral, "Mostra la protezione",
                    new[] { "Giocatore", "Angelo Guardiano", "Giocatore+AG", "Tutti" });
            GaOnTargetDeath = new CustomStringOption(num++, MultiMenu.neutral, "AG Diventa a obbiettivo ucciso",
                new[] { "Crew", "Amnesiaco", "Sopravvissuto", "Giullare" });
            GATargetKnows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Obbiettivo sa che AG esiste", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, MultiMenu.neutral, "AG Conosce il ruolo dell'obbiettivo", false);
            EvilTargetPercent = new CustomNumberOption(num++, MultiMenu.neutral, "Probabilità che obbiettivo sia cattivo", 20f, 0f, 100f, 10f,
                PercentFormat);

            Survivor =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>Sopravvissuto</color>");
            VestCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Giubbotto", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Durata Giubbotto", 10f, 5f, 15f, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown kill si resetta all'attacco", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, MultiMenu.neutral, "Numero massimo di  Giubbotti", 5, 1, 15, 1);

            Doomsayer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF80FF>Indovino</color>");
            ObserveCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Osserva", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DoomsayerGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.neutral, "Indovino può indovinare Ruoli Neutri Benigni", false);
            DoomsayerGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.neutral, "Indovino può indovinare Ruoli Neutri Cattivi", false);
            DoomsayerGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.neutral, "Indovino può indovinare Ruoli Neutri Killer", false);
            DoomsayerGuessImpostors = new CustomToggleOption(num++, MultiMenu.neutral, "Indovino può indovinare Ruoli Impostori", false);
            DoomsayerAfterVoting = new CustomToggleOption(num++, MultiMenu.neutral, "Indovino può indovinare dopo aver votato", false);
            DoomsayerGuessesToWin = new CustomNumberOption(num++, MultiMenu.neutral, "Numero di uccisioni indovinate per vincere", 3, 1, 5, 1);

            Executioner =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Boia</color>");
            OnTargetDead = new CustomStringOption(num++, MultiMenu.neutral, "Il Boia diventa alla morte dell'obbiettivo",
                new[] { "Crew", "Amnesiaco", "Sopravvissuto", "Giullare" });
            ExecutionerButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "Boia può usare il bottone", true);

            Jester =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Giullare</color>");
            JesterButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "Giullare può usare il bottone", true);
            JesterVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Giullare può nascondersi nelle ventilazioni", false);
            JesterImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "Giullare ha la visione Impostore", false);

            Phantom =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#662962FF>Fantasma</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.neutral, "Quante task il Fantasma potrà essere cliccato", 5, 1, 15, 1);

            Arsonist = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Piromane</color>");
            DouseCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Intingere", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, MultiMenu.neutral, "Massimo giocatori vivi Intinti", 5, 1, 15, 1);
            ArsoImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "Il Piromane ha la visione Impostore", false);
            IgniteCdRemoved =
                new CustomToggleOption(num++, MultiMenu.neutral, "Il Cooldown incendia è rimosso quando rimane solamente l'unico Killer", false);

            Juggernaut =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C004DFF>Juggernaut</color>");
            JuggKillCooldown = new CustomNumberOption(num++, MultiMenu.neutral, "Juggernaut Cooldown Kill iniziale", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ReducedKCdPerKill = new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown kill ridotto per Kill effettuate", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            JuggVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Juggernaut può botolare", false);

            Plaguebearer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Appestato</color>");
            InfectCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Infetta", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Kill Appestato", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Appestato può botolare", false);

            TheGlitch =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF00FF>The Glitch</color>");
            MimicCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Copia", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Durata Copia", 10f, 1f, 15f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Hack", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Durata Hack", 10f, 1f, 15f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, MultiMenu.neutral, "Glitch Kill Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, MultiMenu.neutral, "Glitch Distanza Hack", new[] { "Corto", "Normale", "Lungo" });
            GlitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Glitch può botolare", false);

            Vampire = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#262626FF>Vampiro</color>");
            BiteCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Cooldown Morso Vampiro", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VampImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "Vampiro ha la visione Impostore", false);
            VampVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Vampiro può botolare", false);
            NewVampCanAssassin =
                new CustomToggleOption(num++, MultiMenu.neutral, "Il nuovo Vampiro può uccidere", false);
            MaxVampiresPerGame =
                new CustomNumberOption(num++, MultiMenu.neutral, "Massimo Vampiri per Game", 2, 2, 5, 1);
            CanBiteNeutralBenign =
                new CustomToggleOption(num++, MultiMenu.neutral, "Può convertire Ruoli Neutri Benigni", false);
            CanBiteNeutralEvil =
                new CustomToggleOption(num++, MultiMenu.neutral, "Può convertire Ruoli Neutri Cattivi", false);

            Werewolf = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A86629FF>Lupo Mannaro</color>");
            RampageCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Durata", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Kill Cooldown", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Lupo Mannaro può botolare in Rampage", false);

            Escapist =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Fuggitivo</color>");
            EscapeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Cooldown Ritorno", 25f, 10f, 60f, 2.5f, CooldownFormat);
            EscapistVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Fuggitivo può botolare", false);

            Grenadier =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Granatiere</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Granata Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Granata Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Raggio", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, MultiMenu.imposter, "Indica i Crewmate accecati", false);
            GrenadierVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Granatiere può botolare", false);

            Morphling =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Metamorfo</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Metamorfosi Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Metamorfosi Durata", 10f, 5f, 15f, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Metamorfo può botolare", false);

            Swooper = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Invisibile</color>");
            SwoopCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Cooldown Invisibilità", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Durata Invisibilità", 10f, 5f, 15f, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Invisibile può botolare", false);

            Venerer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Venerer</color>");
            AbilityCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Ability Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AbilityDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Ability Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SprintSpeed = new CustomNumberOption(num++, MultiMenu.imposter, "Sprint Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);
            FreezeSpeed = new CustomNumberOption(num++, MultiMenu.imposter, "Freeze Speed", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);

            Bomber =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Bombarolo</color>");
            DetonateDelay =
                new CustomNumberOption(num++, MultiMenu.imposter, "Delay Detonazione", 5f, 1f, 15f, 1f, CooldownFormat);
            MaxKillsInDetonation =
                new CustomNumberOption(num++, MultiMenu.imposter, "Uccisioni massime alla detonazione", 5, 1, 15, 1);
            DetonateRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Raggio Detonazione", 0.25f, 0.05f, 1f, 0.05f, MultiplierFormat);
            BomberVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Bombarolo può botolare", false);

            Traitor = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traditore</color>");
            LatestSpawn = new CustomNumberOption(num++, MultiMenu.imposter, "Minime persone vive quando il Traditore potrà apparire", 5, 3, 15, 1);
            NeutralKillingStopsTraitor =
                new CustomToggleOption(num++, MultiMenu.imposter, "Il traditore non apparirà se ci saranno Neutri Killer vivi", false);

            Warlock = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Stregone</color>");
            ChargeUpDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Time It Takes To Fully Charge", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ChargeUseDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Time It Takes To Use Full Charge", 1f, 0.05f, 5f, 0.05f, CooldownFormat);

            Blackmailer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Ricattatore</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Cooldown Iniziale silenziamento", 10f, 1f, 15f, 1f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Minatore</color>");
            MineCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Cooldown mina", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Becchino</color>");
            DragCooldown = new CustomNumberOption(num++, MultiMenu.imposter, "Cooldown trascinare", 25f, 10f, 60f, 2.5f, CooldownFormat);
            UndertakerDragSpeed =
                new CustomNumberOption(num++, MultiMenu.imposter, "Velocità trascinazione", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);
            UndertakerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "Becchino può botolare", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, MultiMenu.imposter, "Becchino può botolare se trascina un corpo", false);

            Bait = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#00B3B3FF>Esca</color>");
            BaitMinDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Delay minimo per Report", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Delay massimo per Report", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#808080FF>Malato</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, MultiMenu.modifiers, "Cooldown Kill Moltiplicato", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Frosty = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#99FFFFFF>Gelato</color>");
            ChillDuration = new CustomNumberOption(num++, MultiMenu.modifiers, "Chill Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            ChillStartSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "Chill Start Speed", 0.75f, 0.25f, 0.95f, 0.05f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>");
            FlashSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "Flash Velocità", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>Gigante</color>");
            GiantSlow = new CustomNumberOption(num++, MultiMenu.modifiers, "Velocità Gigante", 0.75f, 0.25f, 1f, 0.05f, MultiplierFormat);

            Lovers =
                new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>Amanti</color>");
            BothLoversDie = new CustomToggleOption(num++, MultiMenu.modifiers, "I due amanti muoiono insieme");
            LovingImpPercent = new CustomNumberOption(num++, MultiMenu.modifiers, "Probabilità Amanti impostori", 20f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "Ruoli Neutrali possono essere Amanti");

            Underdog = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Perdente</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, MultiMenu.modifiers, "Cooldown Kill Bonus", 5f, 2.5f, 10f, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, MultiMenu.modifiers, "Il cooldown kill aumenta se presenti 2+ Impost", true);
        }
    }
}