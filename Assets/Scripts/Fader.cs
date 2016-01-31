using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {

    public GameObject Sprite;///the sprite (most of the time most of the people use plane for sprite)
    public float fadespeed = 2;
    public GUITexture Spriteb;//if u are using this for sprite

    void Update()
    {
        //if hit with particles
        if (Sprite)
        {
            Renderer rend = Sprite.GetComponent<Renderer>();
            float tmp = Mathf.Lerp(rend.material.color.a, 0, Time.deltaTime * fadespeed);
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, tmp);

            if (rend.material.color.a <= 0.3f)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 1);
                FadeIn();
            }
        }
        /*if (Spriteb)
        {
            Spriteb.color.a = Mathf.Lerp(Spriteb.color.a, 0, Time.deltaTime * fadespeed);
            if (Spriteb.color.a == 0)
            {
                FadeIn();
            }
        }*/
    }

    IEnumerator FadeIn()
    {

        /*if (Spriteb)
        {
            Spriteb.color.a = Mathf.Lerp(Spriteb.color.a, 1, Time.deltaTime * fadespeed);
        }*/
        //if hit with particles
        if (Sprite)
        {
            Renderer rend = Sprite.GetComponent<Renderer>();
            float tmp = Mathf.Lerp(rend.material.color.a, 1, Time.deltaTime * fadespeed);
            Sprite.GetComponent<Renderer>().material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, tmp);
        }
        yield return new WaitForSeconds(0.02f);
    }
}
