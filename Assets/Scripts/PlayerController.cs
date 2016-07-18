using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float jump;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
         /*float moveSideways = Input.GetAxis("Horizontal");
         float moveFrontBack = Input.GetAxis("Vertical");
       

         Vector3 force = new Vector3(moveSideways, 0, moveFrontBack);
        //Vector3 up = transform.TransformDirection(Vector3.up);

        rb.AddForce(force * speed);*/

        //Forward Movement
       if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0 , speed));
        }
        //Backward Movement
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -speed));
        }
        //Leftward Movement
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-speed , 0, 0));
        }
        //Rightward Movement
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        //Jump
        if (Input.GetKey("space"))
        {

            rb.AddForce(new Vector3(0,jump,0));
        }
    }
}
