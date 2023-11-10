using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAim : MonoBehaviour
{
    public Transform aimingDot3D;
    public float maxAimDistance = 100f;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }



    private void Update()
    {



        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            // Do something with the object that was hit by the raycast.
            aimingDot3D.position = hit.point;
        }
        else
        {
            aimingDot3D.position = transform.position + transform.forward * maxAimDistance;
        }

        //RaycastHit hit;
        //if (Physics.Raycast(point, transform.forward, out hit, maxAimDistance))
        //{
        //    aimingDot3D.position = hit.point;
        //}
        //else
        //{
        //    aimingDot3D.position = transform.position + transform.forward * maxAimDistance;
        //}
    }
}
