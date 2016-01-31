using UnityEngine;
using System.Collections;

public class TextStreet : MonoBehaviour {

    public TextMesh text1;
    public TextMesh text2;
    public TextMesh text3;
    public TextMesh text4;
    private float startTime;
    private float actTime;
	// Use this for initialization
	void Start () {
        startTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
        actTime = Time.realtimeSinceStartup - startTime;
        if (actTime >= 1)
            text1.text = "Go to work, John";
        if (actTime >= 4)
            text2.text = "You have to be on time, John";
        if (actTime >= 7)
            text3.text = "The sameness of his neighborhood makes him feel well...";
        if (actTime >= 10)
            text4.text = "Does it ?";

    }
}
