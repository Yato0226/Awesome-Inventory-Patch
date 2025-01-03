using AwesomeInventory.Loadout;
using HarmonyLib;
using Verse;

public class AwesomeInventorypatch : Mod
{
    public AwesomeInventorypatch(ModContentPack content) : base(content)
    {
        var harmony = new Harmony("com.louize.AwesomeInventorypatch");
        harmony.PatchAll();
    }
}

[HarmonyPatch(typeof(CompAwesomeInventoryLoadout), "get_NeedRestock")]
public static class Patch_AwesomeInventoryLoadout_NeedRestock
{
    public static bool Prefix(ref bool __result)
    {
        // Skip the original method and set the result to false
        __result = false; // Set to false or any other value you want to return
        return false; // Skip the original method
    }
}