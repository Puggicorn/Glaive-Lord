using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlaiveCollisionDetecter : MonoBehaviour
{
    [SerializeField]
    private PlayerGlaive playerGlaive;
    [SerializeField]
    private CinemachineShake cameraShake;


    void OnCollisionEnter2D()
    {

        playerGlaive.bounceCount ++;

        //Shaking Effect
        float shakeMagnitude = playerGlaive.glaiveVelocity;
        shakeMagnitude = shakeMagnitude / 100;
        if(shakeMagnitude > 0.25)
        {
            cameraShake.ShakeCamera(shakeMagnitude * 5, 0.1f);
        }
        
    }
}
