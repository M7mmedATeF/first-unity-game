using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player1;
    public Rigidbody2D ground;
    public Animator animator;
    private int speed = 400;
    private int jumpforce = 9;
    private float x_input;
    private bool isjumping;

    private void FixedUpdate()
    {

        x_input = Input.GetAxisRaw("Horizontal");
        player1.velocity = new Vector2(x_input * speed * Time.deltaTime, player1.velocity.y);


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isjumping==false)
        {
            player1.velocity = Vector2.up * jumpforce;
            isjumping = true;
           
            animator.SetBool("jump", true);
        }
        else animator.SetBool("jump", false);


        if (Input.GetKeyUp(KeyCode.W))
        {
            isjumping = false;
          
        }


        if(player1.position.y > 0){
            isjumping = true;
        }


        if (Input.GetKey(KeyCode.D))
        {

            transform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("run", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {

            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
        else animator.SetBool("run", false);




    }

}
/*
    1.5362025
*/