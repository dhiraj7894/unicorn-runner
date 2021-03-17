using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public Animator anime;
    public GameObject point;
    public GameObject primaryCamera;
    public GameObject secondryCamera;
    public GameObject splash;
    public float poleNumber;
    public bool isReached = false;
    public bool isJump = false;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = this;
        anime.enabled = false;
        secondryCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (isReached)
        {
            anime.enabled = true;
            primaryCamera.SetActive(false);
            secondryCamera.SetActive(true);
        }
    }

    public void cameraRemove()
    {
        //primaryCamera.GetComponent<Cinemachine.CinemachineBrain>().enabled = false;
    }
}
