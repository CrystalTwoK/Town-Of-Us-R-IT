using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;
using Reactor.Utilities.Extensions;
using TownOfUs.Roles;
using TownOfUs.Extensions;
using AmongUs.GameOptions;
using TownOfUs.Patches.ScreenEffects;

namespace TownOfUs.Patches {

    static class AdditionalTempData {
        public static List<PlayerRoleInfo> playerRoles = new List<PlayerRoleInfo>();

        public static void clear() {
            playerRoles.Clear();
        }

        internal class PlayerRoleInfo {
            public string PlayerName { get; set; }
            public string Role {get;set;}
        }
    }


    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnGameEnd))]
    public class OnGameEndPatch {

        public static void Postfix(AmongUsClient __instance, [HarmonyArgument(0)] EndGameResult endGameResult)
        {
            if (CameraEffect.singleton) CameraEffect.singleton.materials.Clear();
            AdditionalTempData.clear();
            var playerRole = "";
            // Theres a better way of doing this e.g. switch statement or dictionary. But this works for now.
            foreach (var playerControl in PlayerControl.AllPlayerControls)
            {
                playerRole = "";
                foreach (var role in Role.RoleHistory.Where(x => x.Key == playerControl.PlayerId))
                {
                    if (role.Value == RoleEnum.Crewmate) { playerRole += "<color=#" + Patches.Colors.Crewmate.ToHtmlStringRGBA() + ">Crewmate</color> > "; }
                    else if (role.Value == RoleEnum.Impostor) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Impostore</color> > "; }
                    else if (role.Value == RoleEnum.Altruist) { playerRole += "<color=#" + Patches.Colors.Altruist.ToHtmlStringRGBA() + ">Altruista</color> > "; }
                    else if (role.Value == RoleEnum.Engineer) { playerRole += "<color=#" + Patches.Colors.Engineer.ToHtmlStringRGBA() + ">Ingegnere</color> > "; }
                    else if (role.Value == RoleEnum.Investigator) { playerRole += "<color=#" + Patches.Colors.Investigator.ToHtmlStringRGBA() + ">Investigatore</color> > "; }
                    else if (role.Value == RoleEnum.Mayor) { playerRole += "<color=#" + Patches.Colors.Mayor.ToHtmlStringRGBA() + ">Sindaco</color> > "; }
                    else if (role.Value == RoleEnum.Medic) { playerRole += "<color=#" + Patches.Colors.Medic.ToHtmlStringRGBA() + ">Medico</color> > "; }
                    else if (role.Value == RoleEnum.Sheriff) { playerRole += "<color=#" + Patches.Colors.Sheriff.ToHtmlStringRGBA() + ">Sceriffo</color> > "; }
                    else if (role.Value == RoleEnum.Swapper) { playerRole += "<color=#" + Patches.Colors.Swapper.ToHtmlStringRGBA() + ">Scambiatorer</color> > "; }
                    else if (role.Value == RoleEnum.Seer || role.Value == RoleEnum.CultistSeer) { playerRole += "<color=#" + Patches.Colors.Seer.ToHtmlStringRGBA() + ">Veggente</color> > "; }
                    else if (role.Value == RoleEnum.Snitch || role.Value == RoleEnum.CultistSnitch) { playerRole += "<color=#" + Patches.Colors.Snitch.ToHtmlStringRGBA() + ">Snitch</color> > "; }
                    else if (role.Value == RoleEnum.Spy) { playerRole += "<color=#" + Patches.Colors.Spy.ToHtmlStringRGBA() + ">Spia</color> > "; }
                    else if (role.Value == RoleEnum.Vigilante) { playerRole += "<color=#" + Patches.Colors.Vigilante.ToHtmlStringRGBA() + ">Vigilante</color> > "; }
                    else if (role.Value == RoleEnum.Arsonist) { playerRole += "<color=#" + Patches.Colors.Arsonist.ToHtmlStringRGBA() + ">Piromane</color> > "; }
                    else if (role.Value == RoleEnum.Executioner) { playerRole += "<color=#" + Patches.Colors.Executioner.ToHtmlStringRGBA() + ">Boia</color> > "; }
                    else if (role.Value == RoleEnum.Glitch) { playerRole += "<color=#" + Patches.Colors.Glitch.ToHtmlStringRGBA() + ">Il Glitch</color> > "; }
                    else if (role.Value == RoleEnum.Jester) { playerRole += "<color=#" + Patches.Colors.Jester.ToHtmlStringRGBA() + ">Giullare</color> > "; }
                    else if (role.Value == RoleEnum.Phantom) { playerRole += "<color=#" + Patches.Colors.Phantom.ToHtmlStringRGBA() + ">Fantasma</color> > "; }
                    else if (role.Value == RoleEnum.Grenadier) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Granatiere</color> > "; }
                    else if (role.Value == RoleEnum.Janitor) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Bidello</color> > "; }
                    else if (role.Value == RoleEnum.Miner) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Minatore</color> > "; }
                    else if (role.Value == RoleEnum.Morphling) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Metamorfo</color> > "; }
                    else if (role.Value == RoleEnum.Swooper) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Invisibile</color> > "; }
                    else if (role.Value == RoleEnum.Undertaker) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Becchino</color> > "; }
                    else if (role.Value == RoleEnum.Haunter) { playerRole += "<color=#" + Patches.Colors.Haunter.ToHtmlStringRGBA() + ">Infestato</color> > "; }
                    else if (role.Value == RoleEnum.Veteran) { playerRole += "<color=#" + Patches.Colors.Veteran.ToHtmlStringRGBA() + ">Veterano</color> > "; }
                    else if (role.Value == RoleEnum.Amnesiac) { playerRole += "<color=#" + Patches.Colors.Amnesiac.ToHtmlStringRGBA() + ">Amnesiaco</color> > "; }
                    else if (role.Value == RoleEnum.Juggernaut) { playerRole += "<color=#" + Patches.Colors.Juggernaut.ToHtmlStringRGBA() + ">Juggernaut</color> > "; }
                    else if (role.Value == RoleEnum.Tracker) { playerRole += "<color=#" + Patches.Colors.Tracker.ToHtmlStringRGBA() + ">Inseguitore</color> > "; }
                    else if (role.Value == RoleEnum.Transporter) { playerRole += "<color=#" + Patches.Colors.Transporter.ToHtmlStringRGBA() + ">Trasportatore</color> > "; }
                    else if (role.Value == RoleEnum.Traitor) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Traditore</color> > "; }
                    else if (role.Value == RoleEnum.Medium) { playerRole += "<color=#" + Patches.Colors.Medium.ToHtmlStringRGBA() + ">Medium</color> > "; }
                    else if (role.Value == RoleEnum.Trapper) { playerRole += "<color=#" + Patches.Colors.Trapper.ToHtmlStringRGBA() + ">Trapper</color> > "; }
                    else if (role.Value == RoleEnum.Survivor) { playerRole += "<color=#" + Patches.Colors.Survivor.ToHtmlStringRGBA() + ">Sopravvissuto</color> > "; }
                    else if (role.Value == RoleEnum.GuardianAngel) { playerRole += "<color=#" + Patches.Colors.GuardianAngel.ToHtmlStringRGBA() + ">Angelo Guardiano</color> > "; }
                    else if (role.Value == RoleEnum.Mystic || role.Value == RoleEnum.CultistMystic) { playerRole += "<color=#" + Patches.Colors.Mystic.ToHtmlStringRGBA() + ">Mystic</color> > "; }
                    else if (role.Value == RoleEnum.Blackmailer) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Ricattatore</color> > "; }
                    else if (role.Value == RoleEnum.Plaguebearer) { playerRole += "<color=#" + Patches.Colors.Plaguebearer.ToHtmlStringRGBA() + ">Appestato</color> > "; }
                    else if (role.Value == RoleEnum.Pestilence) { playerRole += "<color=#" + Patches.Colors.Pestilence.ToHtmlStringRGBA() + ">Pestilenza</color> > "; }
                    else if (role.Value == RoleEnum.Werewolf) { playerRole += "<color=#" + Patches.Colors.Werewolf.ToHtmlStringRGBA() + ">Lupo Mannaro</color> > "; }
                    else if (role.Value == RoleEnum.Detective) { playerRole += "<color=#" + Patches.Colors.Detective.ToHtmlStringRGBA() + ">Detective</color> > "; }
                    else if (role.Value == RoleEnum.Escapist) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Fuggitivo</color> > "; }
                    else if (role.Value == RoleEnum.Necromancer) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Negromante</color> > "; }
                    else if (role.Value == RoleEnum.Whisperer) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Sussuratore</color> > "; }
                    else if (role.Value == RoleEnum.Chameleon) { playerRole += "<color=#" + Patches.Colors.Chameleon.ToHtmlStringRGBA() + ">Camaleonte</color> > "; }
                    else if (role.Value == RoleEnum.Imitator) { playerRole += "<color=#" + Patches.Colors.Imitator.ToHtmlStringRGBA() + ">Imitatore</color> > "; }
                    else if (role.Value == RoleEnum.Bomber) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Bombarolo</color> > "; }
                    else if (role.Value == RoleEnum.Doomsayer) { playerRole += "<color=#" + Patches.Colors.Doomsayer.ToHtmlStringRGBA() + ">Indovino</color> > "; }
                    else if (role.Value == RoleEnum.Vampire) { playerRole += "<color=#" + Patches.Colors.Vampire.ToHtmlStringRGBA() + ">Vampiro</color> > "; }
                    else if (role.Value == RoleEnum.VampireHunter) { playerRole += "<color=#" + Patches.Colors.VampireHunter.ToHtmlStringRGBA() + ">Van Helsing</color> > "; }
                    else if (role.Value == RoleEnum.Prosecutor) { playerRole += "<color=#" + Patches.Colors.Prosecutor.ToHtmlStringRGBA() + ">Procuratore</color> > "; }
                    else if (role.Value == RoleEnum.Warlock) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Stregone</color> > "; }
                    else if (role.Value == RoleEnum.Oracle) { playerRole += "<color=#" + Patches.Colors.Oracle.ToHtmlStringRGBA() + ">Oracolo</color> > "; }
                    else if (role.Value == RoleEnum.Venerer) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Cultista</color> > "; }
                    else if (role.Value == RoleEnum.Aurial) { playerRole += "<color=#" + Patches.Colors.Aurial.ToHtmlStringRGBA() + ">Aurial</color> > "; }
                    if (CustomGameOptions.GameMode == GameMode.Cultist && playerControl.Data.IsImpostor())
                    {
                        if (role.Value == RoleEnum.Engineer) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Demolitore</color> > "; }
                        else if (role.Value == RoleEnum.Investigator) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Consigliere</color> > "; }
                        else if (role.Value == RoleEnum.CultistMystic) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Chiaroveggente</color> > "; }
                        else if (role.Value == RoleEnum.CultistSnitch) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Informatore</color> > "; }
                        else if (role.Value == RoleEnum.Spy) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Agente Traditore</color> > "; }
                        else if (role.Value == RoleEnum.Vigilante) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Assassino</color> > "; }
                    }
                }
                playerRole = playerRole.Remove(playerRole.Length - 3);

                if (playerControl.Is(ModifierEnum.Giant))
                {
                    playerRole += " (<color=#" + Patches.Colors.Giant.ToHtmlStringRGBA() + ">Gigante</color>)";
                }
                else if (playerControl.Is(ModifierEnum.ButtonBarry))
                {
                    playerRole += " (<color=#" + Patches.Colors.ButtonBarry.ToHtmlStringRGBA() + ">Bottone Portatile</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Aftermath))
                {
                    playerRole += " (<color=#" + Patches.Colors.Aftermath.ToHtmlStringRGBA() + ">Aftermath</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Bait))
                {
                    playerRole += " (<color=#" + Patches.Colors.Bait.ToHtmlStringRGBA() + ">Esca</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Diseased))
                {
                    playerRole += " (<color=#" + Patches.Colors.Diseased.ToHtmlStringRGBA() + ">Malato</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Flash))
                {
                    playerRole += " (<color=#" + Patches.Colors.Flash.ToHtmlStringRGBA() + ">Flash</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Tiebreaker))
                {
                    playerRole += " (<color=#" + Patches.Colors.Tiebreaker.ToHtmlStringRGBA() + ">Pareggio</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Torch))
                {
                    playerRole += " (<color=#" + Patches.Colors.Torch.ToHtmlStringRGBA() + ">Torcia</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Lover))
                {
                    playerRole += " (<color=#" + Patches.Colors.Lovers.ToHtmlStringRGBA() + ">Amanti</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Sleuth))
                {
                    playerRole += " (<color=#" + Patches.Colors.Sleuth.ToHtmlStringRGBA() + ">Segugio</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Radar))
                {
                    playerRole += " (<color=#" + Patches.Colors.Radar.ToHtmlStringRGBA() + ">Radar</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Disperser))
                {
                    playerRole += " (<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Dispersore</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Multitasker))
                {
                    playerRole += " (<color=#" + Patches.Colors.Multitasker.ToHtmlStringRGBA() + ">Multitasker</color>)";
                }
                else if (playerControl.Is(ModifierEnum.DoubleShot))
                {
                    playerRole += " (<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Doppio Colpo</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Underdog))
                {
                    playerRole += " (<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">Perdente</color>)";
                }
                else if (playerControl.Is(ModifierEnum.Frosty))
                {
                    playerRole += " (<color=#" + Patches.Colors.Frosty.ToHtmlStringRGBA() + ">Gelato</color>)";
                }
                var player = Role.GetRole(playerControl);
                if (playerControl.Is(RoleEnum.Phantom) || playerControl.Is(Faction.Crewmates))
                {
                    if ((player.TotalTasks - player.TasksLeft)/player.TotalTasks == 1) playerRole += " | Incarichi: <color=#" + Color.green.ToHtmlStringRGBA() + $">{player.TotalTasks - player.TasksLeft}/{player.TotalTasks}</color>";
                    else playerRole += $" | Tasks: {player.TotalTasks - player.TasksLeft}/{player.TotalTasks}";
                }
                if (player.Kills > 0 && !playerControl.Is(Faction.Crewmates))
                {
                    playerRole += " |<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + $"> Uccisioni: {player.Kills}</color>";
                }
                if (player.CorrectKills > 0)
                {
                    playerRole += " |<color=#" + Color.green.ToHtmlStringRGBA() + $"> Uccisioni corrette: {player.CorrectKills}</color>";
                }
                if (player.IncorrectKills > 0)
                {
                    playerRole += " |<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + $"> Uccisioni sbagliate: {player.IncorrectKills}</color>";
                }
                if (player.CorrectAssassinKills > 0)
                {
                    playerRole += " |<color=#" + Color.green.ToHtmlStringRGBA() + $"> Risposte corrette: {player.CorrectAssassinKills}</color>";
                }
                if (player.IncorrectAssassinKills > 0)
                {
                    playerRole += " |<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + $"> Risposte sbagliate: {player.IncorrectAssassinKills}</color>";
                }
                AdditionalTempData.playerRoles.Add(new AdditionalTempData.PlayerRoleInfo() { PlayerName = playerControl.Data.PlayerName, Role = playerRole });
            }
        }
    }

    [HarmonyPatch(typeof(EndGameManager), nameof(EndGameManager.SetEverythingUp))]
    public class EndGameManagerSetUpPatch {
        public static void Postfix(EndGameManager __instance)
        {
            if (GameOptionsManager.Instance.CurrentGameOptions.GameMode == GameModes.HideNSeek) return;

            GameObject bonusText = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            bonusText.transform.position = new Vector3(__instance.WinText.transform.position.x, __instance.WinText.transform.position.y - 0.8f, __instance.WinText.transform.position.z);
            bonusText.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
            TMPro.TMP_Text textRenderer = bonusText.GetComponent<TMPro.TMP_Text>();
            textRenderer.text = "";

            var position = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1f, Camera.main.nearClipPlane));
            GameObject roleSummary = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            roleSummary.transform.position = new Vector3(__instance.Navigation.ExitButton.transform.position.x + 0.1f, position.y - 0.1f, -14f); 
            roleSummary.transform.localScale = new Vector3(1f, 1f, 1f);

            var roleSummaryText = new StringBuilder();
            roleSummaryText.AppendLine("End game summary:");
            foreach(var data in AdditionalTempData.playerRoles) {
                var role = string.Join(" ", data.Role);
                roleSummaryText.AppendLine($"{data.PlayerName} - {role}");
            }
            TMPro.TMP_Text roleSummaryTextMesh = roleSummary.GetComponent<TMPro.TMP_Text>();
            roleSummaryTextMesh.alignment = TMPro.TextAlignmentOptions.TopLeft;
            roleSummaryTextMesh.color = Color.white;
            roleSummaryTextMesh.fontSizeMin = 1.5f;
            roleSummaryTextMesh.fontSizeMax = 1.5f;
            roleSummaryTextMesh.fontSize = 1.5f;
             
            var roleSummaryTextMeshRectTransform = roleSummaryTextMesh.GetComponent<RectTransform>();
            roleSummaryTextMeshRectTransform.anchoredPosition = new Vector2(position.x + 3.5f, position.y - 0.1f);
            roleSummaryTextMesh.text = roleSummaryText.ToString();
            AdditionalTempData.clear();
        }
    }
}