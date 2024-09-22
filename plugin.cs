using BepInEx;
using BepInEx.Logging;
using EFT;
using HarmonyLib;
using Comfort.Common;
using EFT.UI;

[BepInPlugin("com.YIM.EntryPointMenu", "Entry Point Reactivation", "0.5")]
public class Mod : BaseUnityPlugin
{
    private static ManualLogSource logger;

    private void Awake()
    {
        logger = Logger;
        logger.LogInfo("Mod loaded");
    }

    private void PostDBLoad()
    {
        var db = Singleton<Database>.Instance;
        db.Globals.Config.AllowSelectEntryPoint = true;
        logger.LogInfo("AllowSelectEntryPoint set to true");
    }

    public void Start()
    {
        PostDBLoad();
    }
}