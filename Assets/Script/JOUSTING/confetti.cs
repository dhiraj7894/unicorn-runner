using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confetti : MonoBehaviour
{
    public GameObject Confetti;

    private void Start()
    {
        Confetti.SetActive(false);
    }
    private void Update()
    {
        if (_GAMEMANAGER.gameManager.startConfetti)
        {
            Confetti.SetActive(true);
        }
    }
}
