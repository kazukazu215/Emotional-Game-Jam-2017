using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
    public float speed=0.5f;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
 
        transform.Translate(0, -z*speed, 0);
        transform.Rotate(new Vector3(0, 0, x));
    }

}