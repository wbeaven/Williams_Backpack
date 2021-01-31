using UnityEngine;

public class SkeleSpawn : MonoBehaviour
{
    public GameObject foam;
    public float speed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject instFoam = Instantiate(foam, transform.position, Quaternion.identity);
            Rigidbody instFoamRB = instFoam.GetComponent<Rigidbody>();

            instFoamRB.AddForce(gameObject.transform.forward * speed);
            Destroy(instFoam, 3f);
        }
    }
}
