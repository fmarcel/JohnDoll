using UnityEngine;
using System.Collections;

public class IntroBedroom : MonoBehaviour
{
    public TextMesh text;
    public GameObject alarmClock;
    public GameObject alarmClock5h59;
    public GameObject alarmClock6h00;
    public AudioSource alarmClockBeep;
    public GameObject alarmTrigger;
    public GameObject alarmPointerEvent;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(DisplayText("Here's John at the beginning of a day, like any other."));
    }
	
	// Update is called once per frame
	IEnumerator DisplayText(string str)
    {
        yield return new WaitForSeconds(3.0f);
        text.text  = str;
        yield return new WaitForSeconds(2.0f);

        for (float a = 1.0f; a > 0; a-=0.005f)
        {
            GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, a);
            yield return new WaitForSeconds(0.02f);
        }

        yield return new WaitForSeconds(2.0f);
        text.text = "";
        yield return new WaitForSeconds(5.0f);
        alarmClock5h59.SetActive(false);
        alarmClock6h00.SetActive(true);
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
            alarmPointerEvent.SetActive(true);
        else
            alarmTrigger.SetActive(true);
        alarmClockBeep.Play();

    }
}
