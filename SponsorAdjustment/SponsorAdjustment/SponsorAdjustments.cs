using Harmony;
using System;
using System.Reflection;

namespace SponsorAdjustments
{
    public class SponsorAdjustments
    {
        public static void Init() {
            var harmony = HarmonyInstance.Create("de.morphyum.SponsorAdjustments");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
