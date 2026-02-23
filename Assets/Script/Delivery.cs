using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPacket;
    [SerializeField] float destroyDelay = 1f; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Dectect if player has packet or not and if not, packet is picked up and destoryed from the world
        if(collision.CompareTag("Packet") && !hasPacket)
        {
            Debug.Log("Packet picked up!");
            hasPacket = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, destroyDelay);
        }

        //delivers the packet and set the hasPacket value back to false
        if(collision.CompareTag("Customer") && hasPacket)
        {
            Debug.Log("Packet Delivered");
            GetComponent<ParticleSystem>().Stop();
            hasPacket = false;
        }
    }
}
