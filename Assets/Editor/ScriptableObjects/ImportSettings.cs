using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

[CreateAssetMenu(fileName = "ImportToolConfig", menuName = "ScriptableObjects/ImportSettings", order = 1)]
public class ImportSettings : ScriptableObject
{
    // Tried nested objects and that didn't work so will have to stick to putting them all here

    // Audio Settings
    public AudioClipLoadType audioLoadType;
    public AudioCompressionFormat audioCompressFormat;
    public AudioSampleRateSetting audioSampleRate;
    public bool overrideAudioAndroid;

    // Texture Settings 
    public TextureResizeAlgorithm textureResize;  
    public int maxTextureSize;
    public bool overrideTextureAndroid;

    public bool retroactiveSettingsChange;
    
    private void OnValidate()
    {
       
        if (retroactiveSettingsChange)
        {
            DirectoryInfo Parent = Directory.GetParent(AssetDatabase.GetAssetPath(this));
            string fullyQualifiedPath = Parent.FullName;
            
            string[] textureLists = AssetDatabase.FindAssets("t:texture2d", null); //new string []{AssetDatabase.GetAssetPath(this)});
            string [] audioLists = AssetDatabase.FindAssets("t:audioclip", null);
            
            foreach (string text1 in textureLists)
            {
                string texture = AssetDatabase.GUIDToAssetPath(text1);
                Debug.Log(AssetDatabase.GUIDToAssetPath(text1));
                if (Directory.GetParent(texture).FullName == fullyQualifiedPath)
                {
                    //AssetDatabase.ImportAsset(text1);
                }
            }
            
            foreach (string audio1 in audioLists)
            {
                string audio = AssetDatabase.GUIDToAssetPath(audio1);
                Debug.Log(AssetDatabase.GUIDToAssetPath(audio1));
                if (Directory.GetParent(audio).FullName == fullyQualifiedPath)
                {
                   // AssetDatabase.ImportAsset(audio);
                }
            }
            
        }
    
    }
}