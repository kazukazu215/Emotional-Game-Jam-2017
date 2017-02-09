using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class macinemonster : MonoBehaviour {
    float x=0.05f,z = 0.05f;
    float c = 0f,c2 = 0f;

   
   

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (c <= 10)
        {
            Vector3 p = new Vector3(0, 0, z);
            transform.Translate(p);
            c += 0.05f;
        }
        else if (c > 10 && c2 < 10)
        {
            if (c2 <= 0.05f)
            {
                transform.Rotate(new Vector3(0f, -45f, 0f));
            }
            Vector3 p = new Vector3(0, 0, z);
            transform.Translate(p);
            c2 += 0.05f;
        }
        
        else if (c2 > 10 && c2<20)
            {
            if (c2 <= 10.05f)
            {
                transform.Rotate(new Vector3(0f, 180f, 0f));
            }
            Vector3 p = new Vector3(0, 0, z);
            transform.Translate(p);
            c2 += 0.05f;
        
        }
        else if(c2 > 20 && c<=20)
        {
            if (c <= 10.05f)
            {
                transform.Rotate(new Vector3(0f, 90f, 0f));
            }

            Vector3 p = new Vector3(0, 0, z);
            transform.Translate(p);
            c += 0.05f;
        }
        else
        {
            transform.Rotate(new Vector3(0f, 180f, 0f));
            c = 0;
            c2 = 0;
        }




        }
		
	}
