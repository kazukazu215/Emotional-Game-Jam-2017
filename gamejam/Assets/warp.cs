using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warp : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Aground")
        {
            SceneManager.LoadScene("1");
            this.transform.position = new Vector3(130,1,130);
        }
        else if (other.tag == "Bground")
        {
            SceneManager.LoadScene("1");
            this.transform.position = new Vector3(382, 1, 160);
        }
        else if (other.tag == "Cground")
        {
            SceneManager.LoadScene("1");
            this.transform.position = new Vector3(238, 1, 388);
        }

        else if (other.tag == "Dground")
        {
            SceneManager.LoadScene("scene2");
            this.transform.position = new Vector3(112, 1, 82);
        }
        else if (other.tag == "Eground")
        {
            SceneManager.LoadScene("scene2");
            this.transform.position = new Vector3(305, 1, 251);
        }
        else if (other.tag == "Fground")
        {
            SceneManager.LoadScene("scene2");
            this.transform.position = new Vector3(110, 1, 342);
        }

        else if (other.tag == "Gground")
        {
            SceneManager.LoadScene("scene3");
            this.transform.position = new Vector3(112, 1, 82);
        }
        else if (other.tag == "Hground")
        {
            SceneManager.LoadScene("scene3");
            this.transform.position = new Vector3(305, 1, 251);
        }
        else if (other.tag == "Iground")
        {
            SceneManager.LoadScene("scene3");
            this.transform.position = new Vector3(110, 1, 342);
        }


    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
