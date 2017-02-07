using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warp : MonoBehaviour {

    public float t;

    void OnTriggerStay(Collider other)
    {
        t = Time.deltaTime;
        if(other.tag=="Aground")
        {
            SceneManager.LoadScene("1");
        }
        else if (other.tag == "Bground")
        {
            SceneManager.LoadScene("2");
        }
        else if (other.tag == "Cground")
        {
            SceneManager.LoadScene("3");
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
