using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    void OnCollisionEnter(CubeCollision collision)
    {
        Destroy(gameObject);
    }
}