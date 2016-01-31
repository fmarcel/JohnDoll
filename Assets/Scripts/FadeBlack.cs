using UnityEngine;
using System.Collections;

public class FadeBlack : MonoBehaviour {

    public float speed = 0.01f;
    private float alpha = 1f;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (alpha >= 0)
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, alpha);
            alpha = alpha - speed * Time.deltaTime;
        }
	}
}
