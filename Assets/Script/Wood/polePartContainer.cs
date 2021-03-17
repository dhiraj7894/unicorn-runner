using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polePartContainer : MonoBehaviour
{

    public List<Transform> points = new List<Transform>();
    public GameObject wood;
    
    //[SerializeField] private Transform spawnPoint;

    void Start()
    {
        foreach(Transform child in transform)
        {
            points.Add(child);
        }
        for(int i = 0; i < points.Count; i++)
        {
            GameObject a = Instantiate(wood, points[i].position, Quaternion.identity);
            a.transform.parent = transform;
        }
    }


/*    void patternSpwn()
    {
        float x, z, maxX,maxY;


    }*/
}
