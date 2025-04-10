using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactionobject : MonoBehaviour
{
    public GameManager gameManager;
    
    
    public GameObject signtxt;


    public enum Interactions
    {
        Pickup_interact,
        Info_interact,
        talking
    }

    public Interactions interact;

    private void Start()
    {
        signtxt.SetActive(false);
    }

    private DailogManager dailogManager;

    [TextArea] public string[] sentences;

    private void Awake()
    {
        dailogManager = GetComponent<DailogManager>();
    }

    public void inter()
    {
       
        Debug.Log("found the" + gameObject.name);

        switch (interact)
        {
            case Interactions.Pickup_interact:
                Pickup();
                    break;

            case Interactions.Info_interact:
                Info();
                    break;

            case Interactions.talking:
                dailog();
                break;

        }


    }

    public void Pickup()
    {
        Debug.Log("hey we picking this up?");
        gameObject.SetActive(false);

    }

    public void Info()
    {

        Debug.Log("hi you are reading a sign!");
        signtxt.SetActive(true);
        StartCoroutine(fadeout());
        
    }

    public void dailog()
    {
        dailogManager.startdailogue(sentences);
       // gameManager.gameState.dailoguestart();


    }
     
    IEnumerator fadeout()
    {
        yield return new WaitForSeconds(1.5f);
        signtxt.SetActive(false);
    }

    IEnumerator Fadein()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
