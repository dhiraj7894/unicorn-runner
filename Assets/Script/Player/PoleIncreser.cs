using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleIncreser : MonoBehaviour
{
    public GameObject[] polePart;
    public Transform polePosition;
    //public GameObject poleEnd;
    public float position = 0.2f;
    private SoundManager sound;

    private GameObject pole;

    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            poleIncremental();
            //position += 0.4f;
        }
        PoleDestryer();


    }
    int i = 0;
    public void poleIncremental()
    {
        if (polePosition.GetComponent<AnimatorRemover>() == null)
        {
            i = 1;
        }
        else if(polePosition.GetComponent<AnimatorRemover>().Number == 2) 
        {
            i = 1;
        }
        else if(polePosition.GetComponent<AnimatorRemover>().Number == 1) 
        {
            i = 0;
        }
         

        pole = Instantiate(polePart[i], polePosition);

        pole.transform.localPosition = new Vector3(0, 0.8f, 0);
        pole.transform.rotation = Quaternion.Euler(0, 0, 0);
        pole.transform.localEulerAngles = new Vector3(0, 0, 0);
        polePosition = pole.transform;
    }
    
    public bool startDecresing = false;
    float time, shoot = 0.2f, decresSpeed = 0.15f;
    void PoleDestryer()
    {      
        if (startDecresing)
        {
            if (time >= 0)
            {
                time -= decresSpeed;
            }
            if (time <= 0)
            {
                poleDecreser();
            }
        }
        if (_GAMEMANAGER.gameManager.addForce)
        {
            if (time >= 0)
            {
                time -= decresSpeed * 2;
            }
            if (time <= 0)
            {
                poleDecreser();
            }
        }

    }

    public void poleDecreser()
    {
        if(polePosition.transform.parent.name != "Cylender")
        {
            //sound.Audio.PlayOneShot(sound.poleRemoverClip);
            polePosition = polePosition.transform.parent;
            this.gameObject.GetComponent<Collider>().isTrigger = false;
            polePosition.transform.GetChild(1).GetChild(0).GetComponent<Animator>().SetBool("activate", true);
            polePosition.transform.GetChild(1).GetComponent<Rigidbody>().useGravity = true;
            polePosition.transform.GetChild(1).GetComponent<Rigidbody>().isKinematic = false;
            polePosition.transform.GetChild(1).GetChild(0).GetChild(1).gameObject.SetActive(true);
            Destroy(polePosition.transform.GetChild(1).gameObject, 1.5f);
            time = shoot;
        }
        if (polePosition.transform.parent.name == "Cylender")
        {
            ///sound.Audio.PlayOneShot(sound.poleRemoverClip);
            polePosition = polePosition.transform.parent;
            this.gameObject.GetComponent<Collider>().isTrigger = false;
            startDecresing = false;
            polePosition.transform.GetChild(0).GetComponent<Rigidbody>().useGravity = true;
            polePosition.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;
            Destroy(polePosition.transform.GetChild(0).gameObject, 1.5f);

        }

    }


}
