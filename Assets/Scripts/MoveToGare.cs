using UnityEngine;
using System.Collections;

public class MoveToGare : MonoBehaviour {

    private float alpha = 0f;
    public float fadeSpeed = 0.2f;
    public GameObject sprite;
    private bool next = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit;
            hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), new Vector2(0, 0));
            if (hit.collider != null)
                if (hit.collider == GetComponent<Collider2D>())
                {
                    next = true;
                }
        }
        if (next)
        {
            sprite.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha);
            alpha += fadeSpeed * Time.deltaTime;
        }
        if (next && alpha >= 1f)
            Application.LoadLevel("metro");
    }
}
