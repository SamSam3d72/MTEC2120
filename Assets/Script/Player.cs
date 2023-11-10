using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public LayerMask hitLayer;
    public float raycastDistance = 100f;

    public delegate void CubeHitEvent(GameObject hitObject);
    public static event CubeHitEvent OnCubeHit;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, raycastDistance, hitLayer))
            {
                GameObject hitObject = hit.collider.gameObject;
                OnCubeHit?.Invoke(hitObject);

            }
        }

    }
}
