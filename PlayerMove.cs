using UnityEngine;

public class PlayerMove : MonoBehaviour{


public Rigidbody rb;

// this is used to make it easy to change the force of an object
public float forwardForce = 2000f;
public float sidewaysForce = 500f;
public float upforce = 200f;

    // FixedUpdate wordt gebruikt voor de physics in unity
    void FixedUpdate ()
    {
         rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // met deze code voegen we 2000 force toen aan de z-axis

         // this code is executed when the key "d" is pressed
         if (Input.GetKey("d"))
         {
              rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }

        // this code is executed when the key "a" is pressed
         if (Input.GetKey("a"))
         {
              rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         }

         if (Input.GetKey("space"))
         {
              rb.AddForce( -upforce * Time.deltaTime,0 , 0, ForceMode.VelocityChange);
         }
    }
}
