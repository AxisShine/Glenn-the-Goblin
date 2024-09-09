using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public GameObject txtToDisplay;

    private bool PlayerInZone;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone = false;
        txtToDisplay.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.F)) // or press x or y 
        {

            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
            if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }
}
