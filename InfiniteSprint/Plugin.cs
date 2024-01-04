using BepInEx;
using HarmonyLib;
using InfiniteSprint.Patches;

namespace InfiniteSprint
{


    [BepInPlugin(modGUID, modName, modVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "InfiniteSprint";
        private const string modName = "Infinite Sprint";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            harmony.PatchAll(typeof(Plugin));
            harmony.PatchAll(typeof(PlayerControllerPatch));
        }
    }
}
