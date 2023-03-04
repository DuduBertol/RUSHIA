using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float inicialSpeed;
    public float speed;
    public float jumpForce;
    public int jumpTimes;
    public bool isCrouching;
    public bool berlinWall;
    public bool russianWinter;


    public Sprite sprite1;
    public Sprite sprite2;

    private Rigidbody2D rig;
    private BoxCollider2D boxCollider;
    private SpriteRenderer spriteRenderer;

    private void Start() 
    {
        inicialSpeed = speed;
        rig = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void FixedUpdate() 
    {
        rig.velocity = new Vector2(speed, rig.velocity.y);   
    }

    public void Jump()
    {
        if(jumpTimes == 1)
        {
            rig.velocity = Vector2.up * jumpForce;
            jumpTimes = 0;
        }
    }

    public void Crouch()
    {
        isCrouching = !isCrouching;
        if(isCrouching)
        {
            boxCollider.offset = new Vector2(0, -0.25f);
            boxCollider.size = new Vector2(1, 0.5f);
            spriteRenderer.sprite = sprite2;
        }
        if(!isCrouching)
        {
            boxCollider.offset = new Vector2(0, 0);
            boxCollider.size = new Vector2(1, 1);
            spriteRenderer.sprite = sprite1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            jumpTimes = 1;
        }

        if(collision.gameObject.CompareTag("BerlinWall"))
        {
            berlinWall = true;
        }    
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.CompareTag("RussianWinter"))
        {
            russianWinter = true;
        }   
    }
}
