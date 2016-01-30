using UnityEngine;
using System.Collections;

public class PrintMessageOnClick : MonoBehaviour
{
    private bool isTrigger;
    public TextMesh text;
    public AudioSource alarmClockBeep;
    public GameObject johnSleeping;
    public GameObject johnSitting;
    public AudioSource snore;
    public GameObject triggerWardrobe;
    public TextMesh getDress;

	// Use this for initialization
	void Start ()
    {
        isTrigger = false;
        alarmClockBeep.Stop();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && !isTrigger)
        {
            isTrigger = true;
            StartCoroutine(AnimateText("Wake up, John"));
        }
    }

    IEnumerator AnimateText(string strComplete)
    {
        int i = 0;
        text.text = "";
        while (i < 7)
        {
            text.text += strComplete[i++];
            yield return new WaitForSeconds(0.1F);
        }

        yield return new WaitForSeconds(0.7f);

        while (i < strComplete.Length)
        {
            text.text += strComplete[i++];
            yield return new WaitForSeconds(0.2F);
        }
        yield return new WaitForSeconds(1);
        text.text = "";

        johnSleeping.SetActive(false);

        yield return new WaitForSeconds(0.2f);

        johnSitting.SetActive(true);
        snore.Play();

        triggerWardrobe.SetActive(true);

        getDress.text = "Get dress, John";

    }

    /*void OnTriggerEnter2D(Collider2D other)
    {
        isInTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isInTrigger = false;
    }*/

    private bool clickOnObj()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit;
        hit = Physics2D.Raycast(new Vector2(ray.origin.x, ray.origin.y), new Vector2(0, 0));
        if (hit.collider != null)
            if (hit.collider.name == GetComponent<Collider2D>().name)
                return true;
        return false;
    }
}
