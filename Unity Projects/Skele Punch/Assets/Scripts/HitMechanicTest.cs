using UnityEngine;

public class HitMechanicTest : MonoBehaviour
{
    public Collider m_collider;
    public GameObject m_skele;
    public float speed = 10f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject instSkele = Instantiate(m_skele, transform.position, Quaternion.identity);
            Rigidbody instSkeleRB = instSkele.GetComponent<Rigidbody>();

            instSkeleRB.AddForce(gameObject.transform.forward * speed);
            Destroy(instSkele, 3f);
        }
    }
}
