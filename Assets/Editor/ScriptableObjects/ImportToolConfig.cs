using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[CreateAssetMenu(fileName = "ImportToolConfig", menuName = "ScriptableObjects/ToolConfig", order = 1)]
public class ImportToolConfig : AbstractSingleton<ImportToolConfig>
{
    ///public DirectorySettings workingPaths;

    // Cannot seem to store  a struct in a scriptable object 
    public bool retroactiveChanges;
    public string[] paths;
    
   
}

