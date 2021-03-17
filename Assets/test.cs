using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("addedWood"))
        {
            FindObjectOfType<_PLAYER>().moveSpeed = 0;
            _GAMEMANAGER.gameManager.isPowerBarActive = true;
        }
    }
}
