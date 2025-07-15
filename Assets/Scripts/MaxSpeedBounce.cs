using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeedBounce : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude > speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }
}
