using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    private float speed = .1f;
    private float jump_speed = 5f;
    private Rigidbody2D rigidbody2D;
    public static bool play = false;
    public GameObject Enemy;

    private void Awake()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        this.rigidbody2D.gravityScale = 0.0f;
    }


    void Update()
    {
        if (play == true)
        {
            float h = Input.GetAxis("Horizontal");
            this.transform.Translate(new Vector2(h * speed, 0));

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rigidbody2D.velocity = Vector2.up * jump_speed;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy" && play == true)
        {
            Destroy(gameObject);
        }
    }

    public void Jugar()
    {
        play = true;
        this.rigidbody2D.gravityScale = 1f;
    }
}
