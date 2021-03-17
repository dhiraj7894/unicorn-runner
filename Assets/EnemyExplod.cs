using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyExplod : MonoBehaviour
{
    public float Force = 300;
    public bool forceAdded = false;
    public bool stop = false;

    public GameObject pole;
    public GameObject hitEffeft;

    void Update()
    {
        if (_GAMEMANAGER.gameManager.addForce && !forceAdded)
        {
            hitEffeft.SetActive(true);
            GetComponent<Animator>().SetTrigger("fall_1");
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            Time.timeScale = 1;
            _GAMEMANAGER.gameManager.VirtualCam.SetTrigger("changeCam");
            //GetComponent<Rigidbody>().AddForce(Vector3.forward * Force);

            pole.SetActive(false);
            forceAdded = true;
        }
        if (_GAMEMANAGER.gameManager.addForce && !stop)
        {
            transform.Translate(Vector3.forward * Force * Time.deltaTime);
        }
        if (stop)
        {
            Force = 0;
            GetComponent<Animator>().SetTrigger("fall");
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TJ"))
        {
            stop = true;
            
            _GAMEMANAGER.gameManager.startConfetti = true;
        }
    }
}
