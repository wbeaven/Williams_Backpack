using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCAmount : MonoBehaviour
{
    public Text crowdNumber;

    void Update()
    {
        crowdNumber.text = "Happy people: " + CrowdCount.Instance.people;
    }
}