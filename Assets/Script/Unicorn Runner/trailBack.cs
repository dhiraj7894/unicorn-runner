using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailBack : MonoBehaviour
{
    void Update()
    {
        if(transform.localPosition.z >= -20)
        {
            transform.Translate(Vector3.right * -150 * Time.deltaTime);
        }
        
    }

}
