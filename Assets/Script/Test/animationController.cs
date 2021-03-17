using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{
    public GameObject SmallPol;
    public GameObject MidPol;
    public GameObject LongPol;
    private poleCollector pole;

    public void Start()
    {
        SmallPol.SetActive(false);
        MidPol.SetActive(false);
        LongPol.SetActive(false);
        pole = FindObjectOfType<poleCollector>();
    }

    #region SmallPol
    public void ShowSmallPol()
    {
        SmallPol.SetActive(true);
    }
    public void DropSmallPol()
    {
        SmallPol.GetComponent<Rigidbody>().useGravity = true;
        SmallPol.GetComponent<Rigidbody>().isKinematic = false;
    }
    #endregion
    #region midPol
    public void ShowMidPol()
    {
        MidPol.SetActive(true);
    }

    public void DropMidPol()
    {
        MidPol.GetComponent<Rigidbody>().useGravity = true;
        MidPol.GetComponent<Rigidbody>().isKinematic = false;
    }
    #endregion
    #region longPol

    public void ShowLongPol()
    {
        LongPol.SetActive(true);
    }

    public void DropLongPol()
    {
        LongPol.GetComponent<Rigidbody>().useGravity = true;
        LongPol.GetComponent<Rigidbody>().isKinematic = false;
    }
    #endregion

    public void HideCollectedPol()
    {
        pole.collecter.gameObject.SetActive(false);
    }
}
