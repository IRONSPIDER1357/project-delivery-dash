using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Packet"))
        {
            Debug.Log("Packet picked up!");
        }

        if(collision.CompareTag("Customer"))
        {
            Debug.Log("Packet Delivered");
        }
    }
}
