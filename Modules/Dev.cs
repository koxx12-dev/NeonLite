using HarmonyLib;

namespace NeonLite.Modules;

[HarmonyPatch]
public class Dev : Module
{
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(LeaderboardIntegrationBitcode), "HandleLeaderboardException")]
    // public static void WatchLeaderboardExceptions(ref Exception e,
    //     ref LeaderboardIntegrationBitcode.LeaderboardLoadedCallback callback)
    // {
    //     NeonLite.Instance.LoggerInstance.Error("Leaderboard exception caught", e);
    // }
}