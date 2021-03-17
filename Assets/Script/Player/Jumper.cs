using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{

    private Trajectory trajectory;
    private poleCollector pole;

    public static Jumper jump;
    [SerializeField] public float delay;
    [SerializeField] public float delayForRemovealOfPole;
    [SerializeField] public float delayForGrounded;
    [SerializeField] public Animator MCAnimation;

    // Start is called before the first frame update
    void Start()
    {
        jump = this;
        trajectory = GetComponent<Trajectory>();
        pole = GetComponent<poleCollector>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && GetComponent<PlayerMove>()._isGrounded)
        {
            GameManager.gameManager.isJump = true;
            StartCoroutine(SMALLjump(delay, delayForRemovealOfPole));
        }

        if (Input.GetKeyDown(KeyCode.T) && GetComponent<PlayerMove>()._isGrounded)
        {
            GameManager.gameManager.isJump = true;
            StartCoroutine(MIDjump(delay, delayForRemovealOfPole));
        }

        if (Input.GetKeyDown(KeyCode.Y) && GetComponent<PlayerMove>()._isGrounded)
        {
            GameManager.gameManager.isJump = true;
            StartCoroutine(LONGjump(delay, delayForRemovealOfPole));
        }
    }

    public IEnumerator SMALLjump(float a, float b)
    {
        MCAnimation.SetTrigger("jump");
        yield return new WaitForSeconds(a);
        trajectory.jump();
        yield return new WaitForSeconds(b);
        addRigidbodyToPoles();
    }
    public IEnumerator MIDjump(float a, float b)
    {
        MCAnimation.SetTrigger("midJump");
        yield return new WaitForSeconds(a);
        trajectory.jump();
        yield return new WaitForSeconds(b);
        addRigidbodyToPoles();
    }
    public IEnumerator LONGjump(float a, float b)
    {
        MCAnimation.SetTrigger("longJump");
        yield return new WaitForSeconds(a);
        //trajectory.jump();
        yield return new WaitForSeconds(b);
        //addRigidbodyToPoles();
    }

    void addRigidbodyToPoles()
    {
        pole.collecter.GetComponent<Rigidbody>().useGravity = true;
        pole.collecter.GetComponent<Rigidbody>().isKinematic = false;

        foreach (Transform child in pole.collecter)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void setTriggerRun()
    {
        MCAnimation.SetTrigger("normalPos");
    }
}
