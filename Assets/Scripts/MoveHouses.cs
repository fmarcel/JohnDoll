using UnityEngine;
using System.Collections;

public class MoveHouses : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(transform.position.x+0.008f, transform.position.y, transform.position.z);
	}
}
