using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    


    void Update()
    {   //dit zijn de inputs van de game
         if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector2.up * speed * Time.deltaTime);
        }
    } 
}
