using UnityEngine;
using System.Collections;

public class ScrollDown : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.y > -16)
			transform.position = new Vector3(transform.position.x, transform.position.y-0.65f, transform.position.z);
	}
}
