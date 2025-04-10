using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject axeout;
    public GameObject axeinv;
    public GameObject barrelwater;
    public GameObject old;
    public GameObject old2;
    public GameObject gatetext;
    public GameObject gameover;
   
    bool playernear;
    
    
    // Start is called before the first frame update
    void Start()
    {
        axeinv.SetActive(false);
        old2.SetActive(false);
        gatetext.SetActive(true);
        gameover.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (!axeout.activeSelf)
        {
            axeinv.SetActive (true);

        }

        if (barrelwater.activeSelf && axeinv.activeSelf && playernear && Input.GetKeyDown(KeyCode.Space))
        {
            old.SetActive (false);
            old2.SetActive (true);
            gatetext.SetActive (false);
            

        }

        if (!gatetext.activeSelf && playernear && Input.GetKeyDown(KeyCode.Space))
        {
            gameover.SetActive (true);
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

    public void Quitbutton()
    {
        Application.Quit();

    }
}
