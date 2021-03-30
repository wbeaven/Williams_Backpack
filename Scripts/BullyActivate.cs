using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullyActivate : MonoBehaviour
{
    public GameObject bully;
    public Animator anim;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("Activate", true);
            CrowdCount.Instance.confrontBully = true;
            player.GetComponent<LookAtMouse>().enabled = false;
            player.GetComponent<MoveToMouse>().enabled = false;
        }
    }
}
