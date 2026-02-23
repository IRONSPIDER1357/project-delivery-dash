using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float currentSpeed = 12f;
    [SerializeField] float steerSpeed = 225f;
    [SerializeField] float boostSpeed = 20f;
    [SerializeField] float regularSpeed = 12f;
  
    void Update()
    {
        float move = 0f;
        float steer = 0f;

        //moves my car forward and backward
        if(Keyboard.current.wKey.isPressed)
        {
            move = 1f;
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
        
        //steers my car left and right
        if(Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1f;
        }

        float moveAmount = move * currentSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0f, moveAmount, 0f);
        transform.Rotate(0f, 0f, steerAmount);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("Boost"))
        {
            currentSpeed = boostSpeed;
            Destroy(collision.gameObject, 0.3f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentSpeed = regularSpeed;
    }
}
