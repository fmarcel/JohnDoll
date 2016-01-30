using UnityEngine;
using System.Collections;

public class GettingDressed : MonoBehaviour
{
    bool isTrigger;
    public AudioSource getUp;
    public GameObject standingJohn;
    public GameObject sittingJohn;
    public GameObject openWardrobe;
    public GameObject popupWardrobe;
    public TextMesh textClothes;
    public AudioSource getCloth;
    public GameObject johnDressed;
    public GameObject getDressedOrder;

	// Use this for initialization
	void Start ()
    {
        isTrigger = false;
        //StartCoroutine(DisplayText("Here's John at the beginning of a day, like any other."));
    }
	
	// Update is called once per frame
	void Update ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit) && hit.transform.gameObject.CompareTag(tag) && !isTrigger)
        {
            isTrigger = true;
            StartCoroutine(GetDressed("You're not really the original kind, aren't you ?"));
        }
        //hit.transform.gameObject.CompareTag(tag)
    }

    IEnumerator GetDressed(string strComplete)
    {
        getDressedOrder.SetActive(false);
        sittingJohn.SetActive(false);
        getUp.Play();
        yield return new WaitForSeconds(2.0f);
        standingJohn.SetActive(true);
        openWardrobe.SetActive(true);
        getCloth.Play();
        yield return new WaitForSeconds(2.0f);
        popupWardrobe.SetActive(true);
        textClothes.text = strComplete;
        yield return new WaitForSeconds(5.0f);
        getCloth.Play();
        textClothes.text = "";
        popupWardrobe.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        standingJohn.SetActive(false);
        openWardrobe.SetActive(false);
        johnDressed.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        
    }
}
