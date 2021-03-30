using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCFollow : MonoBehaviour
{
    //Transform that NPC has to follow
    public Transform transformToFollow;
    //NavMesh Agent variable
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //Follow the player
        agent.destination = transformToFollow.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<NavMeshAgent>().enabled = true;
            CrowdCount.Instance.people += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<SphereCollider>().enabled = false;
    }
}

