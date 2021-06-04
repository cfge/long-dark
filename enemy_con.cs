using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy_con : MonoBehaviour
{
     public NavMeshAgent nav;
    public Transform player_tr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player_tr.position);
    }
}
