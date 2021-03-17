using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {

        /*if (other.gameObject.CompareTag("VCamSwitch"))
        {
            _GAMEMANAGER.gameManager.virtualCamera.transform.GetComponent<Animator>().SetTrigger("switchCam");
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }*/
        /*switch (other.gameObject.tag)
        {
            case "start":
                //11.07
                //5
                GetComponent<Trajectory>().shootPointHeight = 11.07f;
                GetComponent<Trajectory>().jumpHeight = 5f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(7.75f, 0, 0);
                StartCoroutine(jumpS(0.2f));
                break;

            case "FJ":
                //4
                //4
                GetComponent<Trajectory>().shootPointHeight = 11.4f;
                GetComponent<Trajectory>().jumpHeight = 7.5f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(7.75f, 0, 0);
                StartCoroutine(jump(0.4f));
                break;

            case "SJ":
                //20.3
                //6
                GetComponent<Trajectory>().shootPointHeight = 20.3f;
                GetComponent<Trajectory>().jumpHeight = 6f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(5.45f, 0, 0);
                StartCoroutine(jump(0.4f));
                break;

            case "TJ":
                //10.1
                //7
                GetComponent<Trajectory>().shootPointHeight = 10.1f;
                GetComponent<Trajectory>().jumpHeight = 7f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(12, 0, 0);
                StartCoroutine(jump(0.4f));
                break;

            case "FRJ":

                //21
                //6

                GetComponent<Trajectory>().shootPointHeight = 18;
                GetComponent<Trajectory>().jumpHeight = 4f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(5f, 0, 0);
                StartCoroutine(jump(0.4f));
                break;

            case "FTJ":
                GetComponent<Trajectory>().shootPointHeight = 11.1f;
                GetComponent<Trajectory>().jumpHeight = 5f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(8.8f, 0, 0);
                StartCoroutine(jump(0.4f));

                break;
            case "pool-1":
                GetComponent<Trajectory>().shootPointHeight = 2.85f;
                GetComponent<Trajectory>().jumpHeight = 3f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(5, 0, 0);
                StartCoroutine(jumpS(0.4f));
                break;

            case "pool-2":
                GetComponent<Trajectory>().shootPointHeight = 1.77f;
                GetComponent<Trajectory>().jumpHeight = 2f;
                GetComponent<Trajectory>().shootPoint.rotation = Quaternion.Euler(4, 0, 0);
                StartCoroutine(jumpS(0.4f));
                break;

            case "Water":
                Instantiate(GameManager.gameManager.splash, new Vector3(transform.position.x, -0.59f, transform.position.z), Quaternion.Euler(90,0,0));
                GameManager.gameManager.cameraRemove();
                GetComponent<Jumper>().MCAnimation.SetTrigger("water");
                break;

        }*/
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        //Using in Jousting Game
        if (collision.gameObject.CompareTag("lava"))
        {
            transform.GetComponent<PoleIncreser>().startDecresing = true;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            switch (collision.gameObject.name)
            {
                case "X9":
                    GameManager.gameManager.isReached = true;
                    break;

                case "X8":
                    GameManager.gameManager.isReached = true;
                    break;

                case "X7":
                    GameManager.gameManager.isReached = true;
                    break;

                case "X6":
                    GameManager.gameManager.isReached = true;
                    break;

                case "X5":
                    GameManager.gameManager.isReached = true;
                    break;
            }
        }

    }*/

    //Using in Jousting Game
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("lava"))
        {
            transform.GetComponent<PoleIncreser>().startDecresing = false;
        }
    }

    IEnumerator jump(float t)
    {
        StartCoroutine(Jumper.jump.MIDjump(Jumper.jump.delay, Jumper.jump.delayForRemovealOfPole));
        yield return new WaitForSeconds(t);
        GameManager.gameManager.isJump = true;
    }
    IEnumerator jumpS(float t)
    {
        StartCoroutine(Jumper.jump.SMALLjump(Jumper.jump.delay, Jumper.jump.delayForRemovealOfPole));
        yield return new WaitForSeconds(t);
        GameManager.gameManager.isJump = true;
    }
}
