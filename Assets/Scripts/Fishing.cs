using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    bool fishingrod;
    bool ladderpickedup;
    bool playernear;
    public GameObject rod;
    public GameObject ladder;
    public GameObject fishtext;
    

    private void Start()
    {
        fishingrod = false;
        ladderpickedup = false;
        ladder.SetActive(false);
    }


    private void Update()
    {
        if (rod.activeSelf)
        { 
        fishingrod = true;
         Destroy(fishtext);
        
        }

        if (ladder.activeSelf)
        { 
        ladderpickedup=true;
        
        }

        if (fishingrod && !ladderpickedup && playernear && Input.GetKeyDown(KeyCode.Space))
        {
            ladder.SetActive(true);
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
