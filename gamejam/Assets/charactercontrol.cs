using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
    public float speed = 0.5f;
    public static float x;
    public static float z;


    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;

        transform.Translate(0, -z * speed, 0);
        transform.Rotate(new Vector3(0, 0, x));
    }
}