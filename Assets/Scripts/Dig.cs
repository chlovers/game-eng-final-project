using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dig : MonoBehaviour
{
    bool skullpickedup;
    bool playernear;

    public GameObject skeleton; 
    public GameObject dirt;
    public GameObject Rod;
    public GameObject old1;
    public GameObject old2;
    public GameObject dirttext;
    public GameObject skullinv;


    private void Start()
    {
        skullpickedup = false;
        playernear = false;
        Rod.SetActive(false);
        old2.SetActive(false);
        old1.SetActive(true);
        skullinv.SetActive(false);

        
    }

    private void Update()
    {
        if (!skeleton.activeSelf && !Rod.activeSelf)
        {
            skullpickedup = true;
            skullinv.SetActive(true);
           
        }
        if (playernear && skullpickedup && Input.GetKeyDown(KeyCode.Space))
        {
            dirt.SetActive(false);
            Rod.SetActive(true);
            old1.SetActive(false);
            old2.SetActive(true);
            Destroy(dirttext);
            skullinv.SetActive(false);
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
