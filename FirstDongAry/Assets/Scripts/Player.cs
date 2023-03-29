using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    RaycastHit2D hit;
    float moveSpeed = 10.0f;
    public LayerMask GroundCheck;
    public LayerMask monsterLayer;
    public bool isPlayerWatchhinRight;
    public float jumpforce;
    public SpriteRenderer Img;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Img = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rb.velocity.y);
        if(Physics2D.Raycast(transform.position, Vector2.down, 2.5f,GroundCheck) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up* jumpforce, ForceMode2D.Impulse);
            
        }
        if (Input.GetKey(KeyCode.C))
        {
            if(Physics2D.Raycast(transform.position,Vector2.right,2,monsterLayer) && isPlayerWatchhinRight)
            {
                Debug.DrawRay(transform.position, Vector2.right * 2, Color.red);
            }
            if(Physics2D.Raycast(transform.position, Vector2.left,2,monsterLayer)&& !isPlayerWatchhinRight)
            {
                Debug.DrawRay(transform.position, Vector2.left * 2, Color.red);
            }
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            isPlayerWatchhinRight = true;
            Img.flipX = false;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            isPlayerWatchhinRight = false;
            Img.flipX = true;
        }



        //Debug.DrawRay(transform.position, Vector2.down * 2.5f);
    }
}
