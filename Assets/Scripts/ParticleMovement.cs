using UnityEngine;
using System.Collections;

public class ParticleMovement : MonoBehaviour
{
    public float particleMovement = 0.02f;
    private float initialX;
    private float initialY;

    // Use this for initialization
    void Start ()
    {
        initialX = transform.position.x;
        initialY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Mathf.Abs(transform.position.x - initialX) > 0.2)
            particleMovement = -particleMovement;
        transform.position = new Vector3(transform.position.x + particleMovement, transform.position.y + particleMovement, transform.position.z);
    }
}
