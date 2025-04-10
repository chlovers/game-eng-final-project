using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameovertext : MonoBehaviour
{
    bool playernear;
    public GameObject gameoverscreen;
    
    // Start is called before the first frame update
    void Start()
    {
        gameoverscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playernear && Input.GetKeyDown(KeyCode.Space)) 
        {
        gameoverscreen.SetActive(true);
            Cursor.visible = true;
           
        
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
