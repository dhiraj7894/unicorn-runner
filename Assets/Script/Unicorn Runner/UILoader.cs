using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILoader : MonoBehaviour
{
    public static UILoader UIL;
    public LevelManager lv;
    void Start()
    {
        UIL = this;
    }

    public void etActF()
    {
        this.gameObject.SetActive(false);
    }
    public void StartD()
    {
        lv.NextLevel();
    }
}
