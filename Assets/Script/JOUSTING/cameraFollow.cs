using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField]
    public Transform target;

    [SerializeField]
    private Vector3 offsetPosition;

    [SerializeField]
    private Vector3 offsetRotation;


    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;
    private void LateUpdate()
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
            transform.LookAt(target.position + offsetRotation);
        }
        else
        {
            transform.rotation = target.rotation;
        }
    }
}
