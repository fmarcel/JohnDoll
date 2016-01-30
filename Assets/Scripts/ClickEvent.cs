using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour
{
    public Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                anim.SetBool("clicked", true);
                GetComponent<AudioSource>().Play();
            }
        }
        if (Input.GetMouseButtonUp(0))
            anim.SetBool("clicked", false);
    }
}
