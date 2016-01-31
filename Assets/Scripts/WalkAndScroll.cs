using UnityEngine;
using System.Collections;

public class WalkAndScroll : MonoBehaviour
{

    public float speed = 3.0f;
    public Animator anim = null;
    private Vector3 lastClick;
    public GameObject player;
    public float dist = 5f;
    public float startX = -12f;
    private bool move = false;
    private bool scroll = false;
    // Use this for initialization
    void Start()
    {
        lastClick = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            lastClick.x = Camera.main.ScreenPointToRay(Input.mousePosition).origin.x;
        if (player.transform.position.x > startX + dist && transform.position.x > -15f && player.transform.position.x < lastClick.x)
        {
            transform.position = new Vector3(transform.position.x - speed *  Time.deltaTime, transform.position.y, transform.position.z);
            lastClick.x -= speed *  Time.deltaTime;
            if (lastClick.x < player.transform.position.x)
                lastClick.x = player.transform.position.x;
        }
        else if (player.transform.position.x < startX - dist && transform.position.x < 40f && player.transform.position.x > lastClick.x)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            lastClick.x += speed * Time.deltaTime;
            if (lastClick.x > player.transform.position.x)
                lastClick.x = player.transform.position.x;
        }
        else
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, lastClick, speed * Time.deltaTime);
        }
        if (anim != null)
            if (player.transform.position.x != lastClick.x)
                anim.SetInteger("Anim", 0);
            else
                anim.SetInteger("Anim", 1);
        if (lastClick.x < player.transform.position.x)
            player.transform.rotation = new Quaternion(0, 180, 0, 1);
        if (lastClick.x > player.transform.position.x)
            player.transform.rotation = new Quaternion(0, 0, 0, 1);
    }
}