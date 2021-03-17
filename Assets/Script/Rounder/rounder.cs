using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rounder : MonoBehaviour
{

    public bool checkForMove = false;
    public Transform position1, position2;
    public float speed;
    public float rotateSpeed;

    private float rotation;

    public bool maxRight = false;
    void Update()
    {
        rotation += rotateSpeed;
        if (!checkForMove)
        {
            transform.rotation = Quaternion.Euler(rotation, -90, -90);
        }
        if (checkForMove)
        {
            if (transform.position.x == position1.position.x)
            {
                maxRight = false;
            }
            if (transform.position.x == position2.position.x)
            {
                maxRight = true;
            }

            if (!maxRight)
            {
                transform.position = Vector3.MoveTowards(transform.position, position2.position, speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(rotation, -90, -90);
            }
            if (maxRight)
            {
                transform.position = Vector3.MoveTowards(transform.position, position1.position, speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(-rotation, -90, -90);
            }
        }
    }
}
