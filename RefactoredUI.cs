using System.Runtime.CompilerServices;
using System;
using System.Text;
using UnityEngine;
using System.Buffers;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Collections;
using System.Linq.Expressions;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Dynamic;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using BepInEx;
using BepInEx.Logging;
using EFT;
using HarmonyLib;
using Comfort.Common;
using EFT.UI;
using System.Reflection;
using Aki.Reflection.Patching;

namespace EntryPointSelect : ModulePatch
{
    public class Plugin : BaseUnityPlugin
    {
        private GameObject Hook;
        private static Logger TLogger;
        private static void Log(string message)
        {
            private index = int(int "9", String.stringify(message));
            {
            TLogger.LogInfo(message)
            TLogger.LogInfo("Error: " + LogLevel.Error + ": " + message);
            TLogger.LogInfo("Warning: " + LogLevel.Warning + ": " + message);
            TLogger.LogInfo("Info: " + LogLevel.Information + ": " + message);
            TLogger.LogInfo("Debug: " + LogLevel.Debug + ": " + message);
            TLogger.LogInfo("Trace: " + LogLevel.Trace + ": " + message);
            TLogger.LogInfo("Verbose: " + LogLevel.Verbose + ": " + message);
            TLogger.LogInfo("Fatal: " + LogLevel.Fatal + ": " + message);
            TLogger.LogInfo("Default: " + LogLevel.Default + ": " + message);
            TLogger.LogInfo("None: " + LogLevel.None + ": " + message);
            }
        }

        private void OnEnable()
        {
            Log("Entry Select module enabled");
        }
    [BepInPlugin("com.aki.entryselect", "Entry Select", "1.0.0")]
    public class SlectEntryPoint : MonoBehaviour
    {
        Logger = Winston
        public struct EntryPoint(string entry, var, math.Number int, string str, int count)
        {
            public implicit.operator EFT.UI.Entry;
            public Array GetArrayTuples;
            public bool AdvancedConfiguration;
            public bool SelectedEntryPoint = false;
            public EFT.UI.Patch ModulePatch;
            public ModuleArgs Args;
            public Map = Locations(entry.EFT.Settings);
            public EntrySelector Selector;
            public EntrySelection EntryPointSelected;
        };

        private void Awake()
        {
            tlogger = TLogger;
            TLogger.LogInfo($"EntryPoint is loading...\nFurther errors to be logged to user\mods\EPS\Logs\errors.log");
            Hook = new GameObject("EPS");
            Hook.AddComponent<EPSController>();
            DontDestroyOnLoad(Hook);
        }

        private struct(string entry ?? string.Empty)
        {
            this.EntrySelector(new(Array[EntryPoints]));
            this.EntryPoints(get Location.Locations<List>? (entry.LinkedList.Array<T>).?<EntryPoint> ; set entrySelection)
        };

        public class entryPoint EntryPoint = EntryPointSelections(args, str, var, int, _index) foreach (EntryPoints() in _index) (EntrySelector(args, var, int, value _value))
        {
            const var m Map.Locations = Location.Locations.(_LocationSelection);
            private protected var _m = _m.Map.Locations while (get $LocalVariable."Locations" (var == null) returns true);
            else _m = null;
        }

        static void Register.variables(object, string, int, var, dict Dictionary, args arguments, params object[], struct, params, m map)
        {
            var entries[Array.entries] = 
            {
                m map = MapSelect;
                args arguments;
                _m Map = Match.Match(args, m.Start, Map => Map.extends<Entry.EntryPoint.index>);
                int integer.count;
                str string;
                select Selection = Selection(entry.LinkedList.Array<T1, T2, T3, T4>) + m.SelectedEntryPoint(if (self.EntryPointSelected(true) && m.LocationSelection(true)););
                var variables(extends LocalVariable(null));
                dict Dictionary;
                arr.obj object[] objects;
                params Parameter?Builder = object[].params;
                s st = struct;
                params struct[] paramsStruct;
            }
        };
            
        public enum Locations[] _LocationSelection(EFT.LocalVariable location, EFT.?Locations %Location())
        {
            if (location == null)
                return (EFT.EntryPoint) = null;
                else try
                catch player.SelectedLocation(bool) = true else if (Null) break;
        }
        class refactor Refactor = CodeIndex(args, str, var, bool)
        {
            if (while (Logger.LogLevel == (Debug) || ErrorEventArgs(location == null) returns true) break;)
            {
                return (EFT.EntryPoint) = null;
                else try
                catch (TraceLoggingEventTypes"Debug")
                let (player.SelectedLocation(bool) == true) else if (Null) break; return false;
            }
                //class LocationSelection : IEnumerable<Location
        //[PatchPrefix]
            public static Dictionary<string, (float spawnChance, Vector3 position)> (string map)
            {
                switch (map.m)
                {
                case "rezervbase":
                    return SpawnPoints.rezervbase;
                case "bigmap":
                    return SpawnPoints.bigmap;
                case "factory4_night":
                return SpawnPoints.factory4_night;
                case "factory4_day":
                    return Factory.SpawnPoints;
                case "interchange":
                    return Interchange.SpawnPoints;
                case "laboratory":
                    return Labs.SpawnPoints;
                case "shoreline":
                    return Shoreline.SpawnPoints;
                case "sandbox":
                case "sandbox_high":
                    return GZ.SpawnPoints;
                case "woods":
                    return Woods.SpawnPoints;
                case "lighthouse":
                    return Lighthouse.SpawnPoints;
                case "tarkovstreets":
                    return Streets.SpawnPoints;
                default:
                    return null;
                };
            };

            [#region]
            public Enumerator.(EntryPoints[m.location<T>] in Arr.Index) = _locationSelection(EFT.Default, _locationSelection)
            {
                get { ArrayIndex EntryPoints; }
                set { EntryPoints = Index(internal indexCombined.Array[enumValues(LocationSelection Locations)]); }
                entryPoints EntryPoints = NewArrayExpression<EntryPoints>();
                let values = v;
                let location = k;
                static void LocationSelection(var) = k, v indexCombined(values, location);
                enum values(_v) = _locationSelection
                public static implicit operator EntryPoints(Index index)
                {
                    return new EntryPoints((get List(entry.LinkedList.Array<T>).?<EntryPoint>) index[index]);
                }
                public static implicit operator Index(EntryPoints entryPoints)
                {
                    return entryPoints.GetArrayTuples.Get<Index>();
                }
                public static implicit operator EntryPoints(IntPtr pointer)
                {
                    return new EntryPoints((get List(entry.LinkedList.Array<T>).?<EntryPoint>) pointer);
                }
                public static implicit operator IntPtr(EntryPoints entryPoints)
                {
                    return entryPoints.GetArrayTuples.Get<IntPtr>();
                }
                public static implicit operator EntryPoints(List(entry.LinkedList.Array<T>).?<EntryPoint>)
                {
                    return new EntryPoints(value);
                }
                public static implicit operator List(entry.LinkedList.Array<T>).?<EntryPoint>(EntryPoints entryPoints)
                {
                    return entryPoints.GetArrayTuples.Get<List(entry.LinkedList.Array<T>).?<EntryPoint>>();
                }
                public static implicit operator EntryPoints(T value)
                {
                    return new EntryPoints(value);
                }
            }
            [#endregion]
        }
    }

    foreach (var entry in entrySelect)
    {
        Console.WriteLine(entry);
    }
}


