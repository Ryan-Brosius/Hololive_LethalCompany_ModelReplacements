using ModelReplacement;
using UnityEngine;

namespace HololiveModelAdditions.Replacements
{
    public class KiaraReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "kiaraPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class BotanReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "botanPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class GuraReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "guraPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class LamyReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "lamyPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class OkayuReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "okayuPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class WatameReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "watamePrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }

    public class PekoraReplacement : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            //Replace with the Asset Name from your unity project 
            string model_name = "pekoraPrefab";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }


}
