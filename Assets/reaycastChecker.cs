using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reaycastChecker : MonoBehaviour
{
    void Update()
    {/*
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward))*/
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, -transform.up * 1);
    }
}
