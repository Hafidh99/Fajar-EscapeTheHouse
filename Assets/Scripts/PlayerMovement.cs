using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] float speed = 5f;

    float[] direction = new float[2];

    // AudioSource audioSource;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        // audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        if (Input.GetAxisRaw("Horizontal") >= 1 || Input.GetAxisRaw("Horizontal") <= -1)
        {
            direction[0] = Input.GetAxisRaw("Horizontal");
            direction[1] = 0f;

        }

        if (Input.GetAxisRaw("Vertical") >= 1 || Input.GetAxisRaw("Vertical") <= -1)
        {
            direction[0] = 0f;
            direction[1] = Input.GetAxisRaw("Vertical");
            
        }
        
        anim.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));
        
        if (Input.GetAxisRaw("Horizontal") == 0 || Input.GetAxisRaw("Vertical") == 0)
        {
            anim.SetFloat("h_direction", direction[0]);
            anim.SetFloat("v_direction", direction[1]);
        }

        anim.SetFloat("speed", Mathf.Sqrt(Mathf.Pow(rb.velocity.x, 2) + Mathf.Pow(rb.velocity.y, 2)));
    }
}
