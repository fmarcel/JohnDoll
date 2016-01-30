using UnityEngine;
using System.Collections;

public class DisplayEventPointer : MonoBehaviour
{
    public GameObject eventPointer;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.CompareTag(tag) && !eventPointer.activeSelf)
        {
            eventPointer.SetActive(true);
        }
        //else if (!Physics.Raycast(ray, out hit))
        //    eventPointer.SetActive(false);
    }
}
