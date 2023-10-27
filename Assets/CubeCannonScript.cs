using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCannonScript : MonoBehaviour
{
    public Transform fireTip;
    public GameObject Cube;
    public Transform aimingDot;
    public float fireForce = 10f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightShift))
        {
            FireCube();
        }
    }

    void FireCube()
    {
        GameObject cubeInstance = Instantiate(Cube, fireTip.position, fireTip.rotation);

        Vector3 fireDirection = (aimingDot.position - fireTip.position).normalized;

        Rigidbody rb = cubeInstance.GetComponent<Rigidbody>();
        if(rb !=null)
        {
            rb.AddForce(fireDirection * fireForce, ForceMode.Impulse);
            Destroy(cubeInstance, 5f);
        }
    }

}
