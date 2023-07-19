using System;
using System.Collections.Generic;
using TownOfUs.Extensions;

namespace TownOfUs.CrewmateRoles.MedicMod
{
    public class DeadPlayer
    {
        public byte KillerId { get; set; }
        public byte PlayerId { get; set; }
        public DateTime KillTime { get; set; }
    }

    //body report class for when medic reports a body
    public class BodyReport
    {
        public PlayerControl Killer { get; set; }
        public PlayerControl Reporter { get; set; }
        public PlayerControl Body { get; set; }
        public float KillAge { get; set; }

        public static string ParseBodyReport(BodyReport br)
        {
            //System.Console.WriteLine(br.KillAge);
            if (br.KillAge > CustomGameOptions.MedicReportColorDuration * 1000)
                return
                    $"Body Report: Il corpo è troppo vecchio per ottenere informazioni. (è stato ucciso {Math.Round(br.KillAge / 1000)}s fa)";

            if (br.Killer.PlayerId == br.Body.PlayerId)
                return
                    $"Body Report: Sembra essere stato un suicidio! (è stato ucciso {Math.Round(br.KillAge / 1000)}s fa)";

            if (br.KillAge < CustomGameOptions.MedicReportNameDuration * 1000)
                return
                    $"Body Report: Il killer è {br.Killer.Data.PlayerName}! (è stato ucciso {Math.Round(br.KillAge / 1000)}s fa)";

            var colors = new Dictionary<int, string>
            {
                {0, "Scuro"},// red
                {1, "Scuro"},// blue
                {2, "Scuro"},// green
                {3, "Chiaro"},// pink
                {4, "Chiaro"},// orange
                {5, "Chiaro"},// yellow
                {6, "Scuro"},// black
                {7, "Chiaro"},// white
                {8, "Scuro"},// purple
                {9, "Scuro"},// brown
                {10, "Chiaro"},// cyan
                {11, "Chiaro"},// lime
                {12, "Scuro"},// maroon
                {13, "Chiaro"},// rose
                {14, "Chiaro"},// banana
                {15, "Scuro"},// gray
                {16, "Scuro"},// tan
                {17, "Chiaro"},// coral
                {18, "Scuro"},// watermelon
                {19, "Scuro"},// chocolate
                {20, "Chiaro"},// sky blue
                {21, "Chiaro"},// beige
                {22, "Scuro"},// magenta
                {23, "Chiaro"},// turquoise
                {24, "Chiaro"},// lilac
                {25, "Scuro"},// olive
                {26, "Chiaro"},// azure
                {27, "Scuro"},// plum
                {28, "Scuro"},// jungle
                {29, "Chiaro"},// mint
                {30, "Chiaro"},// chartreuse
                {31, "Scuro"},// macau
                {32, "Scuro"},// tawny
                {33, "Chiaro"},// gold
                {34, "Chiaro"},// rainbow
            };
            var typeOfColor = colors[br.Killer.GetDefaultOutfit().ColorId];
            return
                $"Body Report: Il killer sembra essere un colore {typeOfColor}. (è stato ucciso {Math.Round(br.KillAge / 1000)}s fa)";
        }
    }
}
