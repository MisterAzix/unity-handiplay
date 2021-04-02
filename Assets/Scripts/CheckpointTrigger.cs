using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public GameObject m_nextCheckpoint;
    public AudioClip m_triggerSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            if (m_nextCheckpoint != null)
            {
                m_nextCheckpoint.SetActive(true);
            }
            if (m_triggerSound != null)
            {
                AudioManager.instance.PlaySound(m_triggerSound);
            }
        }
    }
}
