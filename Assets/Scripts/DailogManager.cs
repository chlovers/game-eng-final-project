using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DailogManager : MonoBehaviour
{


    private Queue<string> dailogue;

    public TextMeshProUGUI textMesh;

    public GameObject dUI;

    // Start is called before the first frame update
    void Start()
    {
        dailogue = new Queue<string>();
        dUI.SetActive(false);

    }

    public void startdailogue(string[] sentences)
    {
        foreach(string currstring in sentences)
        {
            dailogue.Enqueue(currstring);
        }
      
        dUI.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        continunedial();

    }

    public void continunedial()
    {
        if (dailogue.Count == 0)
        {
            stopdial();
            return;
        }
        else if (dailogue.Count > 0)
        {
            string sentence = dailogue.Dequeue();
            textMesh.text = sentence;

        }

    }

    public void buttonfordial()
    {

        continunedial();    
    
    }


    public void stopdial()
    {
    
    dailogue.Clear();
        dUI.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;

    }



}
