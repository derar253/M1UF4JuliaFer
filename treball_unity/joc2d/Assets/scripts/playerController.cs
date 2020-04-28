using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    float speed;
    public float speedX;
    public float speedY;
   

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
       
 
        //moviment jugador
        MovePlayer(speed);



        if (Input.GetKeyDown(KeyCode.J)) {
            speed = -speedX;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            speed = 0;
        }


        if (Input.GetKeyDown(KeyCode.L))
        {
            speed = speedX;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            speed = 0;
        }

        if (Input.GetKeyDown(KeyCode.I)) {
            rb.AddForce(new Vector2(rb.velocity.x, speedY));
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetInteger("status", 1);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            anim.SetInteger("status", 0);
        }


        if (Input.GetKeyDown(KeyCode.L))
        {
            anim.SetInteger("status", 0);
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            anim.SetInteger("status", 0);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetInteger("status", 2);
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            anim.SetInteger("status", 0);
        }



    }
    void MovePlayer(float playerSpeed){
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Terra") {
            anim.SetInteger("status", 0);
        }
    }
}
