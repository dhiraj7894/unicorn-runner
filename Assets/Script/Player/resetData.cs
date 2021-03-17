using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetData : MonoBehaviour
{
    private poleCollector pole;
    public animationController anime;
    public GameObject SmallPole;
    public GameObject MidPole;
    public GameObject LongPole;
    public Transform PoleParentsComponent;

    private void Start()
    {
        pole = FindObjectOfType<poleCollector>();
    }

    public void resetAllData()
    {
        transform.GetComponent<PlayerMove>().lavaCheckIncrement = 0;
        transform.GetComponent<PoleIncreser>().position = 0.4f;
        transform.GetComponent<PoleIncreser>().polePosition = PoleParentsComponent;
        transform.GetComponent<Trajectory>().shootPointHeight = 1.7f;
        transform.GetComponent<Trajectory>().jumpHeight = 0.25f;
        SmallPole.GetComponent<Rigidbody>().useGravity = false;
        SmallPole.GetComponent<Rigidbody>().isKinematic = true;
        SmallPole.transform.localPosition = new Vector3(0, -0.48f, 0.43f);
        SmallPole.SetActive(false);

        MidPole.GetComponent<Rigidbody>().useGravity = false;
        MidPole.GetComponent<Rigidbody>().isKinematic = true;
        MidPole.transform.localPosition = new Vector3(0, -0.55f, 2.45f);
        MidPole.SetActive(false);

        LongPole.GetComponent<Rigidbody>().useGravity = false;
        LongPole.GetComponent<Rigidbody>().isKinematic = true;
        LongPole.transform.localPosition = new Vector3(0, -0.55f, 0.43f);
        LongPole.SetActive(false);

        pole.collecter.GetComponent<Rigidbody>().isKinematic = true;
        pole.collecter.GetComponent<Rigidbody>().useGravity = false;
        pole.collecter.gameObject.SetActive(true);
        pole.collecter.localPosition = new Vector3(-0.152f, -0.434f, -0.059f);
        pole.collecter.localRotation = Quaternion.Euler(-6, 23.606f, 0);
    }
}
