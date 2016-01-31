using UnityEngine;
using System.Collections;

public class MoveScriptOnClick : MonoBehaviour {

    public float speed = 3.0f;
    public Animator anim = null;
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
        if (anim != null)
            if (transform.position.x != lastClick.x)
             anim.SetInteger("Anim", 0);
            else
             anim.SetInteger("Anim", 1);
        if (lastClick.x < transform.position.x)
            transform.rotation = new Quaternion(0, 180, 0, 1);
        if (lastClick.x > transform.position.x)
            transform.rotation = new Quaternion(0, 0, 0, 1);
    }
}
