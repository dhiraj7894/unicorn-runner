using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _woodPointGenrator : MonoBehaviour
{
    public int numberOfPoints;
    public GameObject point;


    void Start()
    {
        for (int i = 0; i < numberOfPoints; i++)
        {
            GameObject a = Instantiate(point, point.transform.position, Quaternion.identity);
            a.transform.parent = transform;
        }
    }
}
