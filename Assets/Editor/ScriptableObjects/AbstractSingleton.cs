using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class AbstractSingleton<T> : ScriptableObject where T: ScriptableObject
{
    private static T objInstance  = null;

    public static T Instance
    {
        get
        {
            if (!objInstance)
            {
                objInstance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();
            }

            return objInstance; 

        }
        
    }
    
}
