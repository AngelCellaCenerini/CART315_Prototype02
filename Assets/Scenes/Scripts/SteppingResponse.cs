using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteppingResponse : MonoBehaviour
{
    public GameObject player;
    public GameObject eye1;
    public GameObject eye2;
    public GameObject lightEyes;
    public GameObject warning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            eye1.SetActive(true);
            eye2.SetActive(true);
            lightEyes.SetActive(true);
            warning.SetActive(true);
        }
    }
}
