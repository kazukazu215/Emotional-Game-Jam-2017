using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class warp2 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("2");
        if (other.tag == "Aground")
        {
            this.transform.position = new Vector3(240, 2, 240);
        }
        else if (other.tag == "Bground")
        {
            this.transform.position = new Vector3(111, 2, 401);
        }
        else if (other.tag == "Cground")
        {
            this.transform.position = new Vector3(381, 2, 85);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
