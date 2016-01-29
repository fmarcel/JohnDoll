using UnityEngine;
using System.Collections;

public class MoveCloud : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3(transform.position.x, transform.position.y+0.03f, transform.position.z);
	}
}
