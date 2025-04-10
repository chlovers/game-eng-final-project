using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour
{
    private bool hasbarrel;
    private bool waterfilled;
    bool playernear;
    public GameObject Barrelinv;
    public GameObject Barrelout;
    public GameObject Barrelwater;
    public GameObject Barrelwatertext;



    void Start()
    {
        hasbarrel = false;
        waterfilled = false;
        Barrelinv.SetActive(false);
        Barrelwater.SetActive(false);
    }


    void Update()
    {
        if (!Barrelout.activeSelf && !waterfilled)
        { 
        Barrelinv.SetActive (true);
        hasbarrel = true;  
         Barrelwatertext.SetActive (false);
        }

        if (hasbarrel && !waterfilled && Input.GetKeyDown(KeyCode.Space) && playernear)
        {
            waterfilled = true;
            Barrelwater.SetActive (true);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playernear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playernear = false;
        }
    }
}
