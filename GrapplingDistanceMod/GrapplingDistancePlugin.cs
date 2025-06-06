﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Handlers;
using Nautilus.Options;
using static OVRHaptics;

namespace Samjocal.GrapplingDistanceMod
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")] // marks Nautilus as a dependency for this mod

    public class GrapplingDistancePlugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.samjocal.grapplingdistancemod";
        private const string PluginName = "Grappling Distance Mod";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ManualLogSource Log;

        public static ModOptions ModOptions;

        private void Awake()
        {
            ModOptions = OptionsPanelHandler.RegisterModOptions<ModOptions>();
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " loaded.");
            Log = Logger;
        }
    }
}
