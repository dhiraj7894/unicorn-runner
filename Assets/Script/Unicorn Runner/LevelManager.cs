using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    [Header("Game Objects")]
    public GameObject HomeLevel;

    [Header("UIs")]
    public GameObject HomeScreen;
    public GameObject NextScreen;
    //public GameObject FailScreen;
    public TextMeshProUGUI LevelsText;

    [Header("Levels")]
    public GameObject Levels;
    public GameObject[] gameLevels;

    [Header("Animation")]
    public Animator UI;

    public int levelNumber;

    private void Start()
    {
        levelManager = this;
        Application.targetFrameRate = 60;
        UI.enabled = false;
    }
    private void Update()
    {

        if (Levels == null)
            return;
    }
    public void spwnLevel()
    {
        HomeLevel.SetActive(false);
        HomeScreen.SetActive(false);
        LevelsText.text = /*"Level : " +*/ (levelNumber + 1).ToString();
        Levels = Instantiate(gameLevels[0], Vector3.zero, Quaternion.identity);
    }
    [SerializeField]
    int number;

    public void NextLevel()
    {
        NextScreen.SetActive(false);
        UI.gameObject.SetActive(true);
        levelNumber++;
        StartCoroutine(destroy(1f));
        StartCoroutine(desableUI(2.5f));
        StartCoroutine(nextLevelLoader(1f));
    }

    IEnumerator destroy(float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(Levels);
        Levels = null;
        NextScreen.SetActive(false);
    }
    IEnumerator desableUI(float t)
    {
        yield return new WaitForSeconds(t);
        UI.gameObject.SetActive(false);
    }

    IEnumerator nextLevelLoader(float t)
    {
        yield return new WaitForSeconds(t);
        
        LevelsText.text = (levelNumber + 1).ToString();
        Levels = Instantiate(gameLevels[0], Vector3.zero, Quaternion.identity);
    }

}
