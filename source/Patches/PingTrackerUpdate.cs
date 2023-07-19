using HarmonyLib;
using UnityEngine;

namespace TownOfUs
{
    //[HarmonyPriority(Priority.VeryHigh)] // to show this message first, or be overrided if any plugins do
    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingTracker_Update
    {

        [HarmonyPostfix]
        public static void Postfix(PingTracker __instance)
        {
            var position = __instance.GetComponent<AspectPosition>();
            position.DistanceFromEdge = new Vector3(3.6f, 0.1f, 0);
            position.AdjustPosition();

            __instance.text.text =
                "<color=#00FF00FF>TownOfUs v" + TownOfUs.VersionString + "</color> <color=#ff0000ff>I</color><color=#ffffffff>T</color><color=#00ff00ff>A</color>\n" +
                $"Ping: {AmongUsClient.Instance.Ping}ms\n" +
                (!MeetingHud.Instance
                    ? "<color=#00FF00FF>Modded By: Donners &</color>\n" +
                    "<color=#00FF00FF>MyDragonBreath</color>\n" : "") +
                (AmongUsClient.Instance.GameState != InnerNet.InnerNetClient.GameStates.Started
                    ? "<color=#00FF00FF>Formerly: Slushiegoose & Polus.gg</color>\n"+
                    "<color=#00FF00FF>Italian Version:</color><color=#FF0000FF>Crystal2K & Rogertarta</color>" : "");
        }
    }
}
