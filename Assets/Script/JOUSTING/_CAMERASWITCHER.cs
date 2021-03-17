using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CAMERASWITCHER : MonoBehaviour
{
    public Transform target;

    [SerializeField]private Vector3 offsetPosition;
    [SerializeField]private Vector3 offsetRotation;
    [HideInInspector]private Vector3 relPos;

    [HideInInspector] private Quaternion newRot;


    [SerializeField]private Space offsetPositionSpace = Space.Self;

    [SerializeField]private bool lookAt = true;

    [SerializeField] private float speed = 1;


    private void Update()
    {
        Refresh();
    }


    public void Refresh()
    {
        if (target == null)
        {
            Debug.LogWarning("Missing target ref !", this);
            return;
        }


        offsetPosition = new Vector3(offsetPosition.x, offsetPosition.y, offsetPosition.z);
        offsetRotation = new Vector3(offsetRotation.x, offsetRotation.y, offsetRotation.z);

        // compute position
        if (offsetPositionSpace == Space.Self)
        {
            transform.position = target.TransformPoint(offsetPosition);
        }
        else
        {
            transform.position = target.position + offsetPosition;
        }

        // compute rotation
        if (lookAt)
        {
            relPos = target.position - (transform.position + offsetPosition);
            newRot = Quaternion.LookRotation(relPos + offsetPosition);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRot, Time.deltaTime * speed);
            //transform.LookAt(target.position + offsetRotation);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }
}
