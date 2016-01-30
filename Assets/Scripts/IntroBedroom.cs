using UnityEngine;
using System.Collections;

public class IntroBedroom : MonoBehaviour
{
    public TextMesh text;
    public GameObject alarmClock;
    public GameObject alarmClock5h59;
    public GameObject alarmClock6h00;
    public AudioSource alarmClockBeep;

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
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(2.0f);
        text.text = "";
        yield return new WaitForSeconds(5.0f);
        alarmClock5h59.SetActive(false);
        alarmClock6h00.SetActive(true);
        alarmClockBeep.Play();

    }
}
