using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vents : MonoBehaviour
{
    public GameObject txtToDisplay1;

    private bool PlayerInZone1;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInZone1 = false;
        txtToDisplay1.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (PlayerInZone1 && Input.GetKeyDown(KeyCode.F)) // or press x or y 
        {

            gameObject.GetComponent<AudioSource>().Play();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            txtToDisplay1.SetActive(true);
            PlayerInZone1 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
            if (other.gameObject.tag == "Player")
        {
            PlayerInZone1 = false;
            txtToDisplay1.SetActive(false);
        }
    }
}
