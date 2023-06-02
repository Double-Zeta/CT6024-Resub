using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardDefines : MonoBehaviour
{
   public static Vector3 GetRandomDir()
    {
        return new Vector3(UnityEngine.Random.Range(-1.0f, 1.0f), UnityEngine.Random.Range(-1.0f, 1f)).normalized;
    }

   
}
