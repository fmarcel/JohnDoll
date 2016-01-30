using UnityEngine;
using System.Collections;

public class Metro_move_foregroung : MonoBehaviour {

    private int count;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (count == 0)
        {
            transform.position = new Vector3(transform.position.x + 0.05f, transform.position.y, transform.position.z);
            count = 1;
        }
        else
        {
            transform.position = new Vector3(transform.position.x - 0.05f, transform.position.y, transform.position.z);
            count = 0;
        }
    }
}
