using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ImportSettings : ScriptableObject
{
    // Tried nested objects and that didn't work so will have to stick to putting them all here

    // Audio Settings
    public AudioClipLoadType audioLoadType;
    public AudioCompressionFormat audioCompressFormat;
    public AudioSampleRateSetting audioSampleRate;
    public bool overrideAndroid;

    // Texture Settings 
    public int textureAnsioLevel;
    public FilterMode textureFilterMode;
    public int maxTexturesize;
    
}
