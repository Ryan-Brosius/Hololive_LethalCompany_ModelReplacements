using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using ModelReplacement;
using BepInEx.Configuration;
using System;
using HololiveModelAdditions.Replacements;

//using System.Numerics;

namespace HololiveModelAdditions
{

    [BepInPlugin("tacocat.HololiveModels", "Hololive Company", "0.1.0")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigFile config;

        public void InitConfig()
        {
            return;
        }

        private void Awake()
        {
            config = base.Config;
            InitConfig();
            Assets.PopulateAssets();

            // Plugin startup logic
            // Takes around a minute to load assets for user
            //Logger.LogInfo($"PLEASE READ, {"tacocat.HololiveModels"}  IS NOT HANGING, TAKES AROUND 10 SECONDS FOR ALL HOLOLIVE ASSETS TO LOAD");

            Logger.LogInfo("Loading Kiara");
            ModelReplacementAPI.RegisterSuitModelReplacement("Kiara", typeof(KiaraReplacement));

            Logger.LogInfo("Loading Botan");
            ModelReplacementAPI.RegisterSuitModelReplacement("Botan", typeof(BotanReplacement));

            Logger.LogInfo("Loading Gura");
            ModelReplacementAPI.RegisterSuitModelReplacement("Gura", typeof(GuraReplacement));

            //Lamy is broken at the moment
            //ModelReplacementAPI.RegisterSuitModelReplacement("Lamy", typeof(LamyReplacement));

            Logger.LogInfo("Loading Okayu");
            ModelReplacementAPI.RegisterSuitModelReplacement("Okayu", typeof(OkayuReplacement));

            Logger.LogInfo("Loading Watame");
            ModelReplacementAPI.RegisterSuitModelReplacement("Watame", typeof(WatameReplacement));

            Logger.LogInfo("Loading Pekora");
            ModelReplacementAPI.RegisterSuitModelReplacement("Pekora", typeof(PekoraReplacement));


            Harmony harmony = new Harmony("tacocat.HololiveModels");
            harmony.PatchAll();
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "mbundle";
        public static AssetBundle MainAssetBundle = null;

        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().GetName().Name;
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                Console.WriteLine(GetAssemblyName() + "." + mainAssetBundleName);
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
        }
    }

}