using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class TextureModifier : AssetPostprocessor
{
        private ImportSettings newSettings;
       private void OnPreprocessTexture()
       {
           newSettings =
               (ImportSettings) AssetDatabase.LoadMainAssetAtPath(
                   DirectoryTranverser.getFirstRelevantParent(Directory.GetParent(assetPath)));         
          //  throw new NotImplementedException();
       }
    
       private void OnPostprocessTexture(Texture2D texture) 
       {
           var importer = assetImporter as TextureImporter;
           importer.maxTextureSize = newSettings.maxTextureSize;
           
           if (newSettings.overrideTextureAndroid)
           {
               importer.androidETC2FallbackOverride = AndroidETC2FallbackOverride.UseBuildSettings;
           }
       }
}
