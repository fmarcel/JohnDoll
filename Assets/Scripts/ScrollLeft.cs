using UnityEngine;
using System.Collections;

public class ScrollLeft : MonoBehaviour {

    public float speed = 2.0f;
    public float stop = -13.0f;
    public float zoom = 0.2f;
    public float zoomStop = 1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x >= stop)
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        else if (Camera.main.orthographicSize > zoomStop)
            Camera.main.orthographicSize -= zoom * Time.deltaTime;
	}
}
