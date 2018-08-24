using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale : MonoBehaviour {
    float timer;
    Vector3 vector;
	// Use this for initialization
	void Start () {
        vector = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {

        timer += 1.0f/60.0f;

        if (timer < 0.1)
        {
            transform.localScale += new Vector3(0.0002f, 0.0002f, 0.0002f);
        }
        else if (timer >0.1 && timer <0.2)
        {
            transform.localScale -= new Vector3(0.0002f, 0.0002f, 0.0002f);
            
        }

        if(transform.localScale.x <= vector.x)
        {
            timer = 0;
        }

    }
}
