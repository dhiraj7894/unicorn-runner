using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorRemover : MonoBehaviour
{
    private SoundManager sound;
    public int Number;
    bool forceAdded = false;
    int random = 0;
    public LayerMask seLayer;


    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }


    public void Update()
    {
        if (forceAdded)
        {
            if (random == 0)
            {
                transform.GetComponent<Rigidbody>().AddForce((-transform.right - transform.forward) * 3.5f, ForceMode.Impulse);
            } else if (random == 1)
            {
                transform.GetComponent<Rigidbody>().AddForce((transform.right - transform.forward) * 3.5f, ForceMode.Impulse);
            }
            forceAdded = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cutter"))
        {
            transform.GetChild(0).GetComponent<Animator>().SetBool("activate", true);
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("wall"))
        {
            other.gameObject.GetComponent<Collider>().enabled = false;
            other.gameObject.GetComponent<Animator>().enabled = true;
            transform.GetComponent<Collider>().isTrigger = false;
            forceAdded = true;
            random = Random.Range(0, 2);
            sound.Audio.PlayOneShot(sound.poleRemoverClip);
            FindObjectOfType<PoleIncreser>().polePosition = transform.parent;
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetComponent<Animator>().SetBool("activate", true);
            transform.GetComponent<Rigidbody>().useGravity = true;
            transform.GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            Destroy(this.gameObject, 2.5f);
            Destroy(other.gameObject, 1.2f);
        }

        if (other.gameObject.CompareTag("addedWood"))
        {
            Time.timeScale = 0.25f;
            other.gameObject.layer = seLayer;
            gameObject.layer = seLayer;
            other.gameObject.tag = "FJ";
            transform.GetComponent<Collider>().isTrigger = false;
            FindObjectOfType<PoleIncreser>().polePosition = transform.parent;
            forceAdded = true;
            random = Random.Range(0, 2);
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            transform.GetChild(0).GetComponent<Animator>().SetBool("activate", true);
            transform.GetComponent<Rigidbody>().useGravity = true;
            transform.GetComponent<Rigidbody>().isKinematic = false;
            Destroy(this.gameObject, 1f);
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            _GAMEMANAGER.gameManager.addForce = true;
        }
    }

}
