using UnityEngine;
using System.Collections;

public class ScrollDown : MonoBehaviour 
{
    public float speed = 0.05f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.y > -16)
			transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
	}
}
