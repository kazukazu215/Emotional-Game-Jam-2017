using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        transform.Rotate(new Vector3(0, 0, z));
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        x *= Time.deltaTime;
        z *= Time.deltaTime;
        transform.Translate(0, 0, z);
        transform.Rotate(0, x, 0);
    }
       
}