using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
            Debug.Log("You crushed");
    }
}
