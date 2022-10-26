using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float MoveSpeed = 4f;
    float xmovement;
    float ymovement;
    private float MoveSpeedIncrease = 1.52f;
    Vector2 BallDirection = new Vector2(1, 1);

    // Start is called before the first frame update
    void Start()
    {
        xmovement = Random.Range(0, 2) == 0 ? -1 : 1;
        ymovement = Random.Range(0, 2) == 0 ? -1 : 1;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1f,1f,Time.deltaTime);

    }
    private void Launch()
    {
        rb.velocity = new Vector2(xmovement * speed * Time.deltaTime, ymovement * speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            BallDirection = Vector3.Reflect(BallDirection, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            BallDirection = Vector3.Reflect(BallDirection, collision.contacts[0].normal);
            MoveSpeed = MoveSpeed * MoveSpeedIncrease;
        }
    }
}
