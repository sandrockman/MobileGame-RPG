using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    //rigidbody for the player
    private Rigidbody2D playerRigidbody2D;

    //determine the player facing
    private bool facingRight;

    //modifier for player movement
    public float speed = 4.0f;

    //Get Animator
    private Animator anim;

    //use this for initialization
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    //update is called once per frame
    void Update()
    {
        //cache the horz. input
        float movementPlayerVector = Input.GetAxis("Horizontal");

        //Apply velocity as appropriate to the x axis
        playerRigidbody2D.velocity = new Vector2(movementPlayerVector * speed, playerRigidbody2D.velocity.y);

        //Update speed float on animator, setting it to the abs. value of our movement vector
        anim.SetFloat("Speed", Mathf.Abs(movementPlayerVector));

        if (movementPlayerVector > 0 && !facingRight)
            Flip();
        else if (movementPlayerVector < 0 && facingRight)
            Flip();

    }

    void Flip()
    {
        //Switch the player bool using a toggle
        facingRight = !facingRight;

        //multiply local x to get a quick and dirty flip
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;

    }
}
