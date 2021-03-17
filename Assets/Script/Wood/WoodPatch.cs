using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodPatch : MonoBehaviour
{
    public PoleIncreser pI;
    public Trajectory TR;
    public SoundManager sM;
    public PlayerMove pM;

    
    // Start is called before the first frame update
    void Start()
    {
        pM = FindObjectOfType<PlayerMove>();
        pI = FindObjectOfType<PoleIncreser>();
        TR = FindObjectOfType<Trajectory>();
        sM = FindObjectOfType<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            sM.Audio.PlayOneShot(sM.clip);
            pI.poleIncremental();
            Destroy(this.gameObject);
        }
    }
}
