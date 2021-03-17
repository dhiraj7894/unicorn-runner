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

    private void Start()
    {
        gameManager = this;
        Application.targetFrameRate = 60;
    }

    
}
