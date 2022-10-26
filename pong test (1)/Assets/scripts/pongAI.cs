using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongAI : MonoBehaviour
{
    public float speed;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        
            if (transform.position.y < ball.transform.position.y)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            if (transform.position.y > ball.transform.position.y)
            {
                transform.Translate(-Vector2.up * speed * Time.deltaTime);
            }
        
    }
}
