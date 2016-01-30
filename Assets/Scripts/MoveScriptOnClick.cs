using UnityEngine;
using System.Collections;

public class MoveScriptOnClick : MonoBehaviour {

    public float speed = 3.0f;
    private Vector3 lastClick;
	// Use this for initialization
	void Start () {
        lastClick = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
            lastClick.x = Camera.main.ScreenPointToRay(Input.mousePosition).origin.x;
        transform.position = Vector3.MoveTowards(transform.position, lastClick, speed * Time.deltaTime);
	}
}
