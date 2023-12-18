using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
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
        float speed = 15;
        rb.velocity = rb.velocity.normalized * speed;
        rb.AddForce(new Vector2(0, (float)-0.01), ForceMode2D.Force);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Jag kolliderade!");
        GameObject otherGameObject = collision.gameObject;
        BallBounce enemiecomponent = collision.gameObject.GetComponent<BallBounce>();
        reset utanför = collision.gameObject.GetComponent<reset>();
        if (enemiecomponent != null)
        {
            
            enemiecomponent.Hit();
        }
        if(utanför != null)
        {
            Debug.Log("Jag är i if-satsen");
            utanför.Ut();
        }
        
    }
}
