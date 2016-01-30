using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit;
            hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), new Vector2(0, 0));
            if (hit.collider != null)
                if (hit.collider == GetComponent<Collider2D>())
                    Application.LoadLevel("bedroom");
		}
	}
}
