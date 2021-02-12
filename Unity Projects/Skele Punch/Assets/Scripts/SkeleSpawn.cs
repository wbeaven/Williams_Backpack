using UnityEngine;

public class SkeleSpawn : MonoBehaviour
{
    public GameObject m_skele;
    public float m_speed = 10f;
    public float m_despawnTime = 3f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instSkele = Instantiate(m_skele, transform.position, Quaternion.identity);
            Rigidbody instSkeleRB = instSkele.GetComponent<Rigidbody>();

            instSkeleRB.AddForce(gameObject.transform.forward * m_speed);
            Destroy(instSkele, m_despawnTime);
        }
    }
}
