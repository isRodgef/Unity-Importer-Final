using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

struct DirectorySettings
{
     public bool retroactiveChanges;
     public string[] paths;
}
    

[CreateAssetMenu(fileName = "ImportToolConfig", menuName = "ScriptableObjects/ImporterToolConfig", order = 1)]
public class ImportToolConfig : AbstractSingleton<ImportToolConfig>
{
    private DirectorySettings workingPaths;

    public bool enable;
}

