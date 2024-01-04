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

    [BepInPlugin("tacocat.HololiveModels", "Hololive Company", "1.3.0")]
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

            ModelReplacementAPI.RegisterSuitModelReplacement("Kiara", typeof(KiaraReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Botan", typeof(BotanReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Gura", typeof(GuraReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Lamy", typeof(LamyReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Okayu", typeof(OkayuReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Watame", typeof(WatameReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Pekora", typeof(PekoraReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Koyori", typeof(KoyoriReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Korone", typeof(KoroneReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Polka", typeof(PolkaReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Towa", typeof(TowaReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Marine", typeof(MarineReplacement));

            ModelReplacementAPI.RegisterSuitModelReplacement("Kanata", typeof(KanataReplacement));


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