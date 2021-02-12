using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeleFloat : MonoBehaviour
{
    public Rigidbody m_skele;
    public float m_speed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
            m_skele.AddForce(m_skele.transform.up * m_speed);
    }
}
