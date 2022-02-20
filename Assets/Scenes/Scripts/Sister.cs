using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sister : MonoBehaviour
{
    // code source: https://youtu.be/UvDqnbjEEak
    public NavMeshAgent sister;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {
    }

    void FixedUpdate()
    {
        sister.SetDestination(Player.position);
    }

}