 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingDisc : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("addedWood"))
        {
            FindObjectOfType<PoleIncreser>().polePosition = other.gameObject.transform.parent;
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(other.gameObject, 1f);
        }
    }
}
