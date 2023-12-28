using ModelReplacement;
using UnityEngine;

namespace HololiveModelAdditions.Replacements
{
    public class EmiliaReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "emiliaPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class BeatriceReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "beatricePrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class FelixReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "felixPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class RamReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "ramPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class RemReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "remPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class SubaruReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "subaruPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}
