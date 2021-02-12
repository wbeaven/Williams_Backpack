using UnityEngine;

public class HitTrigger : MonoBehaviour
{
    public GameObject m_fist;

    void ActivateFist()
    {
        //if (Input.GetKey(KeyCode.Mouse0)
        {
            GameObject m_fist1 = m_fist;
            m_fist1.SetActive(true);
        }
    }
}
