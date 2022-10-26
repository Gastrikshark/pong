using UnityEngine;

public class PlayermovementLes : MonoBehaviour
{
    public int playerNumber = 1;
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetAxis("player1"));
        if (playerNumber == 1)
        
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player1") * Time.deltaTime, 0));
            

        }

        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("player2") * Time.deltaTime, 0));
            
        }

    }
}


