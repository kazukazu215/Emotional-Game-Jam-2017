using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontrol : MonoBehaviour {

    public static float speed = 1.0f;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void FixedUpdate() {

        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = Quaternion.Euler(0, H, 0) * rigidbody.velocity;

        Vector3 front = rigidbody.velocity;

        if (front.sqrMagnitude ==0)
            return;
        front.Normalize();
        rigidbody.AddForce(front * V * speed);

        if (rigidbody.velocity.sqrMagnitude > 1.0)
            rigidbody.velocity.Normalize();

       if(H==0 && V==0)
        {
            rigidbody.velocity = rigidbody.velocity * 0.97f;
        } 
    }
}
