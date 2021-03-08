using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luffy : MonoBehaviour

{
    public Over Over;
    Rigidbody2D player;
    public float maxSpeed;

    bool flipLeft = true;
    SpriteRenderer flipPlayer;
    bool jump = true;
    bool floor = false;
    float checkFloor = 0.2f;
    public LayerMask floorLayer;
    public Transform viewFloor;

    //La siguiente variable se llamaba "esdelasquevuelan" y no se a que se referia asi que solo la traduje
    public float thoseThatFly;
    private int Coin;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        flipPlayer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (jump && floor && Input.GetAxis("Jump") > 0)
        {
            player.velocity = new Vector2(player.velocity.x, 0f);
            player.AddForce(new Vector2(0, thoseThatFly), ForceMode2D.Impulse);
            floor = false;
        }

        floor = Physics2D.OverlapCircle(viewFloor.position, checkFloor, floorLayer);


        float move = Input.GetAxis("Horizontal");
        if (jump)
        {
            if (move > 0 && !flipLeft)
            {
                FlipSprite();
            }
            else if (move < 0 && flipLeft)
            {
                FlipSprite();
            }
            player.velocity = new Vector2(move * maxSpeed, player.velocity.y);
        }
        else
        {
            player.velocity = new Vector2(0, player.velocity.y);
        }
    }



    void FlipSprite()
    {
        flipLeft = !flipLeft;
        flipPlayer.flipX = !flipPlayer.flipX;
    }



    public void Jump()
    {
        jump = !jump;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ovni")
        {
            Over.lose();
        }
    }
    public void OnTriggerEnter2D(Collider other)
    {
        //Como el if esta usando un Tag no le cambie "Moneda" a ingles porque tendria que cambiar el Tag tambien
        if (other.gameObject.CompareTag("Moneda"))
        {
            other.gameObject.SetActive(false);
            Coin = Coin + 1;
        }

    }
}