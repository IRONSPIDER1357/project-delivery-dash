using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPacket;
    [SerializeField] float destroyDelay = 1f; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Packet") && !hasPacket)
        {
            Debug.Log("Packet picked up!");
            hasPacket = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, destroyDelay);
        }

        if(collision.CompareTag("Customer") && hasPacket)
        {
            Debug.Log("Packet Delivered");
            GetComponent<ParticleSystem>().Stop();
            hasPacket = false;
        }
    }
}
