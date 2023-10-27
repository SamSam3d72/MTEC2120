using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAim : MonoBehaviour
{
    public Transform aimingDot3D;
    public float maxAimDistance = 100f;

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxAimDistance))
        {
            aimingDot3D.position = hit.point;
        }
        else
        {
            aimingDot3D.position = transform.position + transform.forward * maxAimDistance;
        }
    } 
}
