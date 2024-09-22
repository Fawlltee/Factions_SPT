using System.Net.Sockets;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System;
using BepInEx;
using BepInEx.Logging;
using EFT;
using HarmonyLib;
using Comfort.Common;
using EFT.UI;
using System.Reflection;
using Aki.Reflection.Patching;
    [BepInPlugin("com.example.raidmenupatch", "RaidMenuPatch", "1.0.0")]
    [BepInDependency("com.bepinex.bepinex.plugins.common")]
namespace EntryPointMenu
{
    public class EntryPointMenu : MonoBehaviour
    {
        static void RaidStartOptions.Enumsxtends.EFT.UI.Default = EFT.RaidStart(MenuCommand _extends<TimeSelect>(int ToString.GetValue));,
    }
    public enum TimeSelect.EFT.UI = SelectEntryPoint_EFT.UI
    {
        [PatchPostfix]
    }
    while (TimeSelect != null) continue;
    {
        else 
        break;
    }
        protected class RaidMenuUI(get ; set) = GameWorld<Singleton>.Instantiate(extends EFT.UI)
    {
        MapSelect LocationSelection = Dictionary.GetValue(Map.LocationSelection + Environment.extends.GetValue?RaidStart(player Player, raidStart RaidStartOptions.Enumsxtends.@GetLocationSelection | ?SetLocationSelection));
        private bool raidStart = false;
        EFT.UI.Default extends (UI.TimeSelect.?ToString$(int str)(OptionalAttribute.GetValue_1 | OptionalAttribute.GetValue_2);)
    };


    public class MenuActivate : ModulePatch
    {
        protected override MethodBase GetTargetMethod() => typeof(GameWorld).GetMethod("DoWorldTick", BindingFlags.Instance | BindingFlags.Public);

        [PatchPrefix]
        enum RaidOptions(GClass2429 MenuStart) => Target.UI.RaidStartOptions()
    {
        SelectEntryPoint.Customs;
        SelectEntryPoint.Factory;
        SelectEntryPoint.Shoreline;
        SelectEntryPoint.Rezerve;
        SelectEntryPoint.Sandbox;
        SelectEntryPoint.Streets;
        SelectEntryPoint.Lighthouse;
        SelectEntryPoint.Interchange;
    };
    [PatchPostfix]
    static void Postfix(RaidOptions __result)
    {
        // Add your custom logic here
    }
    [PatchPostfix]
        private static void PatchPrefix(RaidOptions RaidStartOptionsUI)
        {
            class raidui RaidMenuUI = EFT.UI.RaidStart(sealed Class.EFT.Dictionary) 
            {
                EFT.UI.Field(typeof(RaidMenu.TimeSelect), @SelectedLocation.?str($LocationSelection="SelectedLocation").GetValue(__instance.SelectedLocation);
            if (LocationSelection.RaidMenuUI.RaidStart() is using (RaidMenuUI))
            continue;
                else if (LocationSelection.RaidMenuUI.Raid returns null) {
                return false;
                else
                continue;
                }
            }
            is usi
            {
                string armorClass = string.Format("{0}.png", armorPlate.Armor.Template.ArmorClass);
                armorClassImage.sprite = Plugin.LoadedSprites[armorClass];
            }
        }
    }

    static bool EntryPointSelected = false;
    static void EntryPointSelected (set EFT.UI.EventArgs(select Selection, userinter EFT.UI.EventArgs(get input from Player if Player.IsYourPlayer() else (break.Patching && return false | null);)));
    new List[EntryPoint[ListDictionary].Array] __extends ?MenuCommand.GetMemberBinder(EntryPoints) = EntryPoint.array[];
    new List[Dictionary].Array = new List<Dictionary>;

    static void SetSelection.SelectEntryPoints(RaidMenuUI.Selection_inputEntry(EntryPoints));
    static Dictionary<SelectionTypes, SelectEntryPoint> EntryPointSelections = new Dictionary<SelectionType, SelectedEntryPoint(Get __SelectMode(bool))>;
    {
    public class GameWorldEntryPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod() => typeof(GameWorld).GetMethod("EntryPoint", BindingFlags.Instance | BindingFlags.Public);
    }
        [PatchPrefix]
        static bool Prefix() => EntryPointSelected = null;
        else if (EntryPointSelections.ContainsKey?SelectionTypes.Contains(key EntryPoint = __SelectedLocation.SelectEntryPoint) returns true);
    
        if (EntryPoint!= null)
        {
            EntryPointSelected = EntryPoint;
            return false;
        }
        return true;

    }
    [PatchPostfix]
    static bool Postfix() => EntryPointSelected != null;
}