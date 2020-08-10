using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public struct DirectorySettings
{
     public bool retroactiveChanges;
     public string[] paths;
}
    

[CreateAssetMenu(fileName = "ImportToolConfig", menuName = "ScriptableObjects/ImporterToolConfig", order = 1)]
public class ImportToolConfig : AbstractSingleton<ImportToolConfig>
{
    ///public DirectorySettings workingPaths;

    // Cannot seem to store  a struct in a scriptable object 
    public bool retroactiveChanges;
    public string[] paths;
    
   
}

