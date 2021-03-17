using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _poleEndPartCollider : MonoBehaviour
{
    public bool activate = false;   
    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.CompareTag("enemy"))
        {
            _GAMEMANAGER.gameManager.addForce = true;
            
        }*/
        if (other.gameObject.CompareTag("addedWood"))
        {
            if (activate)
            {
                this.gameObject.GetComponent<Rigidbody>().useGravity = true;
                this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
                Destroy(gameObject, 1);
            }
            
        }
    }
}
