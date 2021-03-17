using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _WOODPATCH : MonoBehaviour
{
    private _PLAYER player;
    private SoundManager sound;
    private PoleIncreser poleIncreser;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<_PLAYER>();
        sound = FindObjectOfType<SoundManager>();
        poleIncreser = FindObjectOfType<PoleIncreser>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<poleCollector>().addPoint();
            sound.Audio.PlayOneShot(sound.clip);
            poleIncreser.poleIncremental();
            Destroy(this.gameObject);
        }
    }
}
