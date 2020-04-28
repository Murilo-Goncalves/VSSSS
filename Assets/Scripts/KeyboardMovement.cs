using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public Rigidbody player;

    public float force = 2000f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            player.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
    
        if (Input.GetKey("s"))
        {
            player.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            player.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
   
        if (Input.GetKey("d"))
        {
            player.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}

