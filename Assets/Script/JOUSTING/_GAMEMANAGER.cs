using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class _GAMEMANAGER : MonoBehaviour
{
    public static _GAMEMANAGER gameManager;
    public CinemachineBrain cm;
    public GameObject point;
    public Animator VirtualCam;
    public Animator virtualCamera;
    public Animator virtualCamera_1;
    public Transform ePolePosition;

    public bool addForce = false;
    public bool isHorseRunning = true;
    public bool isPlayerInCentre = false;
    public bool isPlayerWantToGoCentre = false;
    public bool isPowerButtonPressed = false;
    public bool isPowerBarActive = false;
    public bool startConfetti = false;

    bool UILoaded = false;

    private void Start()
    {
        gameManager = this;
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if (startConfetti && !UILoaded)
        {
            StartCoroutine(showUI(1));
        }

        if (!startConfetti && !UILoaded)
        {
            GameObject.Find("Level Manager").GetComponent<LevelManager>().NextScreen.SetActive(false);
        }
    }
    IEnumerator showUI(float t)
    {
        yield return new WaitForSeconds(t);
        GameObject.Find("Level Manager").GetComponent<LevelManager>().NextScreen.SetActive(true);
    }


}
