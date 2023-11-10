using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class CubeCannonScript : MonoBehaviour
{
    public Transform fireTip;
    public GameObject Cube;
    public Transform aimingDot;
    public float fireForce = 10f;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            FireCube();
        }

        Debug.Log("fireTip position: " + fireTip.position);
    

        Vector3 fireDirection = (aimingDot.position - fireTip.position).normalized;
        transform.LookAt(aimingDot);
    }



    void FireCube()
    {
        GameObject cubeInstance = Instantiate(Cube, fireTip.position, fireTip.rotation);

        Vector3 fireDirection = -(fireTip.position- aimingDot.position ).normalized;


        Rigidbody rb = cubeInstance.GetComponent<Rigidbody>();
        if(rb !=null)
        {
            rb.AddForce(fireDirection * fireForce, ForceMode.Impulse);
            Destroy(cubeInstance, 5f);
        }


    }

    private void OnDrawGizmos()
    {
        if (aimingDot != null)
        {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(fireTip.position, aimingDot.position);
        }
    }

}
