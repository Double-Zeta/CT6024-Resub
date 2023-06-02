using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardState : MonoBehaviour
{
    public guardDefines guardDefines;
    private Vector3 startPos;
    private Vector3 wanderPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        wanderPos = GetWander();
    }

    private void Update()
    {
        float goalDistance = 1.0f;
        if(Vector3.Distance(transform.position,wanderPos) < goalDistance)
        {
            //arrived at goal 
            wanderPos = GetWander();
        }
    }

    private Vector3 GetWander()
   {
       return startPos + guardDefines.GetRandomDir() * Random.Range(10.0f, 50.0f);
   }
}
