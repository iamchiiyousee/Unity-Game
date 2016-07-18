using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public float jump;
    private int count;
    public Text countText;
    public Text winText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
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

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Targets gathered:" + count.ToString();
        if (count >= 6)
        {
            winText.text = "Level 1 Complete! Proceed to next level";
        }
        if (count >= 12)
        {
            winText.text = "Level 2 Complete! Proceed to next level";
        }
        if (count >= 18)
        {
            winText.text = "!!!You Win!!!";
        }
    }
}
