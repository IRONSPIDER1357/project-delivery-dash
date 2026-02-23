using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPacket;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Packet") && hasPacket == false)
        {
            Debug.Log("Packet picked up!");
            hasPacket = true;
        }

        if(collision.CompareTag("Customer") && hasPacket)
        {
            Debug.Log("Packet Delivered");
            hasPacket = false;
        }
    }
}
