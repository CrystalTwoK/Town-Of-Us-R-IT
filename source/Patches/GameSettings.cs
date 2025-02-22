using System.Collections.Generic;
using System.Reflection;
using System.Text;
using HarmonyLib;
using Reactor.Utilities.Extensions;
using TownOfUs.CustomOption;
using AmongUs.GameOptions;
using System.Linq;
using UnityEngine;

namespace TownOfUs
{
    [HarmonyPatch]
    public static class GameSettings
    {
        public static int SettingsPage = -1;

        [HarmonyPatch(typeof(IGameOptionsExtensions), nameof(IGameOptionsExtensions.ToHudString))]
        private static class GameOptionsDataPatch
        {
            public static IEnumerable<MethodBase> TargetMethods()
            {
                return typeof(GameOptionsData).GetMethods(typeof(string), typeof(int));
            }

            private static void Postfix(ref string __result)
            {
                if (GameOptionsManager.Instance.CurrentGameOptions.GameMode == GameModes.HideNSeek) return;

                var builder = new StringBuilder();
                builder.AppendLine("Premi TAB per cambiare pagina");
                builder.AppendLine($"Stai guardando la pagina ({(SettingsPage + 2)}/6)");
                if (SettingsPage == 0) builder.AppendLine("Impostazioni MOD generali");
                else if (SettingsPage == 1) builder.AppendLine("Impostazioni Crewmate");
                else if (SettingsPage == 2) builder.AppendLine("Impostazioni Neutrali");
                else if (SettingsPage == 3) builder.AppendLine("Impostazioni Impostori");
                else if (SettingsPage == 4) builder.AppendLine("Impostazioni Modificatori");

                if (SettingsPage == -1) builder.Append(new StringBuilder(__result));

                else
                {
                    foreach (var option in CustomOption.CustomOption.AllOptions.Where(x => x.Menu == (MultiMenu)SettingsPage))
                    {
                        if (option.Type == CustomOptionType.Button)
                            continue;

                        if (option.Type == CustomOptionType.Header)
                            builder.AppendLine($"\n{option.Name}");
                        else
                            builder.AppendLine($"    {option.Name}: {option}");
                    }
                }

                __result = $"<size=1.25>{builder.ToString()}</size>";
            }
        }

        [HarmonyPatch(typeof(GameOptionsMenu), nameof(GameOptionsMenu.Update))]
        public static class Update
        {
            public static void Postfix(ref GameOptionsMenu __instance)
            {
                __instance.GetComponentInParent<Scroller>().ContentYBounds.max = (__instance.Children.Length - 6.5f) / 2;
            }
        }

        [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
        public class LobbyPatch
        {
            public static void Postfix(HudManager __instance)
            {
                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    if (SettingsPage > 3)
                        SettingsPage = -1;
                    else
                        SettingsPage++;
                }
            }
        }
    }
}