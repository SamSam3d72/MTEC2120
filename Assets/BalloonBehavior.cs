using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBehavior : MonoBehaviour
{
    private Rigidbody rb;

    
    public float flyAwayForce = 10f;

    private bool isShot = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(!isShot && collision.gameObject.CompareTag("Cube"))
        
        {
            isShot = true;
            FlyAway();
        }

        void FlyAway()
        {
            rb.AddForce(Vector3.up * flyAwayForce, ForceMode.Impulse);
        }
    }
}
