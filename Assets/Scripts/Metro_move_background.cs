using UnityEngine;
using System.Collections;

public class Metro_move_background : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        if (transform.position.x < -70.0f)
        {
         transform.position = new Vector3(transform.position.x + 70.0f, transform.position.y, transform.position.z);
        }
    }
}
