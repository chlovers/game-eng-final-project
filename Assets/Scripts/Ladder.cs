using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    bool ladderhave;
    public GameObject ladder;
    public GameObject block;
    public GameObject lighttext;
    bool playernear;
    

   
    void Start()
    {
        block.SetActive(true);
        ladderhave = false;

    }

   
    void Update()
    {
        if (ladder.activeSelf)
        { 
        ladderhave = true;
            lighttext.SetActive(false);
        }

        if (ladderhave && playernear && Input.GetKeyDown(KeyCode.Space))
        {
            ladder.SetActive(false);
            ladderhave = false ;
            block.SetActive(false);
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
