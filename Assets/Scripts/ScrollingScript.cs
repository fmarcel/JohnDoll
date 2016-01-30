using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScrollingScript : MonoBehaviour
{

    public float modX = 0.0f;
    public Vector2 speed = new Vector2(2, 2);
    public Vector2 direction = new Vector2(-1, 0);
    public bool isLinkedToCamera = false;
    public bool isLooping = false;
    private List<Transform> backgroundPart;
    private bool firstSee = false;
    // Use this for initialization
    void Start()
    {
        if (isLooping)
        {
            backgroundPart = new List<Transform>();
            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                Renderer rend = child.GetComponent<Renderer>();
                if (rend != null)
                    backgroundPart.Add(child);
            }
            backgroundPart = backgroundPart.OrderBy(t => t.position.x).ToList();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (firstSee == false)
        {
            if (backgroundPart.FirstOrDefault().GetComponent<Renderer>().IsVisibleFrom(Camera.main) == true)
                firstSee = true;
        }
        else
        {
            Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
            movement *= Time.deltaTime;
            transform.Translate(movement);
            if (isLinkedToCamera)
                Camera.main.transform.Translate(movement);
            if (isLooping)
            {
                Transform firstChild = backgroundPart.FirstOrDefault();
                if (firstChild != null)
                {
                    if (firstChild.position.x < Camera.main.transform.position.x)
                    {
                        Renderer rend = firstChild.GetComponent<Renderer>();
                        if (rend.IsVisibleFrom(Camera.main) == false)
                        {
                            Transform lastChild = backgroundPart.LastOrDefault();
                            Vector3 lastPosition = lastChild.transform.position;
                            Vector3 lastSize = (lastChild.GetComponent<Renderer>().bounds.max -
                                                lastChild.GetComponent<Renderer>().bounds.min);
                            firstChild.position = new Vector3(lastPosition.x + lastSize.x - modX, firstChild.position.y, firstChild.position.z);
                            backgroundPart.Remove(firstChild);
                            backgroundPart.Add(firstChild);
                        }
                    }
                }
            }
        }
    }
}