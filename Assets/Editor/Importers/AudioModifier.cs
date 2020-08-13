using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
public class AudioModifier : AssetPostprocessor
{
    private ImportSettings newSettings;
    
    private void OnPreprocessAudio()
    {
        newSettings =
            (ImportSettings) AssetDatabase.LoadMainAssetAtPath(
                DirectoryTranverser.getFirstRelevantParent(Directory.GetParent(assetPath)));
    }

    private void OnPostprocessAudio(AudioClip arg)
    {
        var importer = assetImporter as AudioImporter;

        if (importer == null)
            return;
        
        // Set values to asset in current directory or first parent directory with asset included
        AudioImporterSampleSettings sampleSettings = importer.defaultSampleSettings;
        sampleSettings.loadType = newSettings.audioLoadType;
        sampleSettings.compressionFormat = newSettings.audioCompressFormat;
        sampleSettings.sampleRateSetting = newSettings.audioSampleRate;
        importer.defaultSampleSettings = sampleSettings;
        
        if (newSettings.overrideAudioAndroid)
        {
            importer.SetOverrideSampleSettings("Android", sampleSettings);
        }

    }
    
}
