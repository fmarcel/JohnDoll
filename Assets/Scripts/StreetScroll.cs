using UnityEngine;
using System.Collections;

public class StreetScroll : MonoBehaviour {

    public GameObject player;
    public float dist = 5f;
    public float speed = 0.2f;
    public float startX = -12f;
    private Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x > startX + dist && transform.position.x > -27f)
        {
            if (player.transform.position.x > startX + dist * 2)
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            transform.position = new Vector3(transform.position.x - speed * 10 * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (player.transform.position.x < startX - dist && transform.position.x < 28f)
        {
            transform.position = new Vector3(transform.position.x + dist * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }
}
