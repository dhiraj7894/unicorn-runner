using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragBoat_script : MonoBehaviour
{

    Touch touch;
    public float speedModifier;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
        
            if (touch.phase == TouchPhase.Moved && !_GAMEMANAGER.gameManager.isPlayerInCentre)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x + touch.deltaPosition.x * speedModifier, -4.75f, 4.75f),
                    transform.position.y, transform.position.z);
            }

        }
        
    }

}
