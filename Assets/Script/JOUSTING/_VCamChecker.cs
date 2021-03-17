using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _VCamChecker : MonoBehaviour
{
    /*
     /// Cinemachine Brain code if "isOK" bool value is missing.
     if ((state.BlendHint & CameraState.BlendHintValue.NoPosition) == 0)
            {
                if (!isCameraLock)
                {
                    transform.position = new Vector3(4.29f, state.FinalPosition.y, state.FinalPosition.z);
                }
                else if (isCameraLock)
                {
                    transform.position = state.FinalPosition;
                }
            }
     */
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _GAMEMANAGER.gameManager.virtualCamera.SetTrigger("rotate");            
            _GAMEMANAGER.gameManager.cm.isCameraLock  = true;
            _GAMEMANAGER.gameManager.isPlayerInCentre = true;
            _GAMEMANAGER.gameManager.isPlayerWantToGoCentre = true;            
        }
    }
}
