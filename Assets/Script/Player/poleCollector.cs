using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poleCollector : MonoBehaviour
{

    public Transform collecter;
    public Transform pointPrefebCollector;
    public List<GameObject> pols = new List<GameObject>();


 

    public void activateGravity()
    {
        for (int i = 0; i < pols.Count; i++)
        {
            pols[i].GetComponent<Rigidbody>().useGravity = true;
            pols[i].GetComponent<Rigidbody>().isKinematic = false;
            Destroy(pols[i], 1);
        }
    }

    private GameObject pointData;
    public void addPoint()
    {
        pointData = Instantiate(_GAMEMANAGER.gameManager.point, pointPrefebCollector.position, Quaternion.identity);
        pointData.transform.parent = pointPrefebCollector.transform;
        Destroy(pointData, 2.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wood"))
        {
            pols.Clear();
            foreach (Transform child in collecter)
            {
                pols.Add(child.transform.gameObject);
            }
            for (int i = 0; i < pols.Count; i++)
            {
                pols[i].GetComponent<Rigidbody>().useGravity = false;
                pols[i].GetComponent<Rigidbody>().isKinematic = true;
            }
            //addPoint();
        }
    }
}
