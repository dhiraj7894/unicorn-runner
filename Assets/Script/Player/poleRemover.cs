using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poleRemover : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("lava"))
        {
            FindObjectOfType<PoleIncreser>().startDecresing = true;
        }
    }
}
