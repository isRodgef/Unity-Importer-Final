using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using UnityEditor;
using UnityEngine;

public class DirectoryTranverser 
{
    public static string getFirstRelevantParent(DirectoryInfo   dirToCheck)
    {
        // Get full list of ImportSettings
        string[] guids = AssetDatabase.FindAssets("t:ImportSettings", null); //null);
        List<string> tmp = new List<string>();
        ///DirectoryInfo 

        foreach (string guid1 in guids)
        {
            // Add paths to assets in list for later use
            tmp.Add(AssetDatabase.GUIDToAssetPath(guid1));
        }

        // stop checking for importSettings type assets once we reach the Asset Directory
        while (dirToCheck.FullName != Application.dataPath)
        {
            foreach (string assetFullPath in tmp)
            {
                // Create new DirectoryInfo Object so it's easier to compare the full path to dirToCheck
                DirectoryInfo assetDir = Directory.GetParent(assetFullPath);

                if (dirToCheck.FullName == assetDir.FullName)
                {
                    // return path to config
                    return assetFullPath;
                }
            }
            dirToCheck = Directory.GetParent(dirToCheck.FullName);
        }
        return null;
    }
    
    
 /* string[] guids =  AssetDatabase.FindAssets("t:ImportSettings", null); 
        List<string> tmp = new List<string>();
        
        foreach (string guid1 in guids)
        {
            //Debug.Log(AssetDatabase.GUIDToAssetPath(guid1));
            tmp.Add(AssetDatabase.GUIDToAssetPath(guid1));
        }

        allSettingsPaths = tmp.ToArray();
        

        DirectoryInfo info = Directory.GetParent(allSettingsPaths[0]);
        //var name = info.Name;
       info = Directory.GetParent(info.Name);
        Debug.Log(allSettingsPaths[0]);
        Debug.Log(info.Name);
        Debug.Log(Application.dataPath);
        Debug.Log(assetPath);
        */
}
