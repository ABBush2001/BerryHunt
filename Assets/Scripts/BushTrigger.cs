using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BushTrigger : MonoBehaviour
{
    [Tooltip("The image behind the pop up text")]
    public Image txBg;
    [Tooltip("The press E popup text")]
    public TextMeshProUGUI pressE;

    private void Start()
    {
        txBg.gameObject.SetActive(false);
        pressE.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Stepped in it");
        if (other.tag == "Player")
        {
            txBg.gameObject.SetActive(true);
            pressE.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Stepped out");
        if (other.tag == "Player")
        {
            txBg.gameObject.SetActive(false);
            pressE.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("Staying");
    }
}
