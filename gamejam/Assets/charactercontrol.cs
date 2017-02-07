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
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Transform transform = GetComponent<Transform>();
        velocity = new Vector3(H,0,V);
        Physics.gravity = new Vector3(0, 9.81f, 0);
        transform.localPosition += velocity * speed;

    }
}