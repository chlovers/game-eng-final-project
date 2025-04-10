using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakablewall : MonoBehaviour
{

    bool hammerpickedup;

    public GameObject hammer;
    public GameObject Wall;
    public GameObject hammerinv;

    private void Start()
    {
        hammerpickedup = false;
        hammerinv.SetActive(false);
    }

    public float breakDistance = 3f;
    public Transform player;

    private void Update()
    {
        if (!hammer.activeSelf)
        {
            hammerpickedup = true;
            hammerinv.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Wall != null && hammerpickedup)
        {
            float distance = Vector3.Distance(player.position, Wall.transform.position);
            if (distance <= breakDistance)
            {
                Destroy(Wall);
                hammerinv.SetActive(false);
            }
        }
    }

}
