using UnityEngine;
using System.Collections;

public class stop_move_ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(transform.position.x);
        if (transform.position.x < -38.0f)
        {
            if (o.gameObject.name == "train")
            {
                GameObject go = GameObject.Find("train");
                go.GetComponent<ScrollingScript>().lim_speed(0.0f);
            }
    }
}
