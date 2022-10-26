
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    public float MoveSpeed = 4f;
    private float MoveSpeedIncrease = 1.52f;
    Vector2 BallDirection = new Vector2(1, 1);
    private float DefaultMoveSpeed = 7;
    public ParticleSystem collisionParticleSystem;
    // Start is called before the first frame update
    void Start()
    {
        BallDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        if (BallDirection.x > -0.2f && BallDirection.x < 0.2f)
        {
            BallDirection = new Vector2(0.5f, BallDirection.y);
        }
        BallDirection = BallDirection.normalized;
    }
    // Update is called once per frame
    void Update()
    {
        //Hope it aint broken
        transform.Translate(BallDirection * MoveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var em = collisionParticleSystem.emission;
        if (collision.gameObject.CompareTag("Wall"))
        {
            BallDirection = Vector3.Reflect(BallDirection, collision.contacts[0].normal);
            em.enabled = true;
            collisionParticleSystem.Play();
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            BallDirection = Vector3.Reflect(BallDirection, collision.contacts[0].normal);
            em.enabled = true;
            collisionParticleSystem.Play();
            MoveSpeed = MoveSpeed * MoveSpeedIncrease;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<Scores>().AddP1Score();
        }
        if (collision.gameObject.CompareTag("Goal2"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<Scores>().AddP2Score();
        }
        
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0);
        BallDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        if (BallDirection.x > -0.2f && BallDirection.x < 0.2f)
        {
            BallDirection = new Vector2(0.5f, BallDirection.y);
        }
        BallDirection = BallDirection.normalized;
        MoveSpeed = DefaultMoveSpeed;
    }
    
   
}
