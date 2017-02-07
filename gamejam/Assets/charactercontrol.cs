using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour
{
    private Vector3 velocity;
    public float speed = 10;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void FixedUpdate()
    {

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.back * speed, ForceMode.VelocityChange);
        }
    }
}