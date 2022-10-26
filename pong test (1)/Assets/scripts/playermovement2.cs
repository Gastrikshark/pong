using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement2 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(KeyCode.I))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.K))
            {
                transform.Translate(-Vector2.up * speed * Time.deltaTime);
            }
        
    }
}
