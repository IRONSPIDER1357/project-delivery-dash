using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.02f;
    [SerializeField] float steerSpeed = 0.5f;
  
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

        float moveAmount = move * moveSpeed * Time.deltaTime;
        float steerAmount = steer * steerSpeed * Time.deltaTime;

        transform.Translate(0f, moveAmount, 0f);
        transform.Rotate(0f, 0f, steerAmount);
    }
}
