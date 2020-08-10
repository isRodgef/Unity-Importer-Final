using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioModifier : AssetImporter
{
    private void OnPreprocessAudio()
    {
        Debug.Log("Rodger does audio\n\n\n");
    }

    private void OnPostprocessAudio(AudioClip arg)
    {
      /*  var importer = assetImporter as AudioImporter;

        if (importer == null)
            return;


        AudioImporterSampleSettings sampleSettings = importer.defaultSampleSettings;


        sampleSettings.loadType = AudioClipLoadType.Streaming;
        sampleSettings.compressionFormat = AudioCompressionFormat.AAC;

        importer.defaultSampleSettings = sampleSettings;



        Debug.Log(arg);*/
    }
}
