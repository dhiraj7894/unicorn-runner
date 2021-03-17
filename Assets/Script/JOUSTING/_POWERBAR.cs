using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _POWERBAR : MonoBehaviour
{
    public Transform marker;
    public GameObject Glow;
    public GameObject spwan;

    [SerializeField]
    private float left, right, speed;
    private float meterSpeed;
    private bool move;
    void Start()
    {
        Glow.SetActive(false);
        spwan.SetActive(false);
    }

    void Update()
    {
        markerMovement();
        checkNumber();
    }

    void markerMovement()
    {
        marker.localPosition = new Vector3(marker.localPosition.x, marker.localPosition.y, meterSpeed);

        if (meterSpeed >= right)
        {
            move = false;
        }
        else if (meterSpeed <= left)
        {
            move = true;
        }

        if (move)
        {
            meterSpeed += speed;
        }
        else if (!move)
        {
            meterSpeed -= speed;
        }
    }

    void checkNumber()
    {
        if (Input.GetKeyDown("b"))
        {
            Glow.SetActive(true);
            spwan.SetActive(true);
            speed = 0;
            Time.timeScale = 1;
            _GAMEMANAGER.gameManager.isPowerButtonPressed = true;
            _GAMEMANAGER.gameManager.VirtualCam.SetTrigger("changeCam");
            
            Debug.Log((int)meterSpeed);
        }
    }
}
