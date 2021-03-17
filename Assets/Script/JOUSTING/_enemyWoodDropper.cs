using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _enemyWoodDropper : MonoBehaviour
{
    public GameObject spark;

    private void Start()
    {
        spark.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("addedWood"))
        {
            spark.SetActive(true);
            //this.transform.GetComponent<CapsuleCollider>().enabled = false;
            this.gameObject.GetComponent<Collider>().isTrigger = false;
            _GAMEMANAGER.gameManager.ePolePosition = transform.parent;
            _GAMEMANAGER.gameManager.isHorseRunning = false;
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);

            if(transform.GetChild(0).GetComponent<Animator>()!=null)
                transform.GetChild(0).GetComponent<Animator>().SetBool("activate", true);

            transform.GetComponent<Rigidbody>().useGravity = true;
            transform.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(gameObject, 1f);
        }
    }
}
