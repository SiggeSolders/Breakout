using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2( 10f, 0f), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-10f, 0f), ForceMode2D.Force);
        }
    }
}