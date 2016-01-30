using UnityEngine;
using System.Collections;

public class PrintMessageOnClick : MonoBehaviour {

    public string JohnName = "perso";
    private bool isInTrigger;
	// Use this for initialization
	void Start () {
        isInTrigger = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && isInTrigger && clickOnObj())
        {
            print("hey");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        isInTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isInTrigger = false;
    }

    private bool clickOnObj()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit;
        hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), new Vector2(0, 0));
        if (hit.collider != null)
            if (hit.collider.name == GetComponent<Collider2D>().name || hit.collider.name == JohnName)
                return true;
        return false;
    }
}
