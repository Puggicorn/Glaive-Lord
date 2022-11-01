using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStretch : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform playerTransform;
    [SerializeField] float threshold;

    void Update()
    {
        if(playerTransform == null) return;
        
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPos = (playerTransform.position + mousePos) / 2f;
        targetPos.x = Mathf.Clamp(targetPos.x, -threshold + playerTransform.position.x, threshold + playerTransform.position.x);
        targetPos.y = Mathf.Clamp(targetPos.y, -threshold + playerTransform.position.y, threshold + playerTransform.position.y);

        this.transform.position = targetPos;

    }
}
